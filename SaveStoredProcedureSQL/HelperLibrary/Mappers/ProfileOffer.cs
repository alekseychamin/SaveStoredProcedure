using AutoMapper;
using HelperLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelperLibrary.Mappers
{
    public class ProfileOffer : Profile
    {
        public ProfileOffer()
        {
            CreateMap<Offer, OfferDb>()
                .ForMember(dest => dest.Artist, opt => opt.MapFrom(s => s.artist))
                .ForMember(dest => dest.Author, opt => opt.MapFrom(s => s.author))
                .ForMember(dest => dest.Available, opt => opt.MapFrom(s => s.available))
                .ForMember(dest => dest.Bid, opt => opt.MapFrom(s => s.bid))
                .ForMember(dest => dest.Binding, opt => opt.MapFrom(s => s.binding))
                .ForMember(dest => dest.CategoryIdType, opt => opt.MapFrom(s => s.categoryId.type))
                .ForMember(dest => dest.CategoryIdValue, opt => opt.MapFrom(s => s.categoryId.Value))
                .ForMember(dest => dest.Cbid, opt => opt.MapFrom(s => s.cbid))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(s => s.country))
                .ForMember(dest => dest.CountryOfOrigin, opt => opt.MapFrom(s => s.country_of_origin))
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(s => s.currencyId))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(s => s.dateDeserialized))
                .ForMember(dest => dest.DateTour, opt => opt.MapFrom(s => s.dateTourStart))
                .ForMember(dest => dest.DateTourFinish, opt => opt.MapFrom(s => s.dateTourFinish))
                .ForMember(dest => dest.Days, opt => opt.MapFrom(s => s.days))
                .ForMember(dest => dest.Delivery, opt => opt.MapFrom(s => s.delivery))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(s => s.description))
                .ForMember(dest => dest.Director, opt => opt.MapFrom(s => s.director))
                .ForMember(dest => dest.Downloadable, opt => opt.MapFrom(s => s.downloadable))
                .ForMember(dest => dest.Format, opt => opt.MapFrom(s => s.format))
                .ForMember(dest => dest.HallPart, opt => opt.MapFrom(s => s.hall_part))
                .ForMember(dest => dest.HallPlan, opt => opt.MapFrom(s => s.hall.plan))
                .ForMember(dest => dest.HallValue, opt => opt.MapFrom(s => s.hall.Value))
                .ForMember(dest => dest.HotelStars, opt => opt.MapFrom(s => s.hotel_stars))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(s => s.id))
                .ForMember(dest => dest.Included, opt => opt.MapFrom(s => s.included))
                .ForMember(dest => dest.ISBN, opt => opt.MapFrom(s => s.ISBN))
                .ForMember(dest => dest.IsKids, opt => opt.MapFrom(s => s.is_kids))
                .ForMember(dest => dest.IsPremiere, opt => opt.MapFrom(s => s.is_premiere))
                .ForMember(dest => dest.Language, opt => opt.MapFrom(s => s.language))
                .ForMember(dest => dest.LocalDeliveryCost, opt => opt.MapFrom(s => s.local_delivery_cost))
                .ForMember(dest => dest.ManufacturerWarranty, opt => opt.MapFrom(s => s.manufacturer_warranty))
                .ForMember(dest => dest.Meal, opt => opt.MapFrom(s => s.meal))
                .ForMember(dest => dest.Media, opt => opt.MapFrom(s => s.media))
                .ForMember(dest => dest.Model, opt => opt.MapFrom(s => s.model))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(s => s.name))
                .ForMember(dest => dest.OriginalName, opt => opt.MapFrom(s => s.originalName))
                .ForMember(dest => dest.PageExtent, opt => opt.MapFrom(s => s.page_extent))
                .ForMember(dest => dest.Part, opt => opt.MapFrom(s => s.part))
                .ForMember(dest => dest.PerformanceType, opt => opt.MapFrom(s => s.performance_type))
                .ForMember(dest => dest.PerformedBy, opt => opt.MapFrom(s => s.performed_by))
                .ForMember(dest => dest.Picture, opt => opt.MapFrom(s => s.picture))
                .ForMember(dest => dest.Place, opt => opt.MapFrom(s => s.place))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(s => s.price))
                .ForMember(dest => dest.Publisher, opt => opt.MapFrom(s => s.publisher))
                .ForMember(dest => dest.RecordingLength, opt => opt.MapFrom(s => s.recording_length))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(s => s.region))
                .ForMember(dest => dest.Room, opt => opt.MapFrom(s => s.room))
                .ForMember(dest => dest.Series, opt => opt.MapFrom(s => s.series))
                .ForMember(dest => dest.Starring, opt => opt.MapFrom(s => s.starring))
                .ForMember(dest => dest.Storage, opt => opt.MapFrom(s => s.storage))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(s => s.title))
                .ForMember(dest => dest.Transport, opt => opt.MapFrom(s => s.transport))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(s => s.type))
                .ForMember(dest => dest.TypePrefix, opt => opt.MapFrom(s => s.typePrefix))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(s => s.url))
                .ForMember(dest => dest.Vendor, opt => opt.MapFrom(s => s.vendor))
                .ForMember(dest => dest.VendorCode, opt => opt.MapFrom(s => s.vendorCode))
                .ForMember(dest => dest.Volume, opt => opt.MapFrom(s => s.volume))
                .ForMember(dest => dest.WorldRegion, opt => opt.MapFrom(s => s.worldRegion))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(s => s.year));
        }
    }
}
