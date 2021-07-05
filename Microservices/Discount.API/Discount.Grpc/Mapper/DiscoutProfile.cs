using System;
using AutoMapper;
using Discount.Grpc.Entities;
using Discount.Grpc.Protos;

namespace Discount.Grpc.Mapper
{
    public class DiscoutProfile : Profile
    {
        public DiscoutProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
