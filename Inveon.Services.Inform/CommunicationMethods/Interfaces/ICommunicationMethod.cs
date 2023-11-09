using Inveon.Services.Inform.Models;

namespace Inveon.Services.Inform.CommunicationMethods.Interfaces
{
    public interface ICommunicationMethod
    {
        void SendMessage(CheckoutHeaderDto checkoutHeader);
    }
}
