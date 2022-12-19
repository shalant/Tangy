﻿using Tangy_Models;
using TangyWeb_Client.ViewModels;

namespace TangyWeb_Client.Service.IService
{
    public interface IPaymentService
    {
        public Task<SuccessModelDTO> CheckoutException(StripePaymentDTO model);
    }
}
