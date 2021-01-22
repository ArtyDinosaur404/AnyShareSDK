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
    /// AuditGetapprovehistoryResApplyinfo
    /// </summary>
    [DataContract]
    public partial class AuditGetapprovehistoryResApplyinfo :  IEquatable<AuditGetapprovehistoryResApplyinfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditGetapprovehistoryResApplyinfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditGetapprovehistoryResApplyinfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditGetapprovehistoryResApplyinfo" /> class.
        /// </summary>
        /// <param name="approveindex">结合auditorname,小于等于该值的表示审批通过的审核员，从0开始 (required).</param>
        /// <param name="auditornames">提交审核时，所有能看到该申请记录的审核员的名称  [0, approveindex]表示审核通过的审核员列表，-1表示没有审核员通过  如果vetoindex不为-1，则auditornames[vetoindex]表示否决的审核员  剩下的为未参与审核的 (required).</param>
        /// <param name="audittype">审核模式  1表示同级审核  2表示汇签审核  3表示逐级审核 (required).</param>
        /// <param name="csflevel">文件密级，5~15，如果是文件夹，则为0 (required).</param>
        /// <param name="docname">文档名称 (required).</param>
        /// <param name="isdir">是否为文件夹 (required).</param>
        /// <param name="processname">流程名称 (required).</param>
        /// <param name="requestdate">申请时间（微秒时间戳） (required).</param>
        /// <param name="requesterName">申请者名称 (required).</param>
        /// <param name="vetoindex">结合auditorname，该位置表示否决的人在auditornames中的位置，从0开始，  -1表示没有人否决 (required).</param>
        public AuditGetapprovehistoryResApplyinfo(long? approveindex = default(long?), List<string> auditornames = default(List<string>), long? audittype = default(long?), long? csflevel = default(long?), string docname = default(string), bool? isdir = default(bool?), string processname = default(string), long? requestdate = default(long?), string requesterName = default(string), long? vetoindex = default(long?))
        {
            this.Approveindex = approveindex;
            this.Auditornames = auditornames;
            this.Audittype = audittype;
            this.Csflevel = csflevel;
            this.Docname = docname;
            this.Isdir = isdir;
            this.Processname = processname;
            this.Requestdate = requestdate;
            this.RequesterName = requesterName;
            this.Vetoindex = vetoindex;
        }
        
        /// <summary>
        /// 结合auditorname,小于等于该值的表示审批通过的审核员，从0开始
        /// </summary>
        /// <value>结合auditorname,小于等于该值的表示审批通过的审核员，从0开始</value>
        [DataMember(Name="approveindex", EmitDefaultValue=false)]
        public long? Approveindex { get; set; }

        /// <summary>
        /// 提交审核时，所有能看到该申请记录的审核员的名称  [0, approveindex]表示审核通过的审核员列表，-1表示没有审核员通过  如果vetoindex不为-1，则auditornames[vetoindex]表示否决的审核员  剩下的为未参与审核的
        /// </summary>
        /// <value>提交审核时，所有能看到该申请记录的审核员的名称  [0, approveindex]表示审核通过的审核员列表，-1表示没有审核员通过  如果vetoindex不为-1，则auditornames[vetoindex]表示否决的审核员  剩下的为未参与审核的</value>
        [DataMember(Name="auditornames", EmitDefaultValue=false)]
        public List<string> Auditornames { get; set; }

        /// <summary>
        /// 审核模式  1表示同级审核  2表示汇签审核  3表示逐级审核
        /// </summary>
        /// <value>审核模式  1表示同级审核  2表示汇签审核  3表示逐级审核</value>
        [DataMember(Name="audittype", EmitDefaultValue=false)]
        public long? Audittype { get; set; }

        /// <summary>
        /// 文件密级，5~15，如果是文件夹，则为0
        /// </summary>
        /// <value>文件密级，5~15，如果是文件夹，则为0</value>
        [DataMember(Name="csflevel", EmitDefaultValue=false)]
        public long? Csflevel { get; set; }

        /// <summary>
        /// 文档名称
        /// </summary>
        /// <value>文档名称</value>
        [DataMember(Name="docname", EmitDefaultValue=false)]
        public string Docname { get; set; }

        /// <summary>
        /// 是否为文件夹
        /// </summary>
        /// <value>是否为文件夹</value>
        [DataMember(Name="isdir", EmitDefaultValue=false)]
        public bool? Isdir { get; set; }

        /// <summary>
        /// 流程名称
        /// </summary>
        /// <value>流程名称</value>
        [DataMember(Name="processname", EmitDefaultValue=false)]
        public string Processname { get; set; }

        /// <summary>
        /// 申请时间（微秒时间戳）
        /// </summary>
        /// <value>申请时间（微秒时间戳）</value>
        [DataMember(Name="requestdate", EmitDefaultValue=false)]
        public long? Requestdate { get; set; }

        /// <summary>
        /// 申请者名称
        /// </summary>
        /// <value>申请者名称</value>
        [DataMember(Name="requesterName", EmitDefaultValue=false)]
        public string RequesterName { get; set; }

        /// <summary>
        /// 结合auditorname，该位置表示否决的人在auditornames中的位置，从0开始，  -1表示没有人否决
        /// </summary>
        /// <value>结合auditorname，该位置表示否决的人在auditornames中的位置，从0开始，  -1表示没有人否决</value>
        [DataMember(Name="vetoindex", EmitDefaultValue=false)]
        public long? Vetoindex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditGetapprovehistoryResApplyinfo {\n");
            sb.Append("  Approveindex: ").Append(Approveindex).Append("\n");
            sb.Append("  Auditornames: ").Append(Auditornames).Append("\n");
            sb.Append("  Audittype: ").Append(Audittype).Append("\n");
            sb.Append("  Csflevel: ").Append(Csflevel).Append("\n");
            sb.Append("  Docname: ").Append(Docname).Append("\n");
            sb.Append("  Isdir: ").Append(Isdir).Append("\n");
            sb.Append("  Processname: ").Append(Processname).Append("\n");
            sb.Append("  Requestdate: ").Append(Requestdate).Append("\n");
            sb.Append("  RequesterName: ").Append(RequesterName).Append("\n");
            sb.Append("  Vetoindex: ").Append(Vetoindex).Append("\n");
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
            return this.Equals(input as AuditGetapprovehistoryResApplyinfo);
        }

        /// <summary>
        /// Returns true if AuditGetapprovehistoryResApplyinfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditGetapprovehistoryResApplyinfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditGetapprovehistoryResApplyinfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Approveindex == input.Approveindex ||
                    (this.Approveindex != null &&
                    this.Approveindex.Equals(input.Approveindex))
                ) && 
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
                    this.Csflevel == input.Csflevel ||
                    (this.Csflevel != null &&
                    this.Csflevel.Equals(input.Csflevel))
                ) && 
                (
                    this.Docname == input.Docname ||
                    (this.Docname != null &&
                    this.Docname.Equals(input.Docname))
                ) && 
                (
                    this.Isdir == input.Isdir ||
                    (this.Isdir != null &&
                    this.Isdir.Equals(input.Isdir))
                ) && 
                (
                    this.Processname == input.Processname ||
                    (this.Processname != null &&
                    this.Processname.Equals(input.Processname))
                ) && 
                (
                    this.Requestdate == input.Requestdate ||
                    (this.Requestdate != null &&
                    this.Requestdate.Equals(input.Requestdate))
                ) && 
                (
                    this.RequesterName == input.RequesterName ||
                    (this.RequesterName != null &&
                    this.RequesterName.Equals(input.RequesterName))
                ) && 
                (
                    this.Vetoindex == input.Vetoindex ||
                    (this.Vetoindex != null &&
                    this.Vetoindex.Equals(input.Vetoindex))
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
                if (this.Approveindex != null)
                    hashCode = hashCode * 59 + this.Approveindex.GetHashCode();
                if (this.Auditornames != null)
                    hashCode = hashCode * 59 + this.Auditornames.GetHashCode();
                if (this.Audittype != null)
                    hashCode = hashCode * 59 + this.Audittype.GetHashCode();
                if (this.Csflevel != null)
                    hashCode = hashCode * 59 + this.Csflevel.GetHashCode();
                if (this.Docname != null)
                    hashCode = hashCode * 59 + this.Docname.GetHashCode();
                if (this.Isdir != null)
                    hashCode = hashCode * 59 + this.Isdir.GetHashCode();
                if (this.Processname != null)
                    hashCode = hashCode * 59 + this.Processname.GetHashCode();
                if (this.Requestdate != null)
                    hashCode = hashCode * 59 + this.Requestdate.GetHashCode();
                if (this.RequesterName != null)
                    hashCode = hashCode * 59 + this.RequesterName.GetHashCode();
                if (this.Vetoindex != null)
                    hashCode = hashCode * 59 + this.Vetoindex.GetHashCode();
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
