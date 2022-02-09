/* 
 * 6.0-OpenDoc_API-文档访问
 *
 * API to access AnyShare    如有任何疑问，可到开发者社区提问：https://developers.aishu.cn  # Authentication  - 调用需要鉴权的API，必须将token放在HTTP header中：\"Authorization: Bearer ACCESS_TOKEN\"  - 对于GET请求，除了将token放在HTTP header中，也可以将token放在URL query string中：\"tokenid=ACCESS_TOKEN\"  
 *
 * The version of the OpenAPI document: 6.0.10
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = AnyShareSDK.Client.OpenAPIDateConverter;

namespace AnyShareSDK.Model
{
    /// <summary>
    /// ConfigGetoemconfigbysectionReq
    /// </summary>
    [DataContract]
    public partial class ConfigGetoemconfigbysectionReq :  IEquatable<ConfigGetoemconfigbysectionReq>, IValidatableObject
    {
        /// <summary>
        /// 语言标签
        /// </summary>
        /// <value>语言标签</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SectionEnum
        {
            /// <summary>
            /// Enum SharewebenUs for value: shareweb_en-us
            /// </summary>
            [EnumMember(Value = "shareweb_en-us")]
            SharewebenUs = 1,

            /// <summary>
            /// Enum SharewebzhCn for value: shareweb_zh-cn
            /// </summary>
            [EnumMember(Value = "shareweb_zh-cn")]
            SharewebzhCn = 2,

            /// <summary>
            /// Enum SharewebzhTw for value: shareweb_zh-tw
            /// </summary>
            [EnumMember(Value = "shareweb_zh-tw")]
            SharewebzhTw = 3,

            /// <summary>
            /// Enum Anyshare for value: anyshare
            /// </summary>
            [EnumMember(Value = "anyshare")]
            Anyshare = 4

        }

        /// <summary>
        /// 语言标签
        /// </summary>
        /// <value>语言标签</value>
        [DataMember(Name="section", EmitDefaultValue=false)]
        public SectionEnum Section { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigGetoemconfigbysectionReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigGetoemconfigbysectionReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigGetoemconfigbysectionReq" /> class.
        /// </summary>
        /// <param name="section">语言标签 (required).</param>
        public ConfigGetoemconfigbysectionReq(SectionEnum section = default(SectionEnum))
        {
            this.Section = section;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigGetoemconfigbysectionReq {\n");
            sb.Append("  Section: ").Append(Section).Append("\n");
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
            return this.Equals(input as ConfigGetoemconfigbysectionReq);
        }

        /// <summary>
        /// Returns true if ConfigGetoemconfigbysectionReq instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigGetoemconfigbysectionReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigGetoemconfigbysectionReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Section == input.Section ||
                    (this.Section != null &&
                    this.Section.Equals(input.Section))
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
                if (this.Section != null)
                    hashCode = hashCode * 59 + this.Section.GetHashCode();
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
