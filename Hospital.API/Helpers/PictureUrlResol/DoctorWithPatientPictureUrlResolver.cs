﻿using AutoMapper;
using Hospital.API.DTO;
using Hospital.Core.Models.Domain;

namespace Hospital.API.Helpers.PictureUrlResol
{
    public class DoctorWithPatientPictureUrlResolver : IValueResolver<Doctor, DoctorWithPatientDto, string>
    {
    

        private readonly IConfiguration _configuration;

        public DoctorWithPatientPictureUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Resolve(Doctor source, DoctorWithPatientDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return $"{_configuration["Base"]}/{source.PictureUrl}";
            }
            return string.Empty;
        }
    }
}
