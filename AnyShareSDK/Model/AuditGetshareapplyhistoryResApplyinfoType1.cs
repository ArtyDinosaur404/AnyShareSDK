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
    /// AuditGetshareapplyhistoryResApplyinfoType1
    /// </summary>
    [DataContract]
    public partial class AuditGetshareapplyhistoryResApplyinfoType1 :  IEquatable<AuditGetshareapplyhistoryResApplyinfoType1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditGetshareapplyhistoryResApplyinfoType1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditGetshareapplyhistoryResApplyinfoType1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditGetshareapplyhistoryResApplyinfoType1" /> class.
        /// </summary>
        /// <param name="approveindex">结合auditorname,小于等于该值的表示审批通过的审核员，从0开始 (required).</param>
        /// <param name="auditornames">提交审核时，所有能看到该申请记录的审核员的名称  auditornames[approveindex]表示审核通过的审核员如auditornames[vetoindex]表示否决的审核员  approveindex 和 vetoindex 都为 -1 表示免审核 (required).</param>
        /// <param name="csflevel">文件密级，5~15，如果是文件夹，则为0 (required).</param>
        /// <param name="docname">文档名称 (required).</param>
        /// <param name="isdir">是否为文件夹 (required).</param>
        /// <param name="requestdate">申请时间（微秒时间戳） (required).</param>
        /// <param name="vetoindex">结合auditorname，该位置表示否决的人在auditornames中的位置，从0开始，  -1表示没有人否决 (required).</param>
        /// <param name="apptype">申请类型  1表示共享申请  2表示外链申请  3表示所有者申请  5更改密级申请  6表示更改继承申请 (required).</param>
        /// <param name="detail">detail.</param>
        public AuditGetshareapplyhistoryResApplyinfoType1(long? approveindex = default(long?), List<string> auditornames = default(List<string>), long? csflevel = default(long?), string docname = default(string), bool? isdir = default(bool?), long? requestdate = default(long?), long? vetoindex = default(long?), long? apptype = default(long?), AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail detail = default(AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail))
        {
            this.Approveindex = approveindex;
            this.Auditornames = auditornames;
            this.Csflevel = csflevel;
            this.Docname = docname;
            this.Isdir = isdir;
            this.Requestdate = requestdate;
            this.Vetoindex = vetoindex;
            this.Apptype = apptype;
            this.Detail = detail;
        }
        
        /// <summary>
        /// 结合auditorname,小于等于该值的表示审批通过的审核员，从0开始
        /// </summary>
        /// <value>结合auditorname,小于等于该值的表示审批通过的审核员，从0开始</value>
        [DataMember(Name="approveindex", EmitDefaultValue=false)]
        public long? Approveindex { get; set; }

        /// <summary>
        /// 提交审核时，所有能看到该申请记录的审核员的名称  auditornames[approveindex]表示审核通过的审核员如auditornames[vetoindex]表示否决的审核员  approveindex 和 vetoindex 都为 -1 表示免审核
        /// </summary>
        /// <value>提交审核时，所有能看到该申请记录的审核员的名称  auditornames[approveindex]表示审核通过的审核员如auditornames[vetoindex]表示否决的审核员  approveindex 和 vetoindex 都为 -1 表示免审核</value>
        [DataMember(Name="auditornames", EmitDefaultValue=false)]
        public List<string> Auditornames { get; set; }

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
        /// 申请时间（微秒时间戳）
        /// </summary>
        /// <value>申请时间（微秒时间戳）</value>
        [DataMember(Name="requestdate", EmitDefaultValue=false)]
        public long? Requestdate { get; set; }

        /// <summary>
        /// 结合auditorname，该位置表示否决的人在auditornames中的位置，从0开始，  -1表示没有人否决
        /// </summary>
        /// <value>结合auditorname，该位置表示否决的人在auditornames中的位置，从0开始，  -1表示没有人否决</value>
        [DataMember(Name="vetoindex", EmitDefaultValue=false)]
        public long? Vetoindex { get; set; }

        /// <summary>
        /// 申请类型  1表示共享申请  2表示外链申请  3表示所有者申请  5更改密级申请  6表示更改继承申请
        /// </summary>
        /// <value>申请类型  1表示共享申请  2表示外链申请  3表示所有者申请  5更改密级申请  6表示更改继承申请</value>
        [DataMember(Name="apptype", EmitDefaultValue=false)]
        public long? Apptype { get; set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail Detail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditGetshareapplyhistoryResApplyinfoType1 {\n");
            sb.Append("  Approveindex: ").Append(Approveindex).Append("\n");
            sb.Append("  Auditornames: ").Append(Auditornames).Append("\n");
            sb.Append("  Csflevel: ").Append(Csflevel).Append("\n");
            sb.Append("  Docname: ").Append(Docname).Append("\n");
            sb.Append("  Isdir: ").Append(Isdir).Append("\n");
            sb.Append("  Requestdate: ").Append(Requestdate).Append("\n");
            sb.Append("  Vetoindex: ").Append(Vetoindex).Append("\n");
            sb.Append("  Apptype: ").Append(Apptype).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
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
            return this.Equals(input as AuditGetshareapplyhistoryResApplyinfoType1);
        }

        /// <summary>
        /// Returns true if AuditGetshareapplyhistoryResApplyinfoType1 instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditGetshareapplyhistoryResApplyinfoType1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditGetshareapplyhistoryResApplyinfoType1 input)
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
                    this.Requestdate == input.Requestdate ||
                    (this.Requestdate != null &&
                    this.Requestdate.Equals(input.Requestdate))
                ) && 
                (
                    this.Vetoindex == input.Vetoindex ||
                    (this.Vetoindex != null &&
                    this.Vetoindex.Equals(input.Vetoindex))
                ) && 
                (
                    this.Apptype == input.Apptype ||
                    (this.Apptype != null &&
                    this.Apptype.Equals(input.Apptype))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
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
                if (this.Csflevel != null)
                    hashCode = hashCode * 59 + this.Csflevel.GetHashCode();
                if (this.Docname != null)
                    hashCode = hashCode * 59 + this.Docname.GetHashCode();
                if (this.Isdir != null)
                    hashCode = hashCode * 59 + this.Isdir.GetHashCode();
                if (this.Requestdate != null)
                    hashCode = hashCode * 59 + this.Requestdate.GetHashCode();
                if (this.Vetoindex != null)
                    hashCode = hashCode * 59 + this.Vetoindex.GetHashCode();
                if (this.Apptype != null)
                    hashCode = hashCode * 59 + this.Apptype.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
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
