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
    /// A network commingling transaction event.
    /// </summary>
    [DataContract]
    public partial class NetworkComminglingTransactionEvent : IEquatable<NetworkComminglingTransactionEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkComminglingTransactionEvent" /> class.
        /// </summary>
        /// <param name="TransactionType">The type of network item swap.  Possible values:  * NetCo - A Fulfillment by Amazon inventory pooling transaction. Available only in the India marketplace.  * ComminglingVAT - A commingling VAT transaction. Available only in the UK, Spain, France, Germany, and Italy marketplaces..</param>
        /// <param name="PostedDate">The date and time when the financial event was posted..</param>
        /// <param name="NetCoTransactionID">The identifier for the network item swap..</param>
        /// <param name="SwapReason">The reason for the network item swap..</param>
        /// <param name="ASIN">The Amazon Standard Identification Number (ASIN) of the swapped item..</param>
        /// <param name="MarketplaceId">The marketplace in which the event took place..</param>
        /// <param name="TaxExclusiveAmount">The price of the swapped item minus TaxAmount..</param>
        /// <param name="TaxAmount">The tax on the network item swap paid by the seller..</param>
        public NetworkComminglingTransactionEvent(string TransactionType = default(string), DateTime? PostedDate = default(DateTime?), string NetCoTransactionID = default(string), string SwapReason = default(string), string ASIN = default(string), string MarketplaceId = default(string), Currency TaxExclusiveAmount = default(Currency), Currency TaxAmount = default(Currency))
        {
            this.TransactionType = TransactionType;
            this.PostedDate = PostedDate;
            this.NetCoTransactionID = NetCoTransactionID;
            this.SwapReason = SwapReason;
            this.ASIN = ASIN;
            this.MarketplaceId = MarketplaceId;
            this.TaxExclusiveAmount = TaxExclusiveAmount;
            this.TaxAmount = TaxAmount;
        }

        /// <summary>
        /// The type of network item swap.  Possible values:  * NetCo - A Fulfillment by Amazon inventory pooling transaction. Available only in the India marketplace.  * ComminglingVAT - A commingling VAT transaction. Available only in the UK, Spain, France, Germany, and Italy marketplaces.
        /// </summary>
        /// <value>The type of network item swap.  Possible values:  * NetCo - A Fulfillment by Amazon inventory pooling transaction. Available only in the India marketplace.  * ComminglingVAT - A commingling VAT transaction. Available only in the UK, Spain, France, Germany, and Italy marketplaces.</value>
        [DataMember(Name = "TransactionType", EmitDefaultValue = false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// The date and time when the financial event was posted.
        /// </summary>
        /// <value>The date and time when the financial event was posted.</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// The identifier for the network item swap.
        /// </summary>
        /// <value>The identifier for the network item swap.</value>
        [DataMember(Name = "NetCoTransactionID", EmitDefaultValue = false)]
        public string NetCoTransactionID { get; set; }

        /// <summary>
        /// The reason for the network item swap.
        /// </summary>
        /// <value>The reason for the network item swap.</value>
        [DataMember(Name = "SwapReason", EmitDefaultValue = false)]
        public string SwapReason { get; set; }

        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) of the swapped item.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) of the swapped item.</value>
        [DataMember(Name = "ASIN", EmitDefaultValue = false)]
        public string ASIN { get; set; }

        /// <summary>
        /// The marketplace in which the event took place.
        /// </summary>
        /// <value>The marketplace in which the event took place.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The price of the swapped item minus TaxAmount.
        /// </summary>
        /// <value>The price of the swapped item minus TaxAmount.</value>
        [DataMember(Name = "TaxExclusiveAmount", EmitDefaultValue = false)]
        public Currency TaxExclusiveAmount { get; set; }

        /// <summary>
        /// The tax on the network item swap paid by the seller.
        /// </summary>
        /// <value>The tax on the network item swap paid by the seller.</value>
        [DataMember(Name = "TaxAmount", EmitDefaultValue = false)]
        public Currency TaxAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkComminglingTransactionEvent {\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  NetCoTransactionID: ").Append(NetCoTransactionID).Append("\n");
            sb.Append("  SwapReason: ").Append(SwapReason).Append("\n");
            sb.Append("  ASIN: ").Append(ASIN).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  TaxExclusiveAmount: ").Append(TaxExclusiveAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
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
            return this.Equals(input as NetworkComminglingTransactionEvent);
        }

        /// <summary>
        /// Returns true if NetworkComminglingTransactionEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkComminglingTransactionEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkComminglingTransactionEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) &&
                (
                    this.PostedDate == input.PostedDate ||
                    (this.PostedDate != null &&
                    this.PostedDate.Equals(input.PostedDate))
                ) &&
                (
                    this.NetCoTransactionID == input.NetCoTransactionID ||
                    (this.NetCoTransactionID != null &&
                    this.NetCoTransactionID.Equals(input.NetCoTransactionID))
                ) &&
                (
                    this.SwapReason == input.SwapReason ||
                    (this.SwapReason != null &&
                    this.SwapReason.Equals(input.SwapReason))
                ) &&
                (
                    this.ASIN == input.ASIN ||
                    (this.ASIN != null &&
                    this.ASIN.Equals(input.ASIN))
                ) &&
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    this.TaxExclusiveAmount == input.TaxExclusiveAmount ||
                    (this.TaxExclusiveAmount != null &&
                    this.TaxExclusiveAmount.Equals(input.TaxExclusiveAmount))
                ) &&
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
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
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.PostedDate != null)
                    hashCode = hashCode * 59 + this.PostedDate.GetHashCode();
                if (this.NetCoTransactionID != null)
                    hashCode = hashCode * 59 + this.NetCoTransactionID.GetHashCode();
                if (this.SwapReason != null)
                    hashCode = hashCode * 59 + this.SwapReason.GetHashCode();
                if (this.ASIN != null)
                    hashCode = hashCode * 59 + this.ASIN.GetHashCode();
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.TaxExclusiveAmount != null)
                    hashCode = hashCode * 59 + this.TaxExclusiveAmount.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
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
