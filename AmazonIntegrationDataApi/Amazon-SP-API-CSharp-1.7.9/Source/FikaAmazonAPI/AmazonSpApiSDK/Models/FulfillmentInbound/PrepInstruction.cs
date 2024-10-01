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
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Preparation instructions for shipping an item to Amazon&#39;s fulfillment network. For more information about preparing items for shipment to Amazon&#39;s fulfillment network, see the Seller Central Help for your marketplace.
    /// </summary>
    /// <value>Preparation instructions for shipping an item to Amazon&#39;s fulfillment network. For more information about preparing items for shipment to Amazon&#39;s fulfillment network, see the Seller Central Help for your marketplace.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum PrepInstruction
    {

        /// <summary>
        /// Enum Polybagging for value: Polybagging
        /// </summary>
        [EnumMember(Value = "Polybagging")]
        Polybagging = 1,

        /// <summary>
        /// Enum BubbleWrapping for value: BubbleWrapping
        /// </summary>
        [EnumMember(Value = "BubbleWrapping")]
        BubbleWrapping = 2,

        /// <summary>
        /// Enum Taping for value: Taping
        /// </summary>
        [EnumMember(Value = "Taping")]
        Taping = 3,

        /// <summary>
        /// Enum BlackShrinkWrapping for value: BlackShrinkWrapping
        /// </summary>
        [EnumMember(Value = "BlackShrinkWrapping")]
        BlackShrinkWrapping = 4,

        /// <summary>
        /// Enum Labeling for value: Labeling
        /// </summary>
        [EnumMember(Value = "Labeling")]
        Labeling = 5,

        /// <summary>
        /// Enum HangGarment for value: HangGarment
        /// </summary>
        [EnumMember(Value = "HangGarment")]
        HangGarment = 6,

        /// <summary>
        /// Enum SetCreation for value: SetCreation
        /// </summary>
        [EnumMember(Value = "SetCreation")]
        SetCreation = 7,

        /// <summary>
        /// Enum Boxing for value: Boxing
        /// </summary>
        [EnumMember(Value = "Boxing")]
        Boxing = 8,

        /// <summary>
        /// Enum RemoveFromHanger for value: RemoveFromHanger
        /// </summary>
        [EnumMember(Value = "RemoveFromHanger")]
        RemoveFromHanger = 9,

        /// <summary>
        /// Enum Debundle for value: Debundle
        /// </summary>
        [EnumMember(Value = "Debundle")]
        Debundle = 10,

        /// <summary>
        /// Enum SuffocationStickering for value: SuffocationStickering
        /// </summary>
        [EnumMember(Value = "SuffocationStickering")]
        SuffocationStickering = 11,

        /// <summary>
        /// Enum CapSealing for value: CapSealing
        /// </summary>
        [EnumMember(Value = "CapSealing")]
        CapSealing = 12,

        /// <summary>
        /// Enum SetStickering for value: SetStickering
        /// </summary>
        [EnumMember(Value = "SetStickering")]
        SetStickering = 13,

        /// <summary>
        /// Enum BlankStickering for value: BlankStickering
        /// </summary>
        [EnumMember(Value = "BlankStickering")]
        BlankStickering = 14,

        /// <summary>
        /// Enum NoPrep for value: NoPrep
        /// </summary>
        [EnumMember(Value = "NoPrep")]
        NoPrep = 15
    }

}