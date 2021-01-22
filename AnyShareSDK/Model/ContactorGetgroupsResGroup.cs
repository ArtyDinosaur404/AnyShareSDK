/* 
 * OpenDoc_API-文档访问
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
    /// ContactorGetgroupsResGroup
    /// </summary>
    [DataContract]
    public partial class ContactorGetgroupsResGroup :  IEquatable<ContactorGetgroupsResGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactorGetgroupsResGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactorGetgroupsResGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactorGetgroupsResGroup" /> class.
        /// </summary>
        /// <param name="id">分组id (required).</param>
        /// <param name="groupname">分组名 (required).</param>
        /// <param name="count">分组下联系人个数 (required).</param>
        public ContactorGetgroupsResGroup(string id = default(string), string groupname = default(string), long? count = default(long?))
        {
            this.Id = id;
            this.Groupname = groupname;
            this.Count = count;
        }
        
        /// <summary>
        /// 分组id
        /// </summary>
        /// <value>分组id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// 分组名
        /// </summary>
        /// <value>分组名</value>
        [DataMember(Name="groupname", EmitDefaultValue=false)]
        public string Groupname { get; set; }

        /// <summary>
        /// 分组下联系人个数
        /// </summary>
        /// <value>分组下联系人个数</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactorGetgroupsResGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Groupname: ").Append(Groupname).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as ContactorGetgroupsResGroup);
        }

        /// <summary>
        /// Returns true if ContactorGetgroupsResGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactorGetgroupsResGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactorGetgroupsResGroup input)
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
                    this.Groupname == input.Groupname ||
                    (this.Groupname != null &&
                    this.Groupname.Equals(input.Groupname))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Groupname != null)
                    hashCode = hashCode * 59 + this.Groupname.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
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