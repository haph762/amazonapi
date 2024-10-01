/* 
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Finances
{
    /// <summary>
    /// A payment instrument.
    /// </summary>
    [DataContract]
    public partial class ChargeInstrument : IEquatable<ChargeInstrument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeInstrument" /> class.
        /// </summary>
        /// <param name="Description">A short description of the charge instrument..</param>
        /// <param name="Tail">The account tail (trailing digits) of the charge instrument..</param>
        /// <param name="Amount">The amount charged to this charge instrument..</param>
        public ChargeInstrument(string Description = default(string), string Tail = default(string), Currency Amount = default(Currency))
        {
            this.Description = Description;
            this.Tail = Tail;
            this.Amount = Amount;
        }

        /// <summary>
        /// A short description of the charge instrument.
        /// </summary>
        /// <value>A short description of the charge instrument.</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The account tail (trailing digits) of the charge instrument.
        /// </summary>
        /// <value>The account tail (trailing digits) of the charge instrument.</value>
        [DataMember(Name = "Tail", EmitDefaultValue = false)]
        public string Tail { get; set; }

        /// <summary>
        /// The amount charged to this charge instrument.
        /// </summary>
        /// <value>The amount charged to this charge instrument.</value>
        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeInstrument {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tail: ").Append(Tail).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChargeInstrument);
        }

        /// <summary>
        /// Returns true if ChargeInstrument instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeInstrument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeInstrument input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) &&
                (
                    this.Tail == input.Tail ||
                    (this.Tail != null &&
                    this.Tail.Equals(input.Tail))
                ) &&
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                int hashCode = 41;
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Tail != null)
                    hashCode = hashCode * 59 + this.Tail.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                return hashCode;
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
