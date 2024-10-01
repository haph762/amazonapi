/* 
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Services
{
    /// <summary>
    /// A technician who is assigned to perform the service job in part or in full.
    /// </summary>
    [DataContract]
    public partial class Technician : IEquatable<Technician>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Technician" /> class.
        /// </summary>
        /// <param name="TechnicianId">The technician identifier..</param>
        /// <param name="Name">The name of the technician..</param>
        public Technician(string TechnicianId = default(string), string Name = default(string))
        {
            this.TechnicianId = TechnicianId;
            this.Name = Name;
        }

        /// <summary>
        /// The technician identifier.
        /// </summary>
        /// <value>The technician identifier.</value>
        [DataMember(Name = "technicianId", EmitDefaultValue = false)]
        public string TechnicianId { get; set; }

        /// <summary>
        /// The name of the technician.
        /// </summary>
        /// <value>The name of the technician.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Technician {\n");
            sb.Append("  TechnicianId: ").Append(TechnicianId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Technician);
        }

        /// <summary>
        /// Returns true if Technician instances are equal
        /// </summary>
        /// <param name="input">Instance of Technician to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Technician input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TechnicianId == input.TechnicianId ||
                    (this.TechnicianId != null &&
                    this.TechnicianId.Equals(input.TechnicianId))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.TechnicianId != null)
                    hashCode = hashCode * 59 + this.TechnicianId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
            // TechnicianId (string) maxLength
            if (this.TechnicianId != null && this.TechnicianId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TechnicianId, length must be less than 50.", new[] { "TechnicianId" });
            }

            // TechnicianId (string) minLength
            if (this.TechnicianId != null && this.TechnicianId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TechnicianId, length must be greater than 1.", new[] { "TechnicianId" });
            }

            yield break;
        }
    }

}
