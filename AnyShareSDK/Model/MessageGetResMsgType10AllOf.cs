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
    /// MessageGetResMsgType10AllOf
    /// </summary>
    [DataContract]
    public partial class MessageGetResMsgType10AllOf :  IEquatable<MessageGetResMsgType10AllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGetResMsgType10AllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageGetResMsgType10AllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGetResMsgType10AllOf" /> class.
        /// </summary>
        /// <param name="allowvalue">允许的权限值，按bit为存储，参考权限获取 (required).</param>
        /// <param name="denyvalue">拒绝的权限值，按bit为存储，参考权限获取 (required).</param>
        /// <param name="end">有效到期时间 (unix utc 精确到微秒)  -1 无限期 (required).</param>
        /// <param name="auditorname">审核员名字 (required).</param>
        /// <param name="auditresult">审核结果 true表示通过 false表示拒绝 (required).</param>
        /// <param name="auditmsg">审核意见 (required).</param>
        public MessageGetResMsgType10AllOf(long? allowvalue = default(long?), long? denyvalue = default(long?), long? end = default(long?), string auditorname = default(string), bool? auditresult = default(bool?), string auditmsg = default(string))
        {
            this.Allowvalue = allowvalue;
            this.Denyvalue = denyvalue;
            this.End = end;
            this.Auditorname = auditorname;
            this.Auditresult = auditresult;
            this.Auditmsg = auditmsg;
        }
        
        /// <summary>
        /// 允许的权限值，按bit为存储，参考权限获取
        /// </summary>
        /// <value>允许的权限值，按bit为存储，参考权限获取</value>
        [DataMember(Name="allowvalue", EmitDefaultValue=false)]
        public long? Allowvalue { get; set; }

        /// <summary>
        /// 拒绝的权限值，按bit为存储，参考权限获取
        /// </summary>
        /// <value>拒绝的权限值，按bit为存储，参考权限获取</value>
        [DataMember(Name="denyvalue", EmitDefaultValue=false)]
        public long? Denyvalue { get; set; }

        /// <summary>
        /// 有效到期时间 (unix utc 精确到微秒)  -1 无限期
        /// </summary>
        /// <value>有效到期时间 (unix utc 精确到微秒)  -1 无限期</value>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public long? End { get; set; }

        /// <summary>
        /// 审核员名字
        /// </summary>
        /// <value>审核员名字</value>
        [DataMember(Name="auditorname", EmitDefaultValue=false)]
        public string Auditorname { get; set; }

        /// <summary>
        /// 审核结果 true表示通过 false表示拒绝
        /// </summary>
        /// <value>审核结果 true表示通过 false表示拒绝</value>
        [DataMember(Name="auditresult", EmitDefaultValue=false)]
        public bool? Auditresult { get; set; }

        /// <summary>
        /// 审核意见
        /// </summary>
        /// <value>审核意见</value>
        [DataMember(Name="auditmsg", EmitDefaultValue=false)]
        public string Auditmsg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageGetResMsgType10AllOf {\n");
            sb.Append("  Allowvalue: ").Append(Allowvalue).Append("\n");
            sb.Append("  Denyvalue: ").Append(Denyvalue).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Auditorname: ").Append(Auditorname).Append("\n");
            sb.Append("  Auditresult: ").Append(Auditresult).Append("\n");
            sb.Append("  Auditmsg: ").Append(Auditmsg).Append("\n");
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
            return this.Equals(input as MessageGetResMsgType10AllOf);
        }

        /// <summary>
        /// Returns true if MessageGetResMsgType10AllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageGetResMsgType10AllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageGetResMsgType10AllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Allowvalue == input.Allowvalue ||
                    (this.Allowvalue != null &&
                    this.Allowvalue.Equals(input.Allowvalue))
                ) && 
                (
                    this.Denyvalue == input.Denyvalue ||
                    (this.Denyvalue != null &&
                    this.Denyvalue.Equals(input.Denyvalue))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.Auditorname == input.Auditorname ||
                    (this.Auditorname != null &&
                    this.Auditorname.Equals(input.Auditorname))
                ) && 
                (
                    this.Auditresult == input.Auditresult ||
                    (this.Auditresult != null &&
                    this.Auditresult.Equals(input.Auditresult))
                ) && 
                (
                    this.Auditmsg == input.Auditmsg ||
                    (this.Auditmsg != null &&
                    this.Auditmsg.Equals(input.Auditmsg))
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
                if (this.Allowvalue != null)
                    hashCode = hashCode * 59 + this.Allowvalue.GetHashCode();
                if (this.Denyvalue != null)
                    hashCode = hashCode * 59 + this.Denyvalue.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.Auditorname != null)
                    hashCode = hashCode * 59 + this.Auditorname.GetHashCode();
                if (this.Auditresult != null)
                    hashCode = hashCode * 59 + this.Auditresult.GetHashCode();
                if (this.Auditmsg != null)
                    hashCode = hashCode * 59 + this.Auditmsg.GetHashCode();
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
