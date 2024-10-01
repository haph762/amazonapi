/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductPricing
{
    /// <summary>
    /// MoneyType
    /// </summary>
    [DataContract]
    public partial class MoneyType : IEquatable<MoneyType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public MoneyType() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyType" /> class.
        /// </summary>
        /// <param name="CurrencyCode">The currency code in ISO 4217 format..</param>
        /// <param name="Amount">The monetary value..</param>
        public MoneyType(string CurrencyCode = default(string), decimal? Amount = default(decimal?))
        {
            this.CurrencyCode = CurrencyCode;
            this.Amount = Amount;
        }

        /// <summary>
        /// The currency code in ISO 4217 format.
        /// </summary>
        /// <value>The currency code in ISO 4217 format.</value>
        [DataMember(Name = "CurrencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The monetary value.
        /// </summary>
        /// <value>The monetary value.</value>
        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoneyType {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
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
            return this.Equals(input as MoneyType);
        }

        /// <summary>
        /// Returns true if MoneyType instances are equal
        /// </summary>
        /// <param name="input">Instance of MoneyType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoneyType input)
        {
            if (input == null)
                return false;

            return
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
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
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
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
