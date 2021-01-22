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
    /// Entrydoc2GetuserquotaResQuotainfo
    /// </summary>
    [DataContract]
    public partial class Entrydoc2GetuserquotaResQuotainfo :  IEquatable<Entrydoc2GetuserquotaResQuotainfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entrydoc2GetuserquotaResQuotainfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Entrydoc2GetuserquotaResQuotainfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Entrydoc2GetuserquotaResQuotainfo" /> class.
        /// </summary>
        /// <param name="doctype">文档库类型：  1：个人文档库  2：个人群组文档库   (required).</param>
        /// <param name="typename">文档库类型名称 (required).</param>
        /// <param name="docid">文档库id (required).</param>
        /// <param name="name">文档库名称 (required).</param>
        /// <param name="quota">配额 (required).</param>
        /// <param name="used">已用空间 (required).</param>
        public Entrydoc2GetuserquotaResQuotainfo(long? doctype = default(long?), string typename = default(string), string docid = default(string), string name = default(string), long? quota = default(long?), long? used = default(long?))
        {
            this.Doctype = doctype;
            this.Typename = typename;
            this.Docid = docid;
            this.Name = name;
            this.Quota = quota;
            this.Used = used;
        }
        
        /// <summary>
        /// 文档库类型：  1：个人文档库  2：个人群组文档库  
        /// </summary>
        /// <value>文档库类型：  1：个人文档库  2：个人群组文档库  </value>
        [DataMember(Name="doctype", EmitDefaultValue=false)]
        public long? Doctype { get; set; }

        /// <summary>
        /// 文档库类型名称
        /// </summary>
        /// <value>文档库类型名称</value>
        [DataMember(Name="typename", EmitDefaultValue=false)]
        public string Typename { get; set; }

        /// <summary>
        /// 文档库id
        /// </summary>
        /// <value>文档库id</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 文档库名称
        /// </summary>
        /// <value>文档库名称</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 配额
        /// </summary>
        /// <value>配额</value>
        [DataMember(Name="quota", EmitDefaultValue=false)]
        public long? Quota { get; set; }

        /// <summary>
        /// 已用空间
        /// </summary>
        /// <value>已用空间</value>
        [DataMember(Name="used", EmitDefaultValue=false)]
        public long? Used { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entrydoc2GetuserquotaResQuotainfo {\n");
            sb.Append("  Doctype: ").Append(Doctype).Append("\n");
            sb.Append("  Typename: ").Append(Typename).Append("\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
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
            return this.Equals(input as Entrydoc2GetuserquotaResQuotainfo);
        }

        /// <summary>
        /// Returns true if Entrydoc2GetuserquotaResQuotainfo instances are equal
        /// </summary>
        /// <param name="input">Instance of Entrydoc2GetuserquotaResQuotainfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Entrydoc2GetuserquotaResQuotainfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Doctype == input.Doctype ||
                    (this.Doctype != null &&
                    this.Doctype.Equals(input.Doctype))
                ) && 
                (
                    this.Typename == input.Typename ||
                    (this.Typename != null &&
                    this.Typename.Equals(input.Typename))
                ) && 
                (
                    this.Docid == input.Docid ||
                    (this.Docid != null &&
                    this.Docid.Equals(input.Docid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Quota == input.Quota ||
                    (this.Quota != null &&
                    this.Quota.Equals(input.Quota))
                ) && 
                (
                    this.Used == input.Used ||
                    (this.Used != null &&
                    this.Used.Equals(input.Used))
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
                if (this.Doctype != null)
                    hashCode = hashCode * 59 + this.Doctype.GetHashCode();
                if (this.Typename != null)
                    hashCode = hashCode * 59 + this.Typename.GetHashCode();
                if (this.Docid != null)
                    hashCode = hashCode * 59 + this.Docid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Quota != null)
                    hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.Used != null)
                    hashCode = hashCode * 59 + this.Used.GetHashCode();
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
