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
    /// AuditPublishdocReq
    /// </summary>
    [DataContract]
    public partial class AuditPublishdocReq :  IEquatable<AuditPublishdocReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditPublishdocReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditPublishdocReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditPublishdocReq" /> class.
        /// </summary>
        /// <param name="processid">流程id (required).</param>
        /// <param name="docid">文档gns路径 (required).</param>
        /// <param name="applymsg">发起流程时的理由 (required).</param>
        /// <param name="recipients">内外网数据交换目的位置.</param>
        /// <param name="dstdocname">内外网数据交换文档接收位置.</param>
        public AuditPublishdocReq(string processid = default(string), string docid = default(string), string applymsg = default(string), List<AuditPublishdocReqRecipient> recipients = default(List<AuditPublishdocReqRecipient>), string dstdocname = default(string))
        {
            this.Processid = processid;
            this.Docid = docid;
            this.Applymsg = applymsg;
            this.Recipients = recipients;
            this.Dstdocname = dstdocname;
        }
        
        /// <summary>
        /// 流程id
        /// </summary>
        /// <value>流程id</value>
        [DataMember(Name="processid", EmitDefaultValue=false)]
        public string Processid { get; set; }

        /// <summary>
        /// 文档gns路径
        /// </summary>
        /// <value>文档gns路径</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 发起流程时的理由
        /// </summary>
        /// <value>发起流程时的理由</value>
        [DataMember(Name="applymsg", EmitDefaultValue=false)]
        public string Applymsg { get; set; }

        /// <summary>
        /// 内外网数据交换目的位置
        /// </summary>
        /// <value>内外网数据交换目的位置</value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<AuditPublishdocReqRecipient> Recipients { get; set; }

        /// <summary>
        /// 内外网数据交换文档接收位置
        /// </summary>
        /// <value>内外网数据交换文档接收位置</value>
        [DataMember(Name="dstdocname", EmitDefaultValue=false)]
        public string Dstdocname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditPublishdocReq {\n");
            sb.Append("  Processid: ").Append(Processid).Append("\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Applymsg: ").Append(Applymsg).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Dstdocname: ").Append(Dstdocname).Append("\n");
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
            return this.Equals(input as AuditPublishdocReq);
        }

        /// <summary>
        /// Returns true if AuditPublishdocReq instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditPublishdocReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditPublishdocReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Processid == input.Processid ||
                    (this.Processid != null &&
                    this.Processid.Equals(input.Processid))
                ) && 
                (
                    this.Docid == input.Docid ||
                    (this.Docid != null &&
                    this.Docid.Equals(input.Docid))
                ) && 
                (
                    this.Applymsg == input.Applymsg ||
                    (this.Applymsg != null &&
                    this.Applymsg.Equals(input.Applymsg))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    input.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.Dstdocname == input.Dstdocname ||
                    (this.Dstdocname != null &&
                    this.Dstdocname.Equals(input.Dstdocname))
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
                if (this.Processid != null)
                    hashCode = hashCode * 59 + this.Processid.GetHashCode();
                if (this.Docid != null)
                    hashCode = hashCode * 59 + this.Docid.GetHashCode();
                if (this.Applymsg != null)
                    hashCode = hashCode * 59 + this.Applymsg.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.Dstdocname != null)
                    hashCode = hashCode * 59 + this.Dstdocname.GetHashCode();
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