/*
 * AgGateway In-Field Product Id
 *
 * Allows the Retailer to send information about the actual product shipped to the Farmer, including shipment identifer, product identifiers, seed lot id, mixture batch id, seed treatment and product composition.  Allows the Farmer (via a mobile application or FMIS), or the Farmer's equipment manufacturer application (aka OEM Platform, e.g., Deere Operations Center, AGCO Fuse, CNH AFS, etc.) to retrieve the Product shipped by a Retailer using GET /setupfiles.   
 *
 * OpenAPI spec version: V4
 * Contact: wg01@aggateway.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// Address of the ship to location
    /// </summary>
    [DataContract]
    public partial class ShipToPartyLocationAddress : IEquatable<ShipToPartyLocationAddress>
    { 
        /// <summary>
        /// Gets or Sets AddressLine
        /// </summary>

        [DataMember(Name="addressLine")]
        public List<string> AddressLine { get; set; }

        /// <summary>
        /// Gets or Sets CityName
        /// </summary>

        [DataMember(Name="cityName")]
        public string CityName { get; set; }

        /// <summary>
        /// Gets or Sets CountrySubDivisionCode
        /// </summary>

        [DataMember(Name="countrySubDivisionCode")]
        public ShipToPartyLocationAddressCountrySubDivisionCode CountrySubDivisionCode { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>

        [DataMember(Name="postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipToPartyLocationAddress {\n");
            sb.Append("  AddressLine: ").Append(AddressLine).Append("\n");
            sb.Append("  CityName: ").Append(CityName).Append("\n");
            sb.Append("  CountrySubDivisionCode: ").Append(CountrySubDivisionCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ShipToPartyLocationAddress)obj);
        }

        /// <summary>
        /// Returns true if ShipToPartyLocationAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of ShipToPartyLocationAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipToPartyLocationAddress other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AddressLine == other.AddressLine ||
                    AddressLine != null &&
                    AddressLine.SequenceEqual(other.AddressLine)
                ) && 
                (
                    CityName == other.CityName ||
                    CityName != null &&
                    CityName.Equals(other.CityName)
                ) && 
                (
                    CountrySubDivisionCode == other.CountrySubDivisionCode ||
                    CountrySubDivisionCode != null &&
                    CountrySubDivisionCode.Equals(other.CountrySubDivisionCode)
                ) && 
                (
                    PostalCode == other.PostalCode ||
                    PostalCode != null &&
                    PostalCode.Equals(other.PostalCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (AddressLine != null)
                    hashCode = hashCode * 59 + AddressLine.GetHashCode();
                    if (CityName != null)
                    hashCode = hashCode * 59 + CityName.GetHashCode();
                    if (CountrySubDivisionCode != null)
                    hashCode = hashCode * 59 + CountrySubDivisionCode.GetHashCode();
                    if (PostalCode != null)
                    hashCode = hashCode * 59 + PostalCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ShipToPartyLocationAddress left, ShipToPartyLocationAddress right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ShipToPartyLocationAddress left, ShipToPartyLocationAddress right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
