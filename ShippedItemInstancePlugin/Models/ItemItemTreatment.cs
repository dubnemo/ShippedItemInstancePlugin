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
    /// Seed Treatment; List of product mixture identifiers that were blended together to create the seed treatment, and when lot[typeCode&#x3D;&#x27;batch&#x27;].identifier is present This should be Item Composition component
    /// </summary>
    [DataContract]
    public partial class ItemItemTreatment : IEquatable<ItemItemTreatment>
    { 
        /// <summary>
        /// Manufacturer&#x27;s or Retailer&#x27;s Seed Treatment identifier
        /// </summary>
        /// <value>Manufacturer&#x27;s or Retailer&#x27;s Seed Treatment identifier</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Manufacturer or Retailer&#x27;s name of the seed treatment
        /// </summary>
        /// <value>Manufacturer or Retailer&#x27;s name of the seed treatment</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Substances found in the seed treatment
        /// </summary>
        /// <value>Substances found in the seed treatment</value>

        [DataMember(Name="substance")]
        public List<ItemItemTreatmentSubstance> Substance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemItemTreatment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Substance: ").Append(Substance).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ItemItemTreatment)obj);
        }

        /// <summary>
        /// Returns true if ItemItemTreatment instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemItemTreatment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemItemTreatment other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Substance == other.Substance ||
                    Substance != null &&
                    Substance.SequenceEqual(other.Substance)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Substance != null)
                    hashCode = hashCode * 59 + Substance.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ItemItemTreatment left, ItemItemTreatment right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ItemItemTreatment left, ItemItemTreatment right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
