using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAddressBook.Services
{
    public interface IImageService
    {
       //encode an image from an upload control
        Task<byte[]> EncodePosterAsync(IFormFile poster);

        //encode an image from url
        Task<byte[]> EncodeImageURLAsync(string imageURL);

        string DecodePoster(byte[] poster, string contentType);

        string RecordContentType(IFormFile poster);


    }
}
