/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// GetFulfillmentPreviewRequest
    /// </summary>
    [DataContract]
    public partial class GetFulfillmentPreviewRequest : IEquatable<GetFulfillmentPreviewRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFulfillmentPreviewRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public GetFulfillmentPreviewRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFulfillmentPreviewRequest" /> class.
        /// </summary>
        /// <param name="MarketplaceId">The marketplace the fulfillment order is placed against..</param>
        /// <param name="Address">The destination address for the fulfillment order preview. (required).</param>
        /// <param name="Items">Identifying information and quantity information for the items in the fulfillment order preview. (required).</param>
        /// <param name="ShippingSpeedCategories">A list of shipping methods used for creating fulfillment order previews. Note: Shipping method service level agreements vary by marketplace. Sellers should see the Seller Central website in their marketplace for shipping method service level agreements and fulfillment fees..</param>
        /// <param name="IncludeCODFulfillmentPreview">Specifies whether to return fulfillment order previews that are for COD (Cash On Delivery).  Possible values:  true - Returns all fulfillment order previews (both for COD and not for COD).  false - Returns only fulfillment order previews that are not for COD..</param>
        /// <param name="IncludeDeliveryWindows">Specifies whether to return the ScheduledDeliveryInfo response object, which contains the available delivery windows for a Scheduled Delivery. The ScheduledDeliveryInfo response object can only be returned for fulfillment order previews with ShippingSpeedCategories &#x3D; ScheduledDelivery..</param>
        public GetFulfillmentPreviewRequest(string MarketplaceId = default(string), Address Address = default(Address), GetFulfillmentPreviewItemList Items = default(GetFulfillmentPreviewItemList), ShippingSpeedCategoryList ShippingSpeedCategories = default(ShippingSpeedCategoryList), bool? IncludeCODFulfillmentPreview = default(bool?), bool? IncludeDeliveryWindows = default(bool?))
        {
            // to ensure "Address" is required (not null)
            if (Address == null)
            {
                throw new InvalidDataException("Address is a required property for GetFulfillmentPreviewRequest and cannot be null");
            }
            else
            {
                this.Address = Address;
            }
            // to ensure "Items" is required (not null)
            if (Items == null)
            {
                throw new InvalidDataException("Items is a required property for GetFulfillmentPreviewRequest and cannot be null");
            }
            else
            {
                this.Items = Items;
            }
            this.MarketplaceId = MarketplaceId;
            this.ShippingSpeedCategories = ShippingSpeedCategories;
            this.IncludeCODFulfillmentPreview = IncludeCODFulfillmentPreview;
            this.IncludeDeliveryWindows = IncludeDeliveryWindows;
        }

        /// <summary>
        /// The marketplace the fulfillment order is placed against.
        /// </summary>
        /// <value>The marketplace the fulfillment order is placed against.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The destination address for the fulfillment order preview.
        /// </summary>
        /// <value>The destination address for the fulfillment order preview.</value>
        [DataMember(Name = "Address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// Identifying information and quantity information for the items in the fulfillment order preview.
        /// </summary>
        /// <value>Identifying information and quantity information for the items in the fulfillment order preview.</value>
        [DataMember(Name = "Items", EmitDefaultValue = false)]
        public GetFulfillmentPreviewItemList Items { get; set; }

        /// <summary>
        /// A list of shipping methods used for creating fulfillment order previews. Note: Shipping method service level agreements vary by marketplace. Sellers should see the Seller Central website in their marketplace for shipping method service level agreements and fulfillment fees.
        /// </summary>
        /// <value>A list of shipping methods used for creating fulfillment order previews. Note: Shipping method service level agreements vary by marketplace. Sellers should see the Seller Central website in their marketplace for shipping method service level agreements and fulfillment fees.</value>
        [DataMember(Name = "ShippingSpeedCategories", EmitDefaultValue = false)]
        public ShippingSpeedCategoryList ShippingSpeedCategories { get; set; }

        /// <summary>
        /// Specifies whether to return fulfillment order previews that are for COD (Cash On Delivery).  Possible values:  true - Returns all fulfillment order previews (both for COD and not for COD).  false - Returns only fulfillment order previews that are not for COD.
        /// </summary>
        /// <value>Specifies whether to return fulfillment order previews that are for COD (Cash On Delivery).  Possible values:  true - Returns all fulfillment order previews (both for COD and not for COD).  false - Returns only fulfillment order previews that are not for COD.</value>
        [DataMember(Name = "IncludeCODFulfillmentPreview", EmitDefaultValue = false)]
        public bool? IncludeCODFulfillmentPreview { get; set; }

        /// <summary>
        /// Specifies whether to return the ScheduledDeliveryInfo response object, which contains the available delivery windows for a Scheduled Delivery. The ScheduledDeliveryInfo response object can only be returned for fulfillment order previews with ShippingSpeedCategories &#x3D; ScheduledDelivery.
        /// </summary>
        /// <value>Specifies whether to return the ScheduledDeliveryInfo response object, which contains the available delivery windows for a Scheduled Delivery. The ScheduledDeliveryInfo response object can only be returned for fulfillment order previews with ShippingSpeedCategories &#x3D; ScheduledDelivery.</value>
        [DataMember(Name = "IncludeDeliveryWindows", EmitDefaultValue = false)]
        public bool? IncludeDeliveryWindows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFulfillmentPreviewRequest {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  ShippingSpeedCategories: ").Append(ShippingSpeedCategories).Append("\n");
            sb.Append("  IncludeCODFulfillmentPreview: ").Append(IncludeCODFulfillmentPreview).Append("\n");
            sb.Append("  IncludeDeliveryWindows: ").Append(IncludeDeliveryWindows).Append("\n");
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
            return this.Equals(input as GetFulfillmentPreviewRequest);
        }

        /// <summary>
        /// Returns true if GetFulfillmentPreviewRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFulfillmentPreviewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFulfillmentPreviewRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) &&
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
                ) &&
                (
                    this.ShippingSpeedCategories == input.ShippingSpeedCategories ||
                    (this.ShippingSpeedCategories != null &&
                    this.ShippingSpeedCategories.Equals(input.ShippingSpeedCategories))
                ) &&
                (
                    this.IncludeCODFulfillmentPreview == input.IncludeCODFulfillmentPreview ||
                    (this.IncludeCODFulfillmentPreview != null &&
                    this.IncludeCODFulfillmentPreview.Equals(input.IncludeCODFulfillmentPreview))
                ) &&
                (
                    this.IncludeDeliveryWindows == input.IncludeDeliveryWindows ||
                    (this.IncludeDeliveryWindows != null &&
                    this.IncludeDeliveryWindows.Equals(input.IncludeDeliveryWindows))
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
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.ShippingSpeedCategories != null)
                    hashCode = hashCode * 59 + this.ShippingSpeedCategories.GetHashCode();
                if (this.IncludeCODFulfillmentPreview != null)
                    hashCode = hashCode * 59 + this.IncludeCODFulfillmentPreview.GetHashCode();
                if (this.IncludeDeliveryWindows != null)
                    hashCode = hashCode * 59 + this.IncludeDeliveryWindows.GetHashCode();
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
