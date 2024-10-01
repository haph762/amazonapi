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
    /// Item information for an inbound shipment. Submitted with a call to the createInboundShipment or updateInboundShipment operation.
    /// </summary>
    [DataContract]
    public partial class InboundShipmentItem : IEquatable<InboundShipmentItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundShipmentItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InboundShipmentItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundShipmentItem" /> class.
        /// </summary>
        /// <param name="shipmentId">A shipment identifier originally returned by the createInboundShipmentPlan operation..</param>
        /// <param name="sellerSKU">The seller SKU of the item. (required).</param>
        /// <param name="fulfillmentNetworkSKU">Amazon&#39;s fulfillment network SKU of the item..</param>
        /// <param name="quantityShipped">The item quantity that you are shipping. (required).</param>
        /// <param name="quantityReceived">The item quantity that has been received at an Amazon fulfillment center..</param>
        /// <param name="quantityInCase">The item quantity in each case, for case-packed items. Note that QuantityInCase multiplied by the number of boxes in the inbound shipment equals QuantityShipped. Also note that all of the boxes of an inbound shipment must either be case packed or individually packed. For that reason, when you submit the createInboundShipment or the updateInboundShipment operation, the value of QuantityInCase must be provided for every item in the shipment or for none of the items in the shipment..</param>
        /// <param name="releaseDate">The date that a pre-order item will be available for sale..</param>
        /// <param name="prepDetailsList">prepDetailsList.</param>
        public InboundShipmentItem(string shipmentId = default(string), string sellerSKU = default(string), string fulfillmentNetworkSKU = default(string), int? quantityShipped = default(int?), int? quantityReceived = default(int?), int? quantityInCase = default(int?), DateTime? releaseDate = default(DateTime?), PrepDetailsList prepDetailsList = default(PrepDetailsList))
        {
            // to ensure "sellerSKU" is required (not null)
            if (sellerSKU == null)
            {
                throw new InvalidDataException("sellerSKU is a required property for InboundShipmentItem and cannot be null");
            }
            else
            {
                this.SellerSKU = sellerSKU;
            }
            // to ensure "quantityShipped" is required (not null)
            if (quantityShipped == null)
            {
                throw new InvalidDataException("quantityShipped is a required property for InboundShipmentItem and cannot be null");
            }
            else
            {
                this.QuantityShipped = quantityShipped;
            }
            this.ShipmentId = shipmentId;
            this.FulfillmentNetworkSKU = fulfillmentNetworkSKU;
            this.QuantityReceived = quantityReceived;
            this.QuantityInCase = quantityInCase;
            this.ReleaseDate = releaseDate;
            this.PrepDetailsList = prepDetailsList;
        }

        /// <summary>
        /// A shipment identifier originally returned by the createInboundShipmentPlan operation.
        /// </summary>
        /// <value>A shipment identifier originally returned by the createInboundShipmentPlan operation.</value>
        [DataMember(Name = "ShipmentId", EmitDefaultValue = false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// The seller SKU of the item.
        /// </summary>
        /// <value>The seller SKU of the item.</value>
        [DataMember(Name = "SellerSKU", EmitDefaultValue = false)]
        public string SellerSKU { get; set; }

        /// <summary>
        /// Amazon&#39;s fulfillment network SKU of the item.
        /// </summary>
        /// <value>Amazon&#39;s fulfillment network SKU of the item.</value>
        [DataMember(Name = "FulfillmentNetworkSKU", EmitDefaultValue = false)]
        public string FulfillmentNetworkSKU { get; set; }

        /// <summary>
        /// The item quantity that you are shipping.
        /// </summary>
        /// <value>The item quantity that you are shipping.</value>
        [DataMember(Name = "QuantityShipped", EmitDefaultValue = false)]
        public int? QuantityShipped { get; set; }

        /// <summary>
        /// The item quantity that has been received at an Amazon fulfillment center.
        /// </summary>
        /// <value>The item quantity that has been received at an Amazon fulfillment center.</value>
        [DataMember(Name = "QuantityReceived", EmitDefaultValue = false)]
        public int? QuantityReceived { get; set; }

        /// <summary>
        /// The item quantity in each case, for case-packed items. Note that QuantityInCase multiplied by the number of boxes in the inbound shipment equals QuantityShipped. Also note that all of the boxes of an inbound shipment must either be case packed or individually packed. For that reason, when you submit the createInboundShipment or the updateInboundShipment operation, the value of QuantityInCase must be provided for every item in the shipment or for none of the items in the shipment.
        /// </summary>
        /// <value>The item quantity in each case, for case-packed items. Note that QuantityInCase multiplied by the number of boxes in the inbound shipment equals QuantityShipped. Also note that all of the boxes of an inbound shipment must either be case packed or individually packed. For that reason, when you submit the createInboundShipment or the updateInboundShipment operation, the value of QuantityInCase must be provided for every item in the shipment or for none of the items in the shipment.</value>
        [DataMember(Name = "QuantityInCase", EmitDefaultValue = false)]
        public int? QuantityInCase { get; set; }

        /// <summary>
        /// The date that a pre-order item will be available for sale.
        /// </summary>
        /// <value>The date that a pre-order item will be available for sale.</value>
        [DataMember(Name = "ReleaseDate", EmitDefaultValue = false)]
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Gets or Sets PrepDetailsList
        /// </summary>
        [DataMember(Name = "PrepDetailsList", EmitDefaultValue = false)]
        public PrepDetailsList PrepDetailsList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundShipmentItem {\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  SellerSKU: ").Append(SellerSKU).Append("\n");
            sb.Append("  FulfillmentNetworkSKU: ").Append(FulfillmentNetworkSKU).Append("\n");
            sb.Append("  QuantityShipped: ").Append(QuantityShipped).Append("\n");
            sb.Append("  QuantityReceived: ").Append(QuantityReceived).Append("\n");
            sb.Append("  QuantityInCase: ").Append(QuantityInCase).Append("\n");
            sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
            sb.Append("  PrepDetailsList: ").Append(PrepDetailsList).Append("\n");
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
            return this.Equals(input as InboundShipmentItem);
        }

        /// <summary>
        /// Returns true if InboundShipmentItem instances are equal
        /// </summary>
        /// <param name="input">Instance of InboundShipmentItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundShipmentItem input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ShipmentId == input.ShipmentId ||
                    (this.ShipmentId != null &&
                    this.ShipmentId.Equals(input.ShipmentId))
                ) &&
                (
                    this.SellerSKU == input.SellerSKU ||
                    (this.SellerSKU != null &&
                    this.SellerSKU.Equals(input.SellerSKU))
                ) &&
                (
                    this.FulfillmentNetworkSKU == input.FulfillmentNetworkSKU ||
                    (this.FulfillmentNetworkSKU != null &&
                    this.FulfillmentNetworkSKU.Equals(input.FulfillmentNetworkSKU))
                ) &&
                (
                    this.QuantityShipped == input.QuantityShipped ||
                    (this.QuantityShipped != null &&
                    this.QuantityShipped.Equals(input.QuantityShipped))
                ) &&
                (
                    this.QuantityReceived == input.QuantityReceived ||
                    (this.QuantityReceived != null &&
                    this.QuantityReceived.Equals(input.QuantityReceived))
                ) &&
                (
                    this.QuantityInCase == input.QuantityInCase ||
                    (this.QuantityInCase != null &&
                    this.QuantityInCase.Equals(input.QuantityInCase))
                ) &&
                (
                    this.ReleaseDate == input.ReleaseDate ||
                    (this.ReleaseDate != null &&
                    this.ReleaseDate.Equals(input.ReleaseDate))
                ) &&
                (
                    this.PrepDetailsList == input.PrepDetailsList ||
                    (this.PrepDetailsList != null &&
                    this.PrepDetailsList.Equals(input.PrepDetailsList))
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
                if (this.ShipmentId != null)
                    hashCode = hashCode * 59 + this.ShipmentId.GetHashCode();
                if (this.SellerSKU != null)
                    hashCode = hashCode * 59 + this.SellerSKU.GetHashCode();
                if (this.FulfillmentNetworkSKU != null)
                    hashCode = hashCode * 59 + this.FulfillmentNetworkSKU.GetHashCode();
                if (this.QuantityShipped != null)
                    hashCode = hashCode * 59 + this.QuantityShipped.GetHashCode();
                if (this.QuantityReceived != null)
                    hashCode = hashCode * 59 + this.QuantityReceived.GetHashCode();
                if (this.QuantityInCase != null)
                    hashCode = hashCode * 59 + this.QuantityInCase.GetHashCode();
                if (this.ReleaseDate != null)
                    hashCode = hashCode * 59 + this.ReleaseDate.GetHashCode();
                if (this.PrepDetailsList != null)
                    hashCode = hashCode * 59 + this.PrepDetailsList.GetHashCode();
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
