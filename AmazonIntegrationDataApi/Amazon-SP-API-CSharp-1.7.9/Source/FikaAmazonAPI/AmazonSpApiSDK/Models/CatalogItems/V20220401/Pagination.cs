/* 
 * Selling Partner API for Catalog Items
 *
 * The Selling Partner API for Catalog Items provides programmatic access to information about items in the Amazon catalog.  For more information, refer to the [Catalog Items API Use Case Guide](doc:catalog-items-api-v2022-04-01-use-case-guide).
 *
 * OpenAPI spec version: 2022-04-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.CatalogItems.V20220401
{
    /// <summary>
    /// When a request produces a response that exceeds the &#x60;pageSize&#x60;, pagination occurs. This means the response is divided into individual pages. To retrieve the next page or the previous page, you must pass the &#x60;nextToken&#x60; value or the &#x60;previousToken&#x60; value as the &#x60;pageToken&#x60; parameter in the next request. When you receive the last page, there will be no &#x60;nextToken&#x60; key in the pagination object.
    /// </summary>
    [DataContract]
    public partial class Pagination : IEquatable<Pagination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        /// <param name="nextToken">A token that can be used to fetch the next page..</param>
        /// <param name="previousToken">A token that can be used to fetch the previous page..</param>
        public Pagination(string nextToken = default(string), string previousToken = default(string))
        {
            this.NextToken = nextToken;
            this.PreviousToken = previousToken;
        }

        /// <summary>
        /// A token that can be used to fetch the next page.
        /// </summary>
        /// <value>A token that can be used to fetch the next page.</value>
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// A token that can be used to fetch the previous page.
        /// </summary>
        /// <value>A token that can be used to fetch the previous page.</value>
        [DataMember(Name = "previousToken", EmitDefaultValue = false)]
        public string PreviousToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pagination {\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  PreviousToken: ").Append(PreviousToken).Append("\n");
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
            return this.Equals(input as Pagination);
        }

        /// <summary>
        /// Returns true if Pagination instances are equal
        /// </summary>
        /// <param name="input">Instance of Pagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pagination input)
        {
            if (input == null)
                return false;

            return
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
                ) &&
                (
                    this.PreviousToken == input.PreviousToken ||
                    (this.PreviousToken != null &&
                    this.PreviousToken.Equals(input.PreviousToken))
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
                if (this.NextToken != null)
                    hashCode = hashCode * 59 + this.NextToken.GetHashCode();
                if (this.PreviousToken != null)
                    hashCode = hashCode * 59 + this.PreviousToken.GetHashCode();
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
