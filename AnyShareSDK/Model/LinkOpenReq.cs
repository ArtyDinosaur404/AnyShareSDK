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
    /// LinkOpenReq
    /// </summary>
    [DataContract]
    public partial class LinkOpenReq :  IEquatable<LinkOpenReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkOpenReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkOpenReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkOpenReq" /> class.
        /// </summary>
        /// <param name="docid">待开启外链的对象gns路径 (required).</param>
        /// <param name="open">如果true，返回密码，false，密码空.</param>
        /// <param name="endtime">到期时间，单位：微秒.</param>
        /// <param name="perm">权限值，值域为[1,7]，具体说明参见开启外链中的描述.</param>
        /// <param name="limittimes">外链使用次数。  -1为无限制  .</param>
        public LinkOpenReq(string docid = default(string), bool? open = default(bool?), long? endtime = default(long?), long? perm = default(long?), long? limittimes = default(long?))
        {
            this.Docid = docid;
            this.Open = open;
            this.Endtime = endtime;
            this.Perm = perm;
            this.Limittimes = limittimes;
        }
        
        /// <summary>
        /// 待开启外链的对象gns路径
        /// </summary>
        /// <value>待开启外链的对象gns路径</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 如果true，返回密码，false，密码空
        /// </summary>
        /// <value>如果true，返回密码，false，密码空</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public bool? Open { get; set; }

        /// <summary>
        /// 到期时间，单位：微秒
        /// </summary>
        /// <value>到期时间，单位：微秒</value>
        [DataMember(Name="endtime", EmitDefaultValue=false)]
        public long? Endtime { get; set; }

        /// <summary>
        /// 权限值，值域为[1,7]，具体说明参见开启外链中的描述
        /// </summary>
        /// <value>权限值，值域为[1,7]，具体说明参见开启外链中的描述</value>
        [DataMember(Name="perm", EmitDefaultValue=false)]
        public long? Perm { get; set; }

        /// <summary>
        /// 外链使用次数。  -1为无限制  
        /// </summary>
        /// <value>外链使用次数。  -1为无限制  </value>
        [DataMember(Name="limittimes", EmitDefaultValue=false)]
        public long? Limittimes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkOpenReq {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Endtime: ").Append(Endtime).Append("\n");
            sb.Append("  Perm: ").Append(Perm).Append("\n");
            sb.Append("  Limittimes: ").Append(Limittimes).Append("\n");
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
            return this.Equals(input as LinkOpenReq);
        }

        /// <summary>
        /// Returns true if LinkOpenReq instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkOpenReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkOpenReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Docid == input.Docid ||
                    (this.Docid != null &&
                    this.Docid.Equals(input.Docid))
                ) && 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
                ) && 
                (
                    this.Endtime == input.Endtime ||
                    (this.Endtime != null &&
                    this.Endtime.Equals(input.Endtime))
                ) && 
                (
                    this.Perm == input.Perm ||
                    (this.Perm != null &&
                    this.Perm.Equals(input.Perm))
                ) && 
                (
                    this.Limittimes == input.Limittimes ||
                    (this.Limittimes != null &&
                    this.Limittimes.Equals(input.Limittimes))
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
                if (this.Docid != null)
                    hashCode = hashCode * 59 + this.Docid.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.Endtime != null)
                    hashCode = hashCode * 59 + this.Endtime.GetHashCode();
                if (this.Perm != null)
                    hashCode = hashCode * 59 + this.Perm.GetHashCode();
                if (this.Limittimes != null)
                    hashCode = hashCode * 59 + this.Limittimes.GetHashCode();
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
