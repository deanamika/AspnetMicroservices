using Discount.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.Api.GrpcServices
{
    public class DiscountGrpcService
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient _discountProtoServide;

        public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient discountProtoService )
        {
            _discountProtoServide = discountProtoService ?? throw new ArgumentException(nameof(discountProtoService));
        }

        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRequest = new GetDiscountRequest {ProductName = productName };
            return await _discountProtoServide.GetDiscountAsync(discountRequest);
        } 
    }

}
