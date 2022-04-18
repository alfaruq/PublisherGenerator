using Amazon.SQS;
using Amazon.SQS.Model;
using Newtonsoft.Json;
using PublisherGenerator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublisherGenerator
{
    public partial class Form1 : Form
    {
        private AmazonSQSClient _objClient;
        private static int _delay = 100;
        private int _lowerBound = 0;
        private int _upperBound = 0;
        private string _stdQueue = string.Empty;
        private string _fifoQueue = string.Empty;
        private string _msgGrpId = "1";
        private BackgroundWorker backgroundWorker;
        private bool _isFifo = false;

        public Form1()
        {
            InitializeComponent();

            _objClient = new AmazonSQSClient(); 
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Done");
            btnFire.Enabled = true;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = _lowerBound; i <= _upperBound; i++)
            {
                var order = new PurchaseOrder();
                order.OrderNo = i;
                order.OrderDate = DateTime.Now;

                var payload = JsonConvert.SerializeObject(order);

                if (_isFifo)
                {
                    var request = new SendMessageRequest()
                    {
                        QueueUrl = _fifoQueue,
                        MessageBody = payload,
                        MessageGroupId = _msgGrpId,
                        MessageDeduplicationId = ComputeSha256Hash(payload)
                    };

                    _objClient.SendMessage(request);
                }
                else
                {
                    _objClient.SendMessage(_stdQueue, payload);
                }

                System.Threading.Thread.Sleep(_delay);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Init

            _stdQueue = ConfigurationManager.AppSettings["StdQueueURL"];
            _fifoQueue = ConfigurationManager.AppSettings["FifoQueueURL"];

            txtFifoQueue.Text = _fifoQueue;
            txtStdQueue.Text = _stdQueue;   

            #endregion
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            try
            {
                _isFifo = cbFifo.Checked;
                int.TryParse(txtLowerBound.Text, out _lowerBound);
                int.TryParse(txtUpperBound.Text, out _upperBound);

                _fifoQueue = txtFifoQueue.Text.Trim();
                _stdQueue = txtStdQueue.Text.Trim();

                if (_upperBound < _lowerBound)
                    throw new Exception("Invalid Upperbound!");

                btnFire.Enabled = false;
                backgroundWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
