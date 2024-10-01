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
    /// The type of label preparation that is required for the inbound shipment.
    /// </summary>
    /// <value>The type of label preparation that is required for the inbound shipment.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum LabelPrepType
    {

        /// <summary>
        /// Enum NOLABEL for value: NO_LABEL
        /// </summary>
        [EnumMember(Value = "NO_LABEL")]
        NOLABEL = 1,

        /// <summary>
        /// Enum SELLERLABEL for value: SELLER_LABEL
        /// </summary>
        [EnumMember(Value = "SELLER_LABEL")]
        SELLERLABEL = 2,

        /// <summary>
        /// Enum AMAZONLABEL for value: AMAZON_LABEL
        /// </summary>
        [EnumMember(Value = "AMAZON_LABEL")]
        AMAZONLABEL = 3
    }

}