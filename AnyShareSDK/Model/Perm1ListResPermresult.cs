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
    /// Perm1ListResPermresult
    /// </summary>
    [DataContract]
    public partial class Perm1ListResPermresult :  IEquatable<Perm1ListResPermresult>, IValidatableObject
    {
        /// <summary>
        /// 访问者类型
        /// </summary>
        /// <value>访问者类型</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessortypeEnum
        {
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 1,

            /// <summary>
            /// Enum Department for value: department
            /// </summary>
            [EnumMember(Value = "department")]
            Department = 2,

            /// <summary>
            /// Enum Contactor for value: contactor
            /// </summary>
            [EnumMember(Value = "contactor")]
            Contactor = 3

        }

        /// <summary>
        /// 访问者类型
        /// </summary>
        /// <value>访问者类型</value>
        [DataMember(Name="accessortype", EmitDefaultValue=false)]
        public AccessortypeEnum Accessortype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Perm1ListResPermresult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Perm1ListResPermresult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Perm1ListResPermresult" /> class.
        /// </summary>
        /// <param name="accessorid">访问者id (required).</param>
        /// <param name="accessortype">访问者类型 (required).</param>
        /// <param name="accessorname">访问者的名称 (required).</param>
        /// <param name="allowvalue">允许的权限值 (required).</param>
        /// <param name="denyvalue">拒绝的权限值 (required).</param>
        public Perm1ListResPermresult(string accessorid = default(string), AccessortypeEnum accessortype = default(AccessortypeEnum), string accessorname = default(string), long? allowvalue = default(long?), long? denyvalue = default(long?))
        {
            this.Accessorid = accessorid;
            this.Accessortype = accessortype;
            this.Accessorname = accessorname;
            this.Allowvalue = allowvalue;
            this.Denyvalue = denyvalue;
        }
        
        /// <summary>
        /// 访问者id
        /// </summary>
        /// <value>访问者id</value>
        [DataMember(Name="accessorid", EmitDefaultValue=false)]
        public string Accessorid { get; set; }


        /// <summary>
        /// 访问者的名称
        /// </summary>
        /// <value>访问者的名称</value>
        [DataMember(Name="accessorname", EmitDefaultValue=false)]
        public string Accessorname { get; set; }

        /// <summary>
        /// 允许的权限值
        /// </summary>
        /// <value>允许的权限值</value>
        [DataMember(Name="allowvalue", EmitDefaultValue=false)]
        public long? Allowvalue { get; set; }

        /// <summary>
        /// 拒绝的权限值
        /// </summary>
        /// <value>拒绝的权限值</value>
        [DataMember(Name="denyvalue", EmitDefaultValue=false)]
        public long? Denyvalue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Perm1ListResPermresult {\n");
            sb.Append("  Accessorid: ").Append(Accessorid).Append("\n");
            sb.Append("  Accessortype: ").Append(Accessortype).Append("\n");
            sb.Append("  Accessorname: ").Append(Accessorname).Append("\n");
            sb.Append("  Allowvalue: ").Append(Allowvalue).Append("\n");
            sb.Append("  Denyvalue: ").Append(Denyvalue).Append("\n");
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
            return this.Equals(input as Perm1ListResPermresult);
        }

        /// <summary>
        /// Returns true if Perm1ListResPermresult instances are equal
        /// </summary>
        /// <param name="input">Instance of Perm1ListResPermresult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Perm1ListResPermresult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Accessorid == input.Accessorid ||
                    (this.Accessorid != null &&
                    this.Accessorid.Equals(input.Accessorid))
                ) && 
                (
                    this.Accessortype == input.Accessortype ||
                    (this.Accessortype != null &&
                    this.Accessortype.Equals(input.Accessortype))
                ) && 
                (
                    this.Accessorname == input.Accessorname ||
                    (this.Accessorname != null &&
                    this.Accessorname.Equals(input.Accessorname))
                ) && 
                (
                    this.Allowvalue == input.Allowvalue ||
                    (this.Allowvalue != null &&
                    this.Allowvalue.Equals(input.Allowvalue))
                ) && 
                (
                    this.Denyvalue == input.Denyvalue ||
                    (this.Denyvalue != null &&
                    this.Denyvalue.Equals(input.Denyvalue))
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
                if (this.Accessorid != null)
                    hashCode = hashCode * 59 + this.Accessorid.GetHashCode();
                if (this.Accessortype != null)
                    hashCode = hashCode * 59 + this.Accessortype.GetHashCode();
                if (this.Accessorname != null)
                    hashCode = hashCode * 59 + this.Accessorname.GetHashCode();
                if (this.Allowvalue != null)
                    hashCode = hashCode * 59 + this.Allowvalue.GetHashCode();
                if (this.Denyvalue != null)
                    hashCode = hashCode * 59 + this.Denyvalue.GetHashCode();
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
