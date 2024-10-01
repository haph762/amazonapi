/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Pallet information.
    /// </summary>
    [DataContract]
    public partial class Pallet : IEquatable<Pallet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pallet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Pallet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pallet" /> class.
        /// </summary>
        /// <param name="dimensions">The dimensions of the pallet. Length and width must be 40 inches by 48 inches. Height must be less than or equal to 60 inches. (required).</param>
        /// <param name="weight">The weight of the pallet..</param>
        /// <param name="isStacked">Indicates whether pallets will be stacked when carrier arrives for pick-up. (required).</param>
        public Pallet(Dimensions dimensions = default(Dimensions), Weight weight = default(Weight), bool? isStacked = default(bool?))
        {
            // to ensure "dimensions" is required (not null)
            if (dimensions == null)
            {
                throw new InvalidDataException("dimensions is a required property for Pallet and cannot be null");
            }
            else
            {
                this.Dimensions = dimensions;
            }
            // to ensure "isStacked" is required (not null)
            if (isStacked == null)
            {
                throw new InvalidDataException("isStacked is a required property for Pallet and cannot be null");
            }
            else
            {
                this.IsStacked = isStacked;
            }
            this.Weight = weight;
        }

        /// <summary>
        /// The dimensions of the pallet. Length and width must be 40 inches by 48 inches. Height must be less than or equal to 60 inches.
        /// </summary>
        /// <value>The dimensions of the pallet. Length and width must be 40 inches by 48 inches. Height must be less than or equal to 60 inches.</value>
        [DataMember(Name = "Dimensions", EmitDefaultValue = false)]
        public Dimensions Dimensions { get; set; }

        /// <summary>
        /// The weight of the pallet.
        /// </summary>
        /// <value>The weight of the pallet.</value>
        [DataMember(Name = "Weight", EmitDefaultValue = false)]
        public Weight Weight { get; set; }

        /// <summary>
        /// Indicates whether pallets will be stacked when carrier arrives for pick-up.
        /// </summary>
        /// <value>Indicates whether pallets will be stacked when carrier arrives for pick-up.</value>
        [DataMember(Name = "IsStacked", EmitDefaultValue = false)]
        public bool? IsStacked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pallet {\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  IsStacked: ").Append(IsStacked).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as Pallet);
        }

        /// <summary>
        /// Returns true if Pallet instances are equal
        /// </summary>
        /// <param name="input">Instance of Pallet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pallet input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Dimensions == input.Dimensions ||
                    (this.Dimensions != null &&
                    this.Dimensions.Equals(input.Dimensions))
                ) &&
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) &&
                (
                    this.IsStacked == input.IsStacked ||
                    (this.IsStacked != null &&
                    this.IsStacked.Equals(input.IsStacked))
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
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.IsStacked != null)
                    hashCode = hashCode * 59 + this.IsStacked.GetHashCode();
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