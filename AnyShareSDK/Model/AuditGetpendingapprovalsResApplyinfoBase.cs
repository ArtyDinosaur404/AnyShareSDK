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
    /// AuditGetpendingapprovalsResApplyinfoBase
    /// </summary>
    [DataContract]
    public partial class AuditGetpendingapprovalsResApplyinfoBase :  IEquatable<AuditGetpendingapprovalsResApplyinfoBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditGetpendingapprovalsResApplyinfoBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditGetpendingapprovalsResApplyinfoBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditGetpendingapprovalsResApplyinfoBase" /> class.
        /// </summary>
        /// <param name="applyid">申请记录id (required).</param>
        /// <param name="docid">文档gns路径 (required).</param>
        /// <param name="docname">文档名称 (required).</param>
        /// <param name="apptype">申请类型  1表示共享申请  2表示外链申请  3表示所有者申请  5表示更改密级申请  6 表示更改继承申请 (required).</param>
        /// <param name="isdir">是否为文件夹 (required).</param>
        /// <param name="csflevel">文件密级,5~15，如果是文件夹，则为0 (required).</param>
        /// <param name="sharername">共享者名称 (required).</param>
        /// <param name="createdate">申请时间（微秒时间戳） (required).</param>
        public AuditGetpendingapprovalsResApplyinfoBase(string applyid = default(string), string docid = default(string), string docname = default(string), long? apptype = default(long?), bool? isdir = default(bool?), long? csflevel = default(long?), string sharername = default(string), long? createdate = default(long?))
        {
            this.Applyid = applyid;
            this.Docid = docid;
            this.Docname = docname;
            this.Apptype = apptype;
            this.Isdir = isdir;
            this.Csflevel = csflevel;
            this.Sharername = sharername;
            this.Createdate = createdate;
        }
        
        /// <summary>
        /// 申请记录id
        /// </summary>
        /// <value>申请记录id</value>
        [DataMember(Name="applyid", EmitDefaultValue=false)]
        public string Applyid { get; set; }

        /// <summary>
        /// 文档gns路径
        /// </summary>
        /// <value>文档gns路径</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 文档名称
        /// </summary>
        /// <value>文档名称</value>
        [DataMember(Name="docname", EmitDefaultValue=false)]
        public string Docname { get; set; }

        /// <summary>
        /// 申请类型  1表示共享申请  2表示外链申请  3表示所有者申请  5表示更改密级申请  6 表示更改继承申请
        /// </summary>
        /// <value>申请类型  1表示共享申请  2表示外链申请  3表示所有者申请  5表示更改密级申请  6 表示更改继承申请</value>
        [DataMember(Name="apptype", EmitDefaultValue=false)]
        public long? Apptype { get; set; }

        /// <summary>
        /// 是否为文件夹
        /// </summary>
        /// <value>是否为文件夹</value>
        [DataMember(Name="isdir", EmitDefaultValue=false)]
        public bool? Isdir { get; set; }

        /// <summary>
        /// 文件密级,5~15，如果是文件夹，则为0
        /// </summary>
        /// <value>文件密级,5~15，如果是文件夹，则为0</value>
        [DataMember(Name="csflevel", EmitDefaultValue=false)]
        public long? Csflevel { get; set; }

        /// <summary>
        /// 共享者名称
        /// </summary>
        /// <value>共享者名称</value>
        [DataMember(Name="sharername", EmitDefaultValue=false)]
        public string Sharername { get; set; }

        /// <summary>
        /// 申请时间（微秒时间戳）
        /// </summary>
        /// <value>申请时间（微秒时间戳）</value>
        [DataMember(Name="createdate", EmitDefaultValue=false)]
        public long? Createdate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditGetpendingapprovalsResApplyinfoBase {\n");
            sb.Append("  Applyid: ").Append(Applyid).Append("\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Docname: ").Append(Docname).Append("\n");
            sb.Append("  Apptype: ").Append(Apptype).Append("\n");
            sb.Append("  Isdir: ").Append(Isdir).Append("\n");
            sb.Append("  Csflevel: ").Append(Csflevel).Append("\n");
            sb.Append("  Sharername: ").Append(Sharername).Append("\n");
            sb.Append("  Createdate: ").Append(Createdate).Append("\n");
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
            return this.Equals(input as AuditGetpendingapprovalsResApplyinfoBase);
        }

        /// <summary>
        /// Returns true if AuditGetpendingapprovalsResApplyinfoBase instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditGetpendingapprovalsResApplyinfoBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditGetpendingapprovalsResApplyinfoBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Applyid == input.Applyid ||
                    (this.Applyid != null &&
                    this.Applyid.Equals(input.Applyid))
                ) && 
                (
                    this.Docid == input.Docid ||
                    (this.Docid != null &&
                    this.Docid.Equals(input.Docid))
                ) && 
                (
                    this.Docname == input.Docname ||
                    (this.Docname != null &&
                    this.Docname.Equals(input.Docname))
                ) && 
                (
                    this.Apptype == input.Apptype ||
                    (this.Apptype != null &&
                    this.Apptype.Equals(input.Apptype))
                ) && 
                (
                    this.Isdir == input.Isdir ||
                    (this.Isdir != null &&
                    this.Isdir.Equals(input.Isdir))
                ) && 
                (
                    this.Csflevel == input.Csflevel ||
                    (this.Csflevel != null &&
                    this.Csflevel.Equals(input.Csflevel))
                ) && 
                (
                    this.Sharername == input.Sharername ||
                    (this.Sharername != null &&
                    this.Sharername.Equals(input.Sharername))
                ) && 
                (
                    this.Createdate == input.Createdate ||
                    (this.Createdate != null &&
                    this.Createdate.Equals(input.Createdate))
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
                if (this.Applyid != null)
                    hashCode = hashCode * 59 + this.Applyid.GetHashCode();
                if (this.Docid != null)
                    hashCode = hashCode * 59 + this.Docid.GetHashCode();
                if (this.Docname != null)
                    hashCode = hashCode * 59 + this.Docname.GetHashCode();
                if (this.Apptype != null)
                    hashCode = hashCode * 59 + this.Apptype.GetHashCode();
                if (this.Isdir != null)
                    hashCode = hashCode * 59 + this.Isdir.GetHashCode();
                if (this.Csflevel != null)
                    hashCode = hashCode * 59 + this.Csflevel.GetHashCode();
                if (this.Sharername != null)
                    hashCode = hashCode * 59 + this.Sharername.GetHashCode();
                if (this.Createdate != null)
                    hashCode = hashCode * 59 + this.Createdate.GetHashCode();
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
