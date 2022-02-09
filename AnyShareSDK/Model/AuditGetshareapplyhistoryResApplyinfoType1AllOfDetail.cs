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
    /// 具体的申请信息，根据apptype，所包含的字段不同
    /// </summary>
    [DataContract]
    public partial class AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail :  IEquatable<AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail" /> class.
        /// </summary>
        /// <param name="accessorid">访问者id (required).</param>
        /// <param name="accessorname">访问者名称 (required).</param>
        /// <param name="accessortype">访问者类型 (required).</param>
        /// <param name="allowvalue">允许权限值 (required).</param>
        /// <param name="auditmsg">审核说明 (required).</param>
        /// <param name="denyvalue">拒绝的权限值 (required).</param>
        /// <param name="endtime">截止时间 (required).</param>
        /// <param name="optype">权限操作类型  1表示新增  2表示编辑  3表示删除 (required).</param>
        public AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail(string accessorid = default(string), string accessorname = default(string), long? accessortype = default(long?), long? allowvalue = default(long?), string auditmsg = default(string), long? denyvalue = default(long?), long? endtime = default(long?), long? optype = default(long?))
        {
            this.Accessorid = accessorid;
            this.Accessorname = accessorname;
            this.Accessortype = accessortype;
            this.Allowvalue = allowvalue;
            this.Auditmsg = auditmsg;
            this.Denyvalue = denyvalue;
            this.Endtime = endtime;
            this.Optype = optype;
        }
        
        /// <summary>
        /// 访问者id
        /// </summary>
        /// <value>访问者id</value>
        [DataMember(Name="accessorid", EmitDefaultValue=false)]
        public string Accessorid { get; set; }

        /// <summary>
        /// 访问者名称
        /// </summary>
        /// <value>访问者名称</value>
        [DataMember(Name="accessorname", EmitDefaultValue=false)]
        public string Accessorname { get; set; }

        /// <summary>
        /// 访问者类型
        /// </summary>
        /// <value>访问者类型</value>
        [DataMember(Name="accessortype", EmitDefaultValue=false)]
        public long? Accessortype { get; set; }

        /// <summary>
        /// 允许权限值
        /// </summary>
        /// <value>允许权限值</value>
        [DataMember(Name="allowvalue", EmitDefaultValue=false)]
        public long? Allowvalue { get; set; }

        /// <summary>
        /// 审核说明
        /// </summary>
        /// <value>审核说明</value>
        [DataMember(Name="auditmsg", EmitDefaultValue=false)]
        public string Auditmsg { get; set; }

        /// <summary>
        /// 拒绝的权限值
        /// </summary>
        /// <value>拒绝的权限值</value>
        [DataMember(Name="denyvalue", EmitDefaultValue=false)]
        public long? Denyvalue { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        /// <value>截止时间</value>
        [DataMember(Name="endtime", EmitDefaultValue=false)]
        public long? Endtime { get; set; }

        /// <summary>
        /// 权限操作类型  1表示新增  2表示编辑  3表示删除
        /// </summary>
        /// <value>权限操作类型  1表示新增  2表示编辑  3表示删除</value>
        [DataMember(Name="optype", EmitDefaultValue=false)]
        public long? Optype { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail {\n");
            sb.Append("  Accessorid: ").Append(Accessorid).Append("\n");
            sb.Append("  Accessorname: ").Append(Accessorname).Append("\n");
            sb.Append("  Accessortype: ").Append(Accessortype).Append("\n");
            sb.Append("  Allowvalue: ").Append(Allowvalue).Append("\n");
            sb.Append("  Auditmsg: ").Append(Auditmsg).Append("\n");
            sb.Append("  Denyvalue: ").Append(Denyvalue).Append("\n");
            sb.Append("  Endtime: ").Append(Endtime).Append("\n");
            sb.Append("  Optype: ").Append(Optype).Append("\n");
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
            return this.Equals(input as AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail);
        }

        /// <summary>
        /// Returns true if AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditGetshareapplyhistoryResApplyinfoType1AllOfDetail input)
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
                    this.Accessorname == input.Accessorname ||
                    (this.Accessorname != null &&
                    this.Accessorname.Equals(input.Accessorname))
                ) && 
                (
                    this.Accessortype == input.Accessortype ||
                    (this.Accessortype != null &&
                    this.Accessortype.Equals(input.Accessortype))
                ) && 
                (
                    this.Allowvalue == input.Allowvalue ||
                    (this.Allowvalue != null &&
                    this.Allowvalue.Equals(input.Allowvalue))
                ) && 
                (
                    this.Auditmsg == input.Auditmsg ||
                    (this.Auditmsg != null &&
                    this.Auditmsg.Equals(input.Auditmsg))
                ) && 
                (
                    this.Denyvalue == input.Denyvalue ||
                    (this.Denyvalue != null &&
                    this.Denyvalue.Equals(input.Denyvalue))
                ) && 
                (
                    this.Endtime == input.Endtime ||
                    (this.Endtime != null &&
                    this.Endtime.Equals(input.Endtime))
                ) && 
                (
                    this.Optype == input.Optype ||
                    (this.Optype != null &&
                    this.Optype.Equals(input.Optype))
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
                if (this.Accessorname != null)
                    hashCode = hashCode * 59 + this.Accessorname.GetHashCode();
                if (this.Accessortype != null)
                    hashCode = hashCode * 59 + this.Accessortype.GetHashCode();
                if (this.Allowvalue != null)
                    hashCode = hashCode * 59 + this.Allowvalue.GetHashCode();
                if (this.Auditmsg != null)
                    hashCode = hashCode * 59 + this.Auditmsg.GetHashCode();
                if (this.Denyvalue != null)
                    hashCode = hashCode * 59 + this.Denyvalue.GetHashCode();
                if (this.Endtime != null)
                    hashCode = hashCode * 59 + this.Endtime.GetHashCode();
                if (this.Optype != null)
                    hashCode = hashCode * 59 + this.Optype.GetHashCode();
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
