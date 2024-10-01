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
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.CatalogItems.V20220401
{
    /// <summary>
    /// Search refinements.
    /// </summary>
    [DataContract]
    public partial class Refinements : IEquatable<Refinements>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Refinements" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Refinements() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Refinements" /> class.
        /// </summary>
        /// <param name="brands">Brand search refinements. (required).</param>
        /// <param name="classifications">Classification search refinements. (required).</param>
        public Refinements(List<BrandRefinement> brands = default(List<BrandRefinement>), List<ClassificationRefinement> classifications = default(List<ClassificationRefinement>))
        {
            // to ensure "brands" is required (not null)
            if (brands == null)
            {
                throw new InvalidDataException("brands is a required property for Refinements and cannot be null");
            }
            else
            {
                this.Brands = brands;
            }
            // to ensure "classifications" is required (not null)
            if (classifications == null)
            {
                throw new InvalidDataException("classifications is a required property for Refinements and cannot be null");
            }
            else
            {
                this.Classifications = classifications;
            }
        }

        /// <summary>
        /// Brand search refinements.
        /// </summary>
        /// <value>Brand search refinements.</value>
        [DataMember(Name = "brands", EmitDefaultValue = false)]
        public List<BrandRefinement> Brands { get; set; }

        /// <summary>
        /// Classification search refinements.
        /// </summary>
        /// <value>Classification search refinements.</value>
        [DataMember(Name = "classifications", EmitDefaultValue = false)]
        public List<ClassificationRefinement> Classifications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Refinements {\n");
            sb.Append("  Brands: ").Append(Brands).Append("\n");
            sb.Append("  Classifications: ").Append(Classifications).Append("\n");
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
            return this.Equals(input as Refinements);
        }

        /// <summary>
        /// Returns true if Refinements instances are equal
        /// </summary>
        /// <param name="input">Instance of Refinements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Refinements input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Brands == input.Brands ||
                    this.Brands != null &&
                    this.Brands.SequenceEqual(input.Brands)
                ) &&
                (
                    this.Classifications == input.Classifications ||
                    this.Classifications != null &&
                    this.Classifications.SequenceEqual(input.Classifications)
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
                if (this.Brands != null)
                    hashCode = hashCode * 59 + this.Brands.GetHashCode();
                if (this.Classifications != null)
                    hashCode = hashCode * 59 + this.Classifications.GetHashCode();
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
