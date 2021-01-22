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
    /// InvitationGetRes
    /// </summary>
    [DataContract]
    public partial class InvitationGetRes :  IEquatable<InvitationGetRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationGetRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvitationGetRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationGetRes" /> class.
        /// </summary>
        /// <param name="invitationendtime">邀请链接到期时间，如果为-1，表示无限期 (required).</param>
        /// <param name="perm">权限值 (required).</param>
        /// <param name="permendtime">权限到期时间，如果为-1，表示无限期 (required).</param>
        /// <param name="image">图片备注信息 (required).</param>
        /// <param name="description">备注描述信息 (required).</param>
        /// <param name="docname">文档名称 (required).</param>
        /// <param name="isdir">是否为目录 (required).</param>
        public InvitationGetRes(long? invitationendtime = default(long?), long? perm = default(long?), long? permendtime = default(long?), string image = default(string), string description = default(string), string docname = default(string), bool? isdir = default(bool?))
        {
            this.Invitationendtime = invitationendtime;
            this.Perm = perm;
            this.Permendtime = permendtime;
            this.Image = image;
            this.Description = description;
            this.Docname = docname;
            this.Isdir = isdir;
        }
        
        /// <summary>
        /// 邀请链接到期时间，如果为-1，表示无限期
        /// </summary>
        /// <value>邀请链接到期时间，如果为-1，表示无限期</value>
        [DataMember(Name="invitationendtime", EmitDefaultValue=false)]
        public long? Invitationendtime { get; set; }

        /// <summary>
        /// 权限值
        /// </summary>
        /// <value>权限值</value>
        [DataMember(Name="perm", EmitDefaultValue=false)]
        public long? Perm { get; set; }

        /// <summary>
        /// 权限到期时间，如果为-1，表示无限期
        /// </summary>
        /// <value>权限到期时间，如果为-1，表示无限期</value>
        [DataMember(Name="permendtime", EmitDefaultValue=false)]
        public long? Permendtime { get; set; }

        /// <summary>
        /// 图片备注信息
        /// </summary>
        /// <value>图片备注信息</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// 备注描述信息
        /// </summary>
        /// <value>备注描述信息</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// 文档名称
        /// </summary>
        /// <value>文档名称</value>
        [DataMember(Name="docname", EmitDefaultValue=false)]
        public string Docname { get; set; }

        /// <summary>
        /// 是否为目录
        /// </summary>
        /// <value>是否为目录</value>
        [DataMember(Name="isdir", EmitDefaultValue=false)]
        public bool? Isdir { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvitationGetRes {\n");
            sb.Append("  Invitationendtime: ").Append(Invitationendtime).Append("\n");
            sb.Append("  Perm: ").Append(Perm).Append("\n");
            sb.Append("  Permendtime: ").Append(Permendtime).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Docname: ").Append(Docname).Append("\n");
            sb.Append("  Isdir: ").Append(Isdir).Append("\n");
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
            return this.Equals(input as InvitationGetRes);
        }

        /// <summary>
        /// Returns true if InvitationGetRes instances are equal
        /// </summary>
        /// <param name="input">Instance of InvitationGetRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvitationGetRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Invitationendtime == input.Invitationendtime ||
                    (this.Invitationendtime != null &&
                    this.Invitationendtime.Equals(input.Invitationendtime))
                ) && 
                (
                    this.Perm == input.Perm ||
                    (this.Perm != null &&
                    this.Perm.Equals(input.Perm))
                ) && 
                (
                    this.Permendtime == input.Permendtime ||
                    (this.Permendtime != null &&
                    this.Permendtime.Equals(input.Permendtime))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Invitationendtime != null)
                    hashCode = hashCode * 59 + this.Invitationendtime.GetHashCode();
                if (this.Perm != null)
                    hashCode = hashCode * 59 + this.Perm.GetHashCode();
                if (this.Permendtime != null)
                    hashCode = hashCode * 59 + this.Permendtime.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Docname != null)
                    hashCode = hashCode * 59 + this.Docname.GetHashCode();
                if (this.Isdir != null)
                    hashCode = hashCode * 59 + this.Isdir.GetHashCode();
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