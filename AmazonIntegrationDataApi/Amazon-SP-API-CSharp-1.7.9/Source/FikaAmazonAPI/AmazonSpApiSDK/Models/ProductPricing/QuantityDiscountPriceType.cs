/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductPricing
{
    /// <summary>
    /// Contains pricing information that includes special pricing when buying in bulk.
    /// </summary>
    [DataContract]
    public partial class QuantityDiscountPriceType :  IEquatable<QuantityDiscountPriceType>, IValidatableObject
    {
        /// <summary>
        /// Indicates the type of quantity discount this price applies to.
        /// </summary>
        /// <value>Indicates the type of quantity discount this price applies to.</value>
        [DataMember(Name="quantityDiscountType", EmitDefaultValue=false)]
        public QuantityDiscountType QuantityDiscountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityDiscountPriceType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public QuantityDiscountPriceType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityDiscountPriceType" /> class.
        /// </summary>
        /// <param name="quantityTier">Indicates at what quantity this price becomes active. (required).</param>
        /// <param name="quantityDiscountType">Indicates the type of quantity discount this price applies to. (required).</param>
        /// <param name="listingPrice">The price at this quantity tier. (required).</param>
        public QuantityDiscountPriceType(int? quantityTier = default(int?), QuantityDiscountType quantityDiscountType = default(QuantityDiscountType), MoneyType price = default(MoneyType))
        {
            // to ensure "quantityTier" is required (not null)
            if (quantityTier == null)
            {
                throw new InvalidDataException("quantityTier is a required property for QuantityDiscountPriceType and cannot be null");
            }
            else
            {
                this.QuantityTier = quantityTier;
            }
            // to ensure "quantityDiscountType" is required (not null)
            if (quantityDiscountType == null)
            {
                throw new InvalidDataException("quantityDiscountType is a required property for QuantityDiscountPriceType and cannot be null");
            }
            else
            {
                this.QuantityDiscountType = quantityDiscountType;
            }
            // to ensure "listingPrice" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("listingPrice is a required property for QuantityDiscountPriceType and cannot be null");
            }
            else
            {
                this.Price = price;
            }
        }
        
        /// <summary>
        /// Indicates at what quantity this price becomes active.
        /// </summary>
        /// <value>Indicates at what quantity this price becomes active.</value>
        [DataMember(Name="quantityTier", EmitDefaultValue=false)]
        public int? QuantityTier { get; set; }


        /// <summary>
        /// The price at this quantity tier.
        /// </summary>
        /// <value>The price at this quantity tier.</value>
        [DataMember(Name= "price", EmitDefaultValue=false)]
        public MoneyType Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuantityDiscountPriceType {\n");
            sb.Append("  QuantityTier: ").Append(QuantityTier).Append("\n");
            sb.Append("  QuantityDiscountType: ").Append(QuantityDiscountType).Append("\n");
            sb.Append("  ListingPrice: ").Append(Price).Append("\n");
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
            return this.Equals(input as QuantityDiscountPriceType);
        }

        /// <summary>
        /// Returns true if QuantityDiscountPriceType instances are equal
        /// </summary>
        /// <param name="input">Instance of QuantityDiscountPriceType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuantityDiscountPriceType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuantityTier == input.QuantityTier ||
                    (this.QuantityTier != null &&
                    this.QuantityTier.Equals(input.QuantityTier))
                ) && 
                (
                    this.QuantityDiscountType == input.QuantityDiscountType ||
                    (this.QuantityDiscountType != null &&
                    this.QuantityDiscountType.Equals(input.QuantityDiscountType))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
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
                if (this.QuantityTier != null)
                    hashCode = hashCode * 59 + this.QuantityTier.GetHashCode();
                if (this.QuantityDiscountType != null)
                    hashCode = hashCode * 59 + this.QuantityDiscountType.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
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
