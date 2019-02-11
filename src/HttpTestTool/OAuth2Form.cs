using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpTestTool
{
    public partial class OAuth2Form : Form
    {
        private string _accessToken;
        private Action<string> _setBearerTokenAction;

        public OAuth2Form(Action<string> setBearerTokenAction)
        {
            _setBearerTokenAction = setBearerTokenAction;
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void OAuth2Form_Load(object sender, EventArgs e)
        {
            txtAuthority.Text = "http://localhost:5000";
            txtClientId.Text = "BiHuTest";
            txtClientSecret.Text = "123456";
            txtScope.Text = "api1";

        }

        private void btnAccessToken_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAuthority.Text) || string.IsNullOrWhiteSpace(txtClientId.Text) || string.IsNullOrWhiteSpace(txtClientSecret.Text) || string.IsNullOrWhiteSpace(txtScope.Text))
            {
                MessageBox.Show("参数不能为空！");
                return;
            }
            _accessToken = string.Empty;
            Task.Run(() =>
            {
                try
                {
                    var tokenResponse = RequestTokenAsync().Result;
                    if (!tokenResponse.IsError)
                    {
                        rtxtAccessToken.Text = tokenResponse.Json.ToString();
                        _accessToken = tokenResponse.AccessToken;
                    }
                    else
                    {
                        if (tokenResponse.ErrorType == ResponseErrorType.Http)
                        {
                            MessageBox.Show(tokenResponse.Error, tokenResponse.HttpStatusCode.ToString());
                        }
                        else
                        {
                            MessageBox.Show(tokenResponse.Raw);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private async Task<TokenResponse> RequestTokenAsync()
        {
            var client = new HttpClient();

            var disco = await client.GetDiscoveryDocumentAsync(txtAuthority.Text);
            if (disco.IsError) throw new Exception(disco.Error);

            var response = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,

                ClientId = txtClientId.Text,
                ClientSecret = txtClientSecret.Text,
                Scope = txtScope.Text
            });

            if (response.IsError) throw new Exception(response.Error);
            return response;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_accessToken))
                _setBearerTokenAction?.Invoke(_accessToken);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
