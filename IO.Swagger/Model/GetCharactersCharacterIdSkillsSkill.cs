/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.5.5
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// skill object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdSkillsSkill :  IEquatable<GetCharactersCharacterIdSkillsSkill>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdSkillsSkill" /> class.
        /// </summary>
        /// <param name="CurrentSkillLevel">current_skill_level integer.</param>
        /// <param name="SkillId">skill_id integer.</param>
        /// <param name="SkillpointsInSkill">skillpoints_in_skill integer.</param>
        public GetCharactersCharacterIdSkillsSkill(int? CurrentSkillLevel = default(int?), int? SkillId = default(int?), long? SkillpointsInSkill = default(long?))
        {
            this.CurrentSkillLevel = CurrentSkillLevel;
            this.SkillId = SkillId;
            this.SkillpointsInSkill = SkillpointsInSkill;
        }
        
        /// <summary>
        /// current_skill_level integer
        /// </summary>
        /// <value>current_skill_level integer</value>
        [DataMember(Name="current_skill_level", EmitDefaultValue=false)]
        public int? CurrentSkillLevel { get; set; }

        /// <summary>
        /// skill_id integer
        /// </summary>
        /// <value>skill_id integer</value>
        [DataMember(Name="skill_id", EmitDefaultValue=false)]
        public int? SkillId { get; set; }

        /// <summary>
        /// skillpoints_in_skill integer
        /// </summary>
        /// <value>skillpoints_in_skill integer</value>
        [DataMember(Name="skillpoints_in_skill", EmitDefaultValue=false)]
        public long? SkillpointsInSkill { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdSkillsSkill {\n");
            sb.Append("  CurrentSkillLevel: ").Append(CurrentSkillLevel).Append("\n");
            sb.Append("  SkillId: ").Append(SkillId).Append("\n");
            sb.Append("  SkillpointsInSkill: ").Append(SkillpointsInSkill).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdSkillsSkill);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdSkillsSkill instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdSkillsSkill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdSkillsSkill input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentSkillLevel == input.CurrentSkillLevel ||
                    (this.CurrentSkillLevel != null &&
                    this.CurrentSkillLevel.Equals(input.CurrentSkillLevel))
                ) && 
                (
                    this.SkillId == input.SkillId ||
                    (this.SkillId != null &&
                    this.SkillId.Equals(input.SkillId))
                ) && 
                (
                    this.SkillpointsInSkill == input.SkillpointsInSkill ||
                    (this.SkillpointsInSkill != null &&
                    this.SkillpointsInSkill.Equals(input.SkillpointsInSkill))
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
                if (this.CurrentSkillLevel != null)
                    hashCode = hashCode * 59 + this.CurrentSkillLevel.GetHashCode();
                if (this.SkillId != null)
                    hashCode = hashCode * 59 + this.SkillId.GetHashCode();
                if (this.SkillpointsInSkill != null)
                    hashCode = hashCode * 59 + this.SkillpointsInSkill.GetHashCode();
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
