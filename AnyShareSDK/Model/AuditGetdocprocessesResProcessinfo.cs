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
    /// AuditGetdocprocessesResProcessinfo
    /// </summary>
    [DataContract]
    public partial class AuditGetdocprocessesResProcessinfo :  IEquatable<AuditGetdocprocessesResProcessinfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditGetdocprocessesResProcessinfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditGetdocprocessesResProcessinfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditGetdocprocessesResProcessinfo" /> class.
        /// </summary>
        /// <param name="auditornames">所有审核员名称列表 (required).</param>
        /// <param name="audittype">审核模式  1：同级审核  2：汇签审核  3：逐级审核 (required).</param>
        /// <param name="destpath">发布目的路径 (required).</param>
        /// <param name="processid">流程id (required).</param>
        /// <param name="processname">流程名称 (required).</param>
        public AuditGetdocprocessesResProcessinfo(List<string> auditornames = default(List<string>), long? audittype = default(long?), string destpath = default(string), string processid = default(string), string processname = default(string))
        {
            this.Auditornames = auditornames;
            this.Audittype = audittype;
            this.Destpath = destpath;
            this.Processid = processid;
            this.Processname = processname;
        }
        
        /// <summary>
        /// 所有审核员名称列表
        /// </summary>
        /// <value>所有审核员名称列表</value>
        [DataMember(Name="auditornames", EmitDefaultValue=false)]
        public List<string> Auditornames { get; set; }

        /// <summary>
        /// 审核模式  1：同级审核  2：汇签审核  3：逐级审核
        /// </summary>
        /// <value>审核模式  1：同级审核  2：汇签审核  3：逐级审核</value>
        [DataMember(Name="audittype", EmitDefaultValue=false)]
        public long? Audittype { get; set; }

        /// <summary>
        /// 发布目的路径
        /// </summary>
        /// <value>发布目的路径</value>
        [DataMember(Name="destpath", EmitDefaultValue=false)]
        public string Destpath { get; set; }

        /// <summary>
        /// 流程id
        /// </summary>
        /// <value>流程id</value>
        [DataMember(Name="processid", EmitDefaultValue=false)]
        public string Processid { get; set; }

        /// <summary>
        /// 流程名称
        /// </summary>
        /// <value>流程名称</value>
        [DataMember(Name="processname", EmitDefaultValue=false)]
        public string Processname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditGetdocprocessesResProcessinfo {\n");
            sb.Append("  Auditornames: ").Append(Auditornames).Append("\n");
            sb.Append("  Audittype: ").Append(Audittype).Append("\n");
            sb.Append("  Destpath: ").Append(Destpath).Append("\n");
            sb.Append("  Processid: ").Append(Processid).Append("\n");
            sb.Append("  Processname: ").Append(Processname).Append("\n");
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
            return this.Equals(input as AuditGetdocprocessesResProcessinfo);
        }

        /// <summary>
        /// Returns true if AuditGetdocprocessesResProcessinfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditGetdocprocessesResProcessinfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditGetdocprocessesResProcessinfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Auditornames == input.Auditornames ||
                    this.Auditornames != null &&
                    input.Auditornames != null &&
                    this.Auditornames.SequenceEqual(input.Auditornames)
                ) && 
                (
                    this.Audittype == input.Audittype ||
                    (this.Audittype != null &&
                    this.Audittype.Equals(input.Audittype))
                ) && 
                (
                    this.Destpath == input.Destpath ||
                    (this.Destpath != null &&
                    this.Destpath.Equals(input.Destpath))
                ) && 
                (
                    this.Processid == input.Processid ||
                    (this.Processid != null &&
                    this.Processid.Equals(input.Processid))
                ) && 
                (
                    this.Processname == input.Processname ||
                    (this.Processname != null &&
                    this.Processname.Equals(input.Processname))
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
                if (this.Auditornames != null)
                    hashCode = hashCode * 59 + this.Auditornames.GetHashCode();
                if (this.Audittype != null)
                    hashCode = hashCode * 59 + this.Audittype.GetHashCode();
                if (this.Destpath != null)
                    hashCode = hashCode * 59 + this.Destpath.GetHashCode();
                if (this.Processid != null)
                    hashCode = hashCode * 59 + this.Processid.GetHashCode();
                if (this.Processname != null)
                    hashCode = hashCode * 59 + this.Processname.GetHashCode();
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
