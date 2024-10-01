/* 
 * Selling Partner API for Catalog Items
 *
 * The Selling Partner API for Catalog Items helps you programmatically retrieve item details for items in the catalog.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.CatalogItems
{
    /// <summary>
    /// The decimal value and unit.
    /// </summary>
    [DataContract]
    public partial class DecimalWithUnits : IEquatable<DecimalWithUnits>, IValidatableObject
    {
        public DecimalWithUnits()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecimalWithUnits" /> class.
        /// </summary>
        /// <param name="Value">The decimal value..</param>
        /// <param name="Units">The unit of the decimal value..</param>
        public DecimalWithUnits(decimal? Value = default(decimal?), string Units = default(string))
        {
            this.Value = Value;
            this.Units = Units;
        }

        /// <summary>
        /// The decimal value.
        /// </summary>
        /// <value>The decimal value.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// The unit of the decimal value.
        /// </summary>
        /// <value>The unit of the decimal value.</value>
        [DataMember(Name = "Units", EmitDefaultValue = false)]
        public string Units { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecimalWithUnits {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
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
            return this.Equals(input as DecimalWithUnits);
        }

        /// <summary>
        /// Returns true if DecimalWithUnits instances are equal
        /// </summary>
        /// <param name="input">Instance of DecimalWithUnits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecimalWithUnits input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) &&
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
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
