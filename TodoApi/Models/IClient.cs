using OnlinePayments.Sdk;
using OnlinePayments.Sdk.Merchant;
using OnlinePayments;

namespace TodoApi.Models
{
    public class IClient
    {
		// Declare the IClient field for the SDK initialisation and for later use.
		private IClient client;

		// In case you use one PSPID, declare the IMerchantClient field.
		private IMerchantClient merchantClient;

        public object merchantId { get; private set; }

        public void SetupDirectSDK()
		{
			// Create a URI to target our test or live environment
			Uri apiEndpoint = new Uri("https://payment.preprod.direct.worldline-solutions.com");

			// Initialise client with the Uri and your API key/API secret from your PSPID		
			client = Factory.CreateClient(apiKey, apiSecret, apiEndpoint, integrator);

			// In case you have multiple PSPIDs, please substitute the merchantClient in the subsequent examples with this code sample: 
			merchantClient = client.WithNewMerchant(merchantId);
		}

        private IMerchantClient WithNewMerchant(object merchantId)
        {
            throw new NotImplementedException();
        }
    }
}
