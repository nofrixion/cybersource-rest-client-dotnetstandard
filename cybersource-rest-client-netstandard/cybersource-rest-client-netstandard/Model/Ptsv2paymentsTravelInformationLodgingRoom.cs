/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Ptsv2paymentsTravelInformationLodgingRoom
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsTravelInformationLodgingRoom :  IEquatable<Ptsv2paymentsTravelInformationLodgingRoom>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsTravelInformationLodgingRoom" /> class.
        /// </summary>
        /// <param name="DailyRate">Daily cost of the room. .</param>
        /// <param name="NumberOfNights">Number of nights billed at the rate specified by &#x60;travelInformation.lodging.room[].dailyRate&#x60;. .</param>
        public Ptsv2paymentsTravelInformationLodgingRoom(string DailyRate = default(string), int? NumberOfNights = default(int?))
        {
            this.DailyRate = DailyRate;
            this.NumberOfNights = NumberOfNights;
        }
        
        /// <summary>
        /// Daily cost of the room. 
        /// </summary>
        /// <value>Daily cost of the room. </value>
        [DataMember(Name="dailyRate", EmitDefaultValue=false)]
        public string DailyRate { get; set; }

        /// <summary>
        /// Number of nights billed at the rate specified by &#x60;travelInformation.lodging.room[].dailyRate&#x60;. 
        /// </summary>
        /// <value>Number of nights billed at the rate specified by &#x60;travelInformation.lodging.room[].dailyRate&#x60;. </value>
        [DataMember(Name="numberOfNights", EmitDefaultValue=false)]
        public int? NumberOfNights { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsTravelInformationLodgingRoom {\n");
            sb.Append("  DailyRate: ").Append(DailyRate).Append("\n");
            sb.Append("  NumberOfNights: ").Append(NumberOfNights).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Ptsv2paymentsTravelInformationLodgingRoom);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsTravelInformationLodgingRoom instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsTravelInformationLodgingRoom to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsTravelInformationLodgingRoom other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DailyRate == other.DailyRate ||
                    this.DailyRate != null &&
                    this.DailyRate.Equals(other.DailyRate)
                ) && 
                (
                    this.NumberOfNights == other.NumberOfNights ||
                    this.NumberOfNights != null &&
                    this.NumberOfNights.Equals(other.NumberOfNights)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.DailyRate != null)
                    hash = hash * 59 + this.DailyRate.GetHashCode();
                if (this.NumberOfNights != null)
                    hash = hash * 59 + this.NumberOfNights.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // NumberOfNights (int?) maximum
            if(this.NumberOfNights >= (int?)9999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberOfNights, must be a value less than or equal to 9999.", new [] { "NumberOfNights" });
            }

            // NumberOfNights (int?) minimum
            if(this.NumberOfNights <= (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberOfNights, must be a value greater than or equal to 1.", new [] { "NumberOfNights" });
            }

            yield break;
        }
    }

}
