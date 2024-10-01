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
    /// An event linked to the payment of a fee related to the specified deal.
    /// </summary>
    [DataContract]
    public partial class SellerDealPaymentEvent : IEquatable<SellerDealPaymentEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SellerDealPaymentEvent" /> class.
        /// </summary>
        /// <param name="PostedDate">The date and time when the financial event was posted..</param>
        /// <param name="DealId">The unique identifier of the deal..</param>
        /// <param name="DealDescription">The internal description of the deal..</param>
        /// <param name="EventType">The type of event: SellerDealComplete..</param>
        /// <param name="FeeType">The type of fee: RunLightningDealFee..</param>
        /// <param name="FeeAmount">The monetary amount of the fee..</param>
        /// <param name="TaxAmount">The monetary amount of the tax applied..</param>
        /// <param name="TotalAmount">The total monetary amount paid..</param>
        public SellerDealPaymentEvent(DateTime? PostedDate = default(DateTime?), string DealId = default(string), string DealDescription = default(string), string EventType = default(string), string FeeType = default(string), Currency FeeAmount = default(Currency), Currency TaxAmount = default(Currency), Currency TotalAmount = default(Currency))
        {
            this.PostedDate = PostedDate;
            this.DealId = DealId;
            this.DealDescription = DealDescription;
            this.EventType = EventType;
            this.FeeType = FeeType;
            this.FeeAmount = FeeAmount;
            this.TaxAmount = TaxAmount;
            this.TotalAmount = TotalAmount;
        }

        /// <summary>
        /// The date and time when the financial event was posted.
        /// </summary>
        /// <value>The date and time when the financial event was posted.</value>
        [DataMember(Name = "postedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// The unique identifier of the deal.
        /// </summary>
        /// <value>The unique identifier of the deal.</value>
        [DataMember(Name = "dealId", EmitDefaultValue = false)]
        public string DealId { get; set; }

        /// <summary>
        /// The internal description of the deal.
        /// </summary>
        /// <value>The internal description of the deal.</value>
        [DataMember(Name = "dealDescription", EmitDefaultValue = false)]
        public string DealDescription { get; set; }

        /// <summary>
        /// The type of event: SellerDealComplete.
        /// </summary>
        /// <value>The type of event: SellerDealComplete.</value>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// The type of fee: RunLightningDealFee.
        /// </summary>
        /// <value>The type of fee: RunLightningDealFee.</value>
        [DataMember(Name = "feeType", EmitDefaultValue = false)]
        public string FeeType { get; set; }

        /// <summary>
        /// The monetary amount of the fee.
        /// </summary>
        /// <value>The monetary amount of the fee.</value>
        [DataMember(Name = "feeAmount", EmitDefaultValue = false)]
        public Currency FeeAmount { get; set; }

        /// <summary>
        /// The monetary amount of the tax applied.
        /// </summary>
        /// <value>The monetary amount of the tax applied.</value>
        [DataMember(Name = "taxAmount", EmitDefaultValue = false)]
        public Currency TaxAmount { get; set; }

        /// <summary>
        /// The total monetary amount paid.
        /// </summary>
        /// <value>The total monetary amount paid.</value>
        [DataMember(Name = "totalAmount", EmitDefaultValue = false)]
        public Currency TotalAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SellerDealPaymentEvent {\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  DealId: ").Append(DealId).Append("\n");
            sb.Append("  DealDescription: ").Append(DealDescription).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  FeeType: ").Append(FeeType).Append("\n");
            sb.Append("  FeeAmount: ").Append(FeeAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
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
            return this.Equals(input as SellerDealPaymentEvent);
        }

        /// <summary>
        /// Returns true if SellerDealPaymentEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SellerDealPaymentEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SellerDealPaymentEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PostedDate == input.PostedDate ||
                    (this.PostedDate != null &&
                    this.PostedDate.Equals(input.PostedDate))
                ) &&
                (
                    this.DealId == input.DealId ||
                    (this.DealId != null &&
                    this.DealId.Equals(input.DealId))
                ) &&
                (
                    this.DealDescription == input.DealDescription ||
                    (this.DealDescription != null &&
                    this.DealDescription.Equals(input.DealDescription))
                ) &&
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) &&
                (
                    this.FeeType == input.FeeType ||
                    (this.FeeType != null &&
                    this.FeeType.Equals(input.FeeType))
                ) &&
                (
                    this.FeeAmount == input.FeeAmount ||
                    (this.FeeAmount != null &&
                    this.FeeAmount.Equals(input.FeeAmount))
                ) &&
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) &&
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
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
                if (this.PostedDate != null)
                    hashCode = hashCode * 59 + this.PostedDate.GetHashCode();
                if (this.DealId != null)
                    hashCode = hashCode * 59 + this.DealId.GetHashCode();
                if (this.DealDescription != null)
                    hashCode = hashCode * 59 + this.DealDescription.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.FeeType != null)
                    hashCode = hashCode * 59 + this.FeeType.GetHashCode();
                if (this.FeeAmount != null)
                    hashCode = hashCode * 59 + this.FeeAmount.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
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
