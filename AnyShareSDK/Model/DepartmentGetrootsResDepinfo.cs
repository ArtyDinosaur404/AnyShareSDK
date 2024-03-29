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
    /// DepartmentGetrootsResDepinfo
    /// </summary>
    [DataContract]
    public partial class DepartmentGetrootsResDepinfo :  IEquatable<DepartmentGetrootsResDepinfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentGetrootsResDepinfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepartmentGetrootsResDepinfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentGetrootsResDepinfo" /> class.
        /// </summary>
        /// <param name="depid">部门唯一标识 (required).</param>
        /// <param name="name">部门显示名 (required).</param>
        /// <param name="isconfigable">是否可配置权限 (required).</param>
        public DepartmentGetrootsResDepinfo(string depid = default(string), string name = default(string), bool? isconfigable = default(bool?))
        {
            this.Depid = depid;
            this.Name = name;
            this.Isconfigable = isconfigable;
        }
        
        /// <summary>
        /// 部门唯一标识
        /// </summary>
        /// <value>部门唯一标识</value>
        [DataMember(Name="depid", EmitDefaultValue=false)]
        public string Depid { get; set; }

        /// <summary>
        /// 部门显示名
        /// </summary>
        /// <value>部门显示名</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 是否可配置权限
        /// </summary>
        /// <value>是否可配置权限</value>
        [DataMember(Name="isconfigable", EmitDefaultValue=false)]
        public bool? Isconfigable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepartmentGetrootsResDepinfo {\n");
            sb.Append("  Depid: ").Append(Depid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Isconfigable: ").Append(Isconfigable).Append("\n");
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
            return this.Equals(input as DepartmentGetrootsResDepinfo);
        }

        /// <summary>
        /// Returns true if DepartmentGetrootsResDepinfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DepartmentGetrootsResDepinfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepartmentGetrootsResDepinfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Depid == input.Depid ||
                    (this.Depid != null &&
                    this.Depid.Equals(input.Depid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Isconfigable == input.Isconfigable ||
                    (this.Isconfigable != null &&
                    this.Isconfigable.Equals(input.Isconfigable))
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
                if (this.Depid != null)
                    hashCode = hashCode * 59 + this.Depid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Isconfigable != null)
                    hashCode = hashCode * 59 + this.Isconfigable.GetHashCode();
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
