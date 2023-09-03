using MM_Models.Api.Command;
using MM_Models.Api.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Models.Api.Mappers
{
    internal static class Mappers
    {
        internal static User ToUser(this IDataRecord dataRecord)
        {
            // Convert the byte[] (Passwd) to a string
            var passwordBytes = (byte[])dataRecord["Password"];
            var password = Encoding.UTF8.GetString(passwordBytes);

            // Create the User object with the converted Passwd
            return new User(
                (int)dataRecord["Id"],
                (string)dataRecord["FirstName"],
                (string)dataRecord["LastName"],
                (string)dataRecord["UserName"],
                (string)dataRecord["Email"],
                (DateTime)dataRecord["BirthDate"],
                password
            );
        }

        internal static Artist ToArtist(this IDataRecord dataRecord) 
        {
            return new Artist(
                (int)dataRecord["Id"],
                (string)dataRecord["ArtistName"],
                (string)dataRecord["Genres"]
                );
        }

        internal static Masher ToMasher(this IDataRecord dataRecord)
        {
            return new Masher(
                (int)dataRecord["Id"],
                (string)dataRecord["MasherName"],
                (string)dataRecord["Weblink"]
                );
        }

        internal static Track ToTrack(this IDataRecord dataRecord)
        {
            return new Track(
                (int)dataRecord["Id"],
                (string)dataRecord["Title"],
                (int)dataRecord["Length"],
                (bool)dataRecord["Explicit"],
                (string)dataRecord["ArtistName"],
                (int)dataRecord["ArtistId"]
                );
        }

        internal static Mashup ToMashup(this IDataRecord dataRecord)
        {
            return new Mashup(
                (int)dataRecord["Id"],
                (string)dataRecord["Title"],
                (string)dataRecord["PathFile"],
                (int)dataRecord["Length"],
                (TrackId)dataRecord["TrackIds"],
                (int)dataRecord["Masherid"]
                );
            ;
        }

        internal static Mashup ToMashupByArtist(this IDataRecord dataRecord) 
        {
            return new Mashup(
            (string)dataRecord["Artist"],
            (string)dataRecord["Mashups"]
                );
        }

        internal static Mashup ToMashupByMasher(this IDataRecord dataRecord)
        {
            return new Mashup(
            (string)dataRecord["Masher"],
            (string)dataRecord["Mashup"]
                );
        }

        internal static Mashup ToMashupbyId(this IDataRecord dataRecord)
        {
            return new Mashup(
            (string)dataRecord["PathFile"]
                );
        }
    }

}
