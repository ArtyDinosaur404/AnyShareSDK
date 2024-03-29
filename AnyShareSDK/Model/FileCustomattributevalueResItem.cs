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
    /// FileCustomattributevalueResItem
    /// </summary>
    [DataContract]
    public partial class FileCustomattributevalueResItem :  IEquatable<FileCustomattributevalueResItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileCustomattributevalueResItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileCustomattributevalueResItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileCustomattributevalueResItem" /> class.
        /// </summary>
        /// <param name="id">属性值ID (required).</param>
        /// <param name="name">属性值名称 (required).</param>
        /// <param name="level">属性值层级 (required).</param>
        /// <param name="child">属性值子属性：包括以上三个字段的数组.</param>
        public FileCustomattributevalueResItem(long? id = default(long?), string name = default(string), long? level = default(long?), List<FileCustomattributevalueResItem> child = default(List<FileCustomattributevalueResItem>))
        {
            this.Id = id;
            this.Name = name;
            this.Level = level;
            this.Child = child;
        }
        
        /// <summary>
        /// 属性值ID
        /// </summary>
        /// <value>属性值ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// 属性值名称
        /// </summary>
        /// <value>属性值名称</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 属性值层级
        /// </summary>
        /// <value>属性值层级</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public long? Level { get; set; }

        /// <summary>
        /// 属性值子属性：包括以上三个字段的数组
        /// </summary>
        /// <value>属性值子属性：包括以上三个字段的数组</value>
        [DataMember(Name="child", EmitDefaultValue=false)]
        public List<FileCustomattributevalueResItem> Child { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileCustomattributevalueResItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Child: ").Append(Child).Append("\n");
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
            return this.Equals(input as FileCustomattributevalueResItem);
        }

        /// <summary>
        /// Returns true if FileCustomattributevalueResItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FileCustomattributevalueResItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileCustomattributevalueResItem input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Child == input.Child ||
                    this.Child != null &&
                    input.Child != null &&
                    this.Child.SequenceEqual(input.Child)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Child != null)
                    hashCode = hashCode * 59 + this.Child.GetHashCode();
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
