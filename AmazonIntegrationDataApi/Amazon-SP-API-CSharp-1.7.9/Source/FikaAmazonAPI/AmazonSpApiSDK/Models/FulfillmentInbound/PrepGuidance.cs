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
    /// Item preparation instructions.
    /// </summary>
    /// <value>Item preparation instructions.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum PrepGuidance
    {

        /// <summary>
        /// Enum ConsultHelpDocuments for value: ConsultHelpDocuments
        /// </summary>
        [EnumMember(Value = "ConsultHelpDocuments")]
        ConsultHelpDocuments = 1,

        /// <summary>
        /// Enum NoAdditionalPrepRequired for value: NoAdditionalPrepRequired
        /// </summary>
        [EnumMember(Value = "NoAdditionalPrepRequired")]
        NoAdditionalPrepRequired = 2,

        /// <summary>
        /// Enum SeePrepInstructionsList for value: SeePrepInstructionsList
        /// </summary>
        [EnumMember(Value = "SeePrepInstructionsList")]
        SeePrepInstructionsList = 3
    }

}