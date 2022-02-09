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
    /// DirGetsuggestnameRes
    /// </summary>
    [DataContract]
    public partial class DirGetsuggestnameRes :  IEquatable<DirGetsuggestnameRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirGetsuggestnameRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DirGetsuggestnameRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DirGetsuggestnameRes" /> class.
        /// </summary>
        /// <param name="name">UTF8编码，服务端如果不存在同名的name，则直接返回name；如果存在同名的name，则根据重名冲突策略找到不冲突的文件名 (required).</param>
        public DirGetsuggestnameRes(string name = default(string))
        {
            this.Name = name;
        }
        
        /// <summary>
        /// UTF8编码，服务端如果不存在同名的name，则直接返回name；如果存在同名的name，则根据重名冲突策略找到不冲突的文件名
        /// </summary>
        /// <value>UTF8编码，服务端如果不存在同名的name，则直接返回name；如果存在同名的name，则根据重名冲突策略找到不冲突的文件名</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirGetsuggestnameRes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as DirGetsuggestnameRes);
        }

        /// <summary>
        /// Returns true if DirGetsuggestnameRes instances are equal
        /// </summary>
        /// <param name="input">Instance of DirGetsuggestnameRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirGetsuggestnameRes input)
        {
            if (input == null)
                return false;

            return 
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
            yield break;
        }
    }

}
