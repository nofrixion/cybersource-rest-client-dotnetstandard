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
    /// Ptsv2paymentsTravelInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsTravelInformation :  IEquatable<Ptsv2paymentsTravelInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsTravelInformation" /> class.
        /// </summary>
        /// <param name="Duration">Duration of the auto rental or lodging rental.  #### Auto rental This field is supported for Visa, MasterCard, and American Express. **Important** If this field is not included when the &#x60;processingInformation.industryDataType&#x60; is auto rental, the transaction is declined. .</param>
        /// <param name="Agency">Agency.</param>
        /// <param name="AutoRental">AutoRental.</param>
        /// <param name="Lodging">Lodging.</param>
        /// <param name="Transit">Transit.</param>
        public Ptsv2paymentsTravelInformation(string Duration = default(string), Ptsv2paymentsTravelInformationAgency Agency = default(Ptsv2paymentsTravelInformationAgency), Ptsv2paymentsTravelInformationAutoRental AutoRental = default(Ptsv2paymentsTravelInformationAutoRental), Ptsv2paymentsTravelInformationLodging Lodging = default(Ptsv2paymentsTravelInformationLodging), Ptsv2paymentsTravelInformationTransit Transit = default(Ptsv2paymentsTravelInformationTransit))
        {
            this.Duration = Duration;
            this.Agency = Agency;
            this.AutoRental = AutoRental;
            this.Lodging = Lodging;
            this.Transit = Transit;
        }
        
        /// <summary>
        /// Duration of the auto rental or lodging rental.  #### Auto rental This field is supported for Visa, MasterCard, and American Express. **Important** If this field is not included when the &#x60;processingInformation.industryDataType&#x60; is auto rental, the transaction is declined. 
        /// </summary>
        /// <value>Duration of the auto rental or lodging rental.  #### Auto rental This field is supported for Visa, MasterCard, and American Express. **Important** If this field is not included when the &#x60;processingInformation.industryDataType&#x60; is auto rental, the transaction is declined. </value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or Sets Agency
        /// </summary>
        [DataMember(Name="agency", EmitDefaultValue=false)]
        public Ptsv2paymentsTravelInformationAgency Agency { get; set; }

        /// <summary>
        /// Gets or Sets AutoRental
        /// </summary>
        [DataMember(Name="autoRental", EmitDefaultValue=false)]
        public Ptsv2paymentsTravelInformationAutoRental AutoRental { get; set; }

        /// <summary>
        /// Gets or Sets Lodging
        /// </summary>
        [DataMember(Name="lodging", EmitDefaultValue=false)]
        public Ptsv2paymentsTravelInformationLodging Lodging { get; set; }

        /// <summary>
        /// Gets or Sets Transit
        /// </summary>
        [DataMember(Name="transit", EmitDefaultValue=false)]
        public Ptsv2paymentsTravelInformationTransit Transit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsTravelInformation {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Agency: ").Append(Agency).Append("\n");
            sb.Append("  AutoRental: ").Append(AutoRental).Append("\n");
            sb.Append("  Lodging: ").Append(Lodging).Append("\n");
            sb.Append("  Transit: ").Append(Transit).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsTravelInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsTravelInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsTravelInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsTravelInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.Agency == other.Agency ||
                    this.Agency != null &&
                    this.Agency.Equals(other.Agency)
                ) && 
                (
                    this.AutoRental == other.AutoRental ||
                    this.AutoRental != null &&
                    this.AutoRental.Equals(other.AutoRental)
                ) && 
                (
                    this.Lodging == other.Lodging ||
                    this.Lodging != null &&
                    this.Lodging.Equals(other.Lodging)
                ) && 
                (
                    this.Transit == other.Transit ||
                    this.Transit != null &&
                    this.Transit.Equals(other.Transit)
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
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.Agency != null)
                    hash = hash * 59 + this.Agency.GetHashCode();
                if (this.AutoRental != null)
                    hash = hash * 59 + this.AutoRental.GetHashCode();
                if (this.Lodging != null)
                    hash = hash * 59 + this.Lodging.GetHashCode();
                if (this.Transit != null)
                    hash = hash * 59 + this.Transit.GetHashCode();
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
            yield break;
        }
    }

}
