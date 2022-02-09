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
    /// FileSetfilecustomattributeReqAttribute
    /// </summary>
    [DataContract]
    public partial class FileSetfilecustomattributeReqAttribute :  IEquatable<FileSetfilecustomattributeReqAttribute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSetfilecustomattributeReqAttribute" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileSetfilecustomattributeReqAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSetfilecustomattributeReqAttribute" /> class.
        /// </summary>
        /// <param name="id">属性ID (required).</param>
        /// <param name="value">属性值string/int/int array    type等于3时value类型为string，0为int array, 其余均为int    注： 时长单位为秒  .</param>
        public FileSetfilecustomattributeReqAttribute(long? id = default(long?), Object value = default(Object))
        {
            this.Id = id;
            this.Value = value;
        }
        
        /// <summary>
        /// 属性ID
        /// </summary>
        /// <value>属性ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// 属性值string/int/int array    type等于3时value类型为string，0为int array, 其余均为int    注： 时长单位为秒  
        /// </summary>
        /// <value>属性值string/int/int array    type等于3时value类型为string，0为int array, 其余均为int    注： 时长单位为秒  </value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileSetfilecustomattributeReqAttribute {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as FileSetfilecustomattributeReqAttribute);
        }

        /// <summary>
        /// Returns true if FileSetfilecustomattributeReqAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of FileSetfilecustomattributeReqAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileSetfilecustomattributeReqAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
