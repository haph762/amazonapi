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
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Information that is required by an Amazon-partnered carrier to ship a Less Than Truckload/Full Truckload (LTL/FTL) inbound shipment.
    /// </summary>
    [DataContract]
    public partial class PartneredLtlDataInput : IEquatable<PartneredLtlDataInput>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SellerFreightClass
        /// </summary>
        [DataMember(Name = "SellerFreightClass", EmitDefaultValue = false)]
        public SellerFreightClass? SellerFreightClass { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartneredLtlDataInput" /> class.
        /// </summary>
        /// <param name="contact">Contact information for the person in the seller&#39;s organization who is responsible for the shipment. Used by the carrier if they have questions about the shipment..</param>
        /// <param name="boxCount">The number of boxes in the shipment..</param>
        /// <param name="sellerFreightClass">sellerFreightClass.</param>
        /// <param name="freightReadyDate">The date that the shipment will be ready to be picked up by the carrier..</param>
        /// <param name="palletList">palletList.</param>
        /// <param name="totalWeight">The total weight of the shipment..</param>
        /// <param name="sellerDeclaredValue">The declaration of the total value of the inventory in the shipment..</param>
        public PartneredLtlDataInput(Contact contact = default(Contact), long? boxCount = default(long?), SellerFreightClass? sellerFreightClass = default(SellerFreightClass?), DateTime? freightReadyDate = default(DateTime?), PalletList palletList = default(PalletList), Weight totalWeight = default(Weight), Amount sellerDeclaredValue = default(Amount))
        {
            this.Contact = contact;
            this.BoxCount = boxCount;
            this.SellerFreightClass = sellerFreightClass;
            this.FreightReadyDate = freightReadyDate;
            this.PalletList = palletList;
            this.TotalWeight = totalWeight;
            this.SellerDeclaredValue = sellerDeclaredValue;
        }

        /// <summary>
        /// Contact information for the person in the seller&#39;s organization who is responsible for the shipment. Used by the carrier if they have questions about the shipment.
        /// </summary>
        /// <value>Contact information for the person in the seller&#39;s organization who is responsible for the shipment. Used by the carrier if they have questions about the shipment.</value>
        [DataMember(Name = "Contact", EmitDefaultValue = false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// The number of boxes in the shipment.
        /// </summary>
        /// <value>The number of boxes in the shipment.</value>
        [DataMember(Name = "BoxCount", EmitDefaultValue = false)]
        public long? BoxCount { get; set; }


        /// <summary>
        /// The date that the shipment will be ready to be picked up by the carrier.
        /// </summary>
        /// <value>The date that the shipment will be ready to be picked up by the carrier.</value>
        [DataMember(Name = "FreightReadyDate", EmitDefaultValue = false)]
        public DateTime? FreightReadyDate { get; set; }

        /// <summary>
        /// Gets or Sets PalletList
        /// </summary>
        [DataMember(Name = "PalletList", EmitDefaultValue = false)]
        public PalletList PalletList { get; set; }

        /// <summary>
        /// The total weight of the shipment.
        /// </summary>
        /// <value>The total weight of the shipment.</value>
        [DataMember(Name = "TotalWeight", EmitDefaultValue = false)]
        public Weight TotalWeight { get; set; }

        /// <summary>
        /// The declaration of the total value of the inventory in the shipment.
        /// </summary>
        /// <value>The declaration of the total value of the inventory in the shipment.</value>
        [DataMember(Name = "SellerDeclaredValue", EmitDefaultValue = false)]
        public Amount SellerDeclaredValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartneredLtlDataInput {\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  BoxCount: ").Append(BoxCount).Append("\n");
            sb.Append("  SellerFreightClass: ").Append(SellerFreightClass).Append("\n");
            sb.Append("  FreightReadyDate: ").Append(FreightReadyDate).Append("\n");
            sb.Append("  PalletList: ").Append(PalletList).Append("\n");
            sb.Append("  TotalWeight: ").Append(TotalWeight).Append("\n");
            sb.Append("  SellerDeclaredValue: ").Append(SellerDeclaredValue).Append("\n");
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
            return this.Equals(input as PartneredLtlDataInput);
        }

        /// <summary>
        /// Returns true if PartneredLtlDataInput instances are equal
        /// </summary>
        /// <param name="input">Instance of PartneredLtlDataInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartneredLtlDataInput input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) &&
                (
                    this.BoxCount == input.BoxCount ||
                    (this.BoxCount != null &&
                    this.BoxCount.Equals(input.BoxCount))
                ) &&
                (
                    this.SellerFreightClass == input.SellerFreightClass ||
                    (this.SellerFreightClass != null &&
                    this.SellerFreightClass.Equals(input.SellerFreightClass))
                ) &&
                (
                    this.FreightReadyDate == input.FreightReadyDate ||
                    (this.FreightReadyDate != null &&
                    this.FreightReadyDate.Equals(input.FreightReadyDate))
                ) &&
                (
                    this.PalletList == input.PalletList ||
                    (this.PalletList != null &&
                    this.PalletList.Equals(input.PalletList))
                ) &&
                (
                    this.TotalWeight == input.TotalWeight ||
                    (this.TotalWeight != null &&
                    this.TotalWeight.Equals(input.TotalWeight))
                ) &&
                (
                    this.SellerDeclaredValue == input.SellerDeclaredValue ||
                    (this.SellerDeclaredValue != null &&
                    this.SellerDeclaredValue.Equals(input.SellerDeclaredValue))
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
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.BoxCount != null)
                    hashCode = hashCode * 59 + this.BoxCount.GetHashCode();
                if (this.SellerFreightClass != null)
                    hashCode = hashCode * 59 + this.SellerFreightClass.GetHashCode();
                if (this.FreightReadyDate != null)
                    hashCode = hashCode * 59 + this.FreightReadyDate.GetHashCode();
                if (this.PalletList != null)
                    hashCode = hashCode * 59 + this.PalletList.GetHashCode();
                if (this.TotalWeight != null)
                    hashCode = hashCode * 59 + this.TotalWeight.GetHashCode();
                if (this.SellerDeclaredValue != null)
                    hashCode = hashCode * 59 + this.SellerDeclaredValue.GetHashCode();
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
