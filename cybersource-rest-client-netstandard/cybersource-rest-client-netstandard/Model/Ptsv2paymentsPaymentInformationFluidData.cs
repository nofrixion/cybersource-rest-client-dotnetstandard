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
    /// Ptsv2paymentsPaymentInformationFluidData
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsPaymentInformationFluidData :  IEquatable<Ptsv2paymentsPaymentInformationFluidData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsPaymentInformationFluidData" /> class.
        /// </summary>
        /// <param name="KeySerialNumber">The encoded or encrypted value that a payment solution returns for an authorization request. For details about the valid values for a key, see [Creating an Online Authorization](https://developer.cybersource.com/api/developer-guides/dita-payments/CreatingOnlineAuth.html) .</param>
        /// <param name="Descriptor">The identifier for a payment solution, which is sending the encrypted payment data for decryption. Valid values: Samsung Pay: RklEPUNPTU1PTi5TQU1TVU5HLklOQVBQLlBBWU1FTlQ&#x3D; Note: For other payment solutions, the value may be specific to the terminal or device initiatinf the payment. For example, the descriptor for a Bluefin payment encryption would be a device-generated descriptor. Used by Authorization and Standalone Credits. Required for authorizations and standalone credits.  Card Present processing: Format of the encrypted payment data. The value for Bluefin PCI P2PE is &#x60;Ymx1ZWZpbg&#x3D;&#x3D;&#x60;. paymentInformation.fluidData.encoding must be &#x60;Base64&#x60;. The value for Cybersource P2PE decryption depends on the encoding method used and identified in encoding field. If paymentInformation.fluidData.encoding is &#x60;Base64&#x60;, the value is: &#x60;RklEPUVNVi5QQVlNRU5ULkFQSQ&#x3D;&#x3D;&#x60; If paymentInformation.fluidData.encoding is &#x60;HEX&#x60;, the value is: &#x60;4649443D454D562E5041594D454E542E41504&#x60; .</param>
        /// <param name="Value">Represents the encrypted payment data BLOB. The entry for this field is dependent on the payment solution used by the merchant. Used by Authorization and Standalone Credits. Required for authorizations and standalone credits that use a Cybersource suppored Point-to-Point encryption method. Card Present processing This field represents the encrypted payment data generated by the payment terminal/device. .</param>
        /// <param name="Encoding">Encoding method used to encrypt the payment data. Valid values: &#x60;Base64&#x60;, &#x60;HEX&#x60; If no value is provided, &#x60;Base64&#x60; is taken as the default value. And the &#x60;Base64&#x60; descriptor is used for paymentInformation.fluidData.encoding .</param>
        public Ptsv2paymentsPaymentInformationFluidData(string KeySerialNumber = default(string), string Descriptor = default(string), string Value = default(string), string Encoding = default(string))
        {
            this.KeySerialNumber = KeySerialNumber;
            this.Descriptor = Descriptor;
            this.Value = Value;
            this.Encoding = Encoding;
        }
        
        /// <summary>
        /// The encoded or encrypted value that a payment solution returns for an authorization request. For details about the valid values for a key, see [Creating an Online Authorization](https://developer.cybersource.com/api/developer-guides/dita-payments/CreatingOnlineAuth.html) 
        /// </summary>
        /// <value>The encoded or encrypted value that a payment solution returns for an authorization request. For details about the valid values for a key, see [Creating an Online Authorization](https://developer.cybersource.com/api/developer-guides/dita-payments/CreatingOnlineAuth.html) </value>
        [DataMember(Name="keySerialNumber", EmitDefaultValue=false)]
        public string KeySerialNumber { get; set; }

        /// <summary>
        /// The identifier for a payment solution, which is sending the encrypted payment data for decryption. Valid values: Samsung Pay: RklEPUNPTU1PTi5TQU1TVU5HLklOQVBQLlBBWU1FTlQ&#x3D; Note: For other payment solutions, the value may be specific to the terminal or device initiatinf the payment. For example, the descriptor for a Bluefin payment encryption would be a device-generated descriptor. Used by Authorization and Standalone Credits. Required for authorizations and standalone credits.  Card Present processing: Format of the encrypted payment data. The value for Bluefin PCI P2PE is &#x60;Ymx1ZWZpbg&#x3D;&#x3D;&#x60;. paymentInformation.fluidData.encoding must be &#x60;Base64&#x60;. The value for Cybersource P2PE decryption depends on the encoding method used and identified in encoding field. If paymentInformation.fluidData.encoding is &#x60;Base64&#x60;, the value is: &#x60;RklEPUVNVi5QQVlNRU5ULkFQSQ&#x3D;&#x3D;&#x60; If paymentInformation.fluidData.encoding is &#x60;HEX&#x60;, the value is: &#x60;4649443D454D562E5041594D454E542E41504&#x60; 
        /// </summary>
        /// <value>The identifier for a payment solution, which is sending the encrypted payment data for decryption. Valid values: Samsung Pay: RklEPUNPTU1PTi5TQU1TVU5HLklOQVBQLlBBWU1FTlQ&#x3D; Note: For other payment solutions, the value may be specific to the terminal or device initiatinf the payment. For example, the descriptor for a Bluefin payment encryption would be a device-generated descriptor. Used by Authorization and Standalone Credits. Required for authorizations and standalone credits.  Card Present processing: Format of the encrypted payment data. The value for Bluefin PCI P2PE is &#x60;Ymx1ZWZpbg&#x3D;&#x3D;&#x60;. paymentInformation.fluidData.encoding must be &#x60;Base64&#x60;. The value for Cybersource P2PE decryption depends on the encoding method used and identified in encoding field. If paymentInformation.fluidData.encoding is &#x60;Base64&#x60;, the value is: &#x60;RklEPUVNVi5QQVlNRU5ULkFQSQ&#x3D;&#x3D;&#x60; If paymentInformation.fluidData.encoding is &#x60;HEX&#x60;, the value is: &#x60;4649443D454D562E5041594D454E542E41504&#x60; </value>
        [DataMember(Name="descriptor", EmitDefaultValue=false)]
        public string Descriptor { get; set; }

        /// <summary>
        /// Represents the encrypted payment data BLOB. The entry for this field is dependent on the payment solution used by the merchant. Used by Authorization and Standalone Credits. Required for authorizations and standalone credits that use a Cybersource suppored Point-to-Point encryption method. Card Present processing This field represents the encrypted payment data generated by the payment terminal/device. 
        /// </summary>
        /// <value>Represents the encrypted payment data BLOB. The entry for this field is dependent on the payment solution used by the merchant. Used by Authorization and Standalone Credits. Required for authorizations and standalone credits that use a Cybersource suppored Point-to-Point encryption method. Card Present processing This field represents the encrypted payment data generated by the payment terminal/device. </value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Encoding method used to encrypt the payment data. Valid values: &#x60;Base64&#x60;, &#x60;HEX&#x60; If no value is provided, &#x60;Base64&#x60; is taken as the default value. And the &#x60;Base64&#x60; descriptor is used for paymentInformation.fluidData.encoding 
        /// </summary>
        /// <value>Encoding method used to encrypt the payment data. Valid values: &#x60;Base64&#x60;, &#x60;HEX&#x60; If no value is provided, &#x60;Base64&#x60; is taken as the default value. And the &#x60;Base64&#x60; descriptor is used for paymentInformation.fluidData.encoding </value>
        [DataMember(Name="encoding", EmitDefaultValue=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsPaymentInformationFluidData {\n");
            sb.Append("  KeySerialNumber: ").Append(KeySerialNumber).Append("\n");
            sb.Append("  Descriptor: ").Append(Descriptor).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsPaymentInformationFluidData);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsPaymentInformationFluidData instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsPaymentInformationFluidData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsPaymentInformationFluidData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.KeySerialNumber == other.KeySerialNumber ||
                    this.KeySerialNumber != null &&
                    this.KeySerialNumber.Equals(other.KeySerialNumber)
                ) && 
                (
                    this.Descriptor == other.Descriptor ||
                    this.Descriptor != null &&
                    this.Descriptor.Equals(other.Descriptor)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Encoding == other.Encoding ||
                    this.Encoding != null &&
                    this.Encoding.Equals(other.Encoding)
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
                if (this.KeySerialNumber != null)
                    hash = hash * 59 + this.KeySerialNumber.GetHashCode();
                if (this.Descriptor != null)
                    hash = hash * 59 + this.Descriptor.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Encoding != null)
                    hash = hash * 59 + this.Encoding.GetHashCode();
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
