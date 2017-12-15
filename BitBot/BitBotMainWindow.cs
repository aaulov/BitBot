using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bittrex.Net;

namespace BitBot
{
    public partial class BitBotMainWindow : Form
    {
        private BittrexSocketClient socketClient;
        public BitBotMainWindow()
        {
            InitializeComponent();

            Load += LoadDone;
        }

        private void LoadDone(object sender, EventArgs e)
        {
            //    Task.Run(() => {
            //        socketClient = new BittrexSocketClient();
            //        socketClient.SubscribeToMarketDeltaStream("USDT-BTC", data => {
            //            //UpdateLastPrice (data);
            //        });
            //    });
            //    Task.Run(() => {
            //        using (var client = new BittrexClient())
            //        {
            //            var result = client.GetMarketSummary("USDT-BTC");
            //            //UpdateLastPrice(result.Result.Last);
            //            textBox1.Invoke(new Action(() => {
            //                textBox1.Text += "\nUSDT-BTC Volume: " + result.Result.Volume + "\n MarketName" + result.Result.MarketName;
            //            }));
            //        }
            //    });
        }

        //private void UpdateMarketData(Bittrex.Net.Objects.BittrexMarketSummary marketSummary)
        //{
        //    textBox1.Invoke(new Action(() => { textBox1.Text = "USDT-BTC Last price: " + price; }));
        //}
    }
}
