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
    /// MessageGetResMsgType16
    /// </summary>
    [DataContract]
    public partial class MessageGetResMsgType16 :  IEquatable<MessageGetResMsgType16>, IValidatableObject
    {
        /// <summary>
        /// 表示访问者类型
        /// </summary>
        /// <value>表示访问者类型</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessortypeEnum
        {
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 1,

            /// <summary>
            /// Enum Department for value: department
            /// </summary>
            [EnumMember(Value = "department")]
            Department = 2,

            /// <summary>
            /// Enum Contactor for value: contactor
            /// </summary>
            [EnumMember(Value = "contactor")]
            Contactor = 3

        }

        /// <summary>
        /// 表示访问者类型
        /// </summary>
        /// <value>表示访问者类型</value>
        [DataMember(Name="accessortype", EmitDefaultValue=false)]
        public AccessortypeEnum Accessortype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGetResMsgType16" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageGetResMsgType16() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGetResMsgType16" /> class.
        /// </summary>
        /// <param name="accessorname">接收者名字，如果是外链，为空字符串 (required).</param>
        /// <param name="accessortype">表示访问者类型 (required).</param>
        /// <param name="csf">文件密级，5~15，文件夹为0 (required).</param>
        /// <param name="id">此条消息的唯一标识 (required).</param>
        /// <param name="isdir">是否为文件夹 (required).</param>
        /// <param name="isread">消息是否已读 (required).</param>
        /// <param name="sender">发送者名字 (required).</param>
        /// <param name="time">共享操作的时间(unix utc ns) (required).</param>
        /// <param name="type">此条消息的类型  1. 开启共享  2. 关闭共享  3. 设置所有者  4. 取消所有者  5. 开启共享申请  6. 关闭共享申请  7. 设置所有者申请  8. 取消所有者申请  9. 开启外链申请  10. 开启共享审核结果  11. 关闭共享审核结果  12. 开启所有者审核结果  13. 关闭所有者审核结果  14. 开启外链审核结果  15. 待审流程消息  16. 流程进度消息   17. 流程结果消息  18. 简单消息  19. 提交密级申请消息  20. 密级申请审核结果  21. 隔离消息  22. 隔离被还原消息  23. 杀毒消息  24. 创建文档收集任务消息  25. 文档收发变更消息  26. 文档收发提醒消息  27. 取消文档收发任务消息  28. 文件到期通知消息  29. 短信验证码发送  30. 继承变更申请消息  31. 继承变更审核结果 (required).</param>
        /// <param name="url">内链，相对地址 (required).</param>
        /// <param name="auditmsg">审核意见 (required).</param>
        /// <param name="auditorname">审核员名字 (required).</param>
        /// <param name="auditresult">审核结果 true表示通过 false表示拒绝 (required).</param>
        /// <param name="docaudittype">审核模式 (required).</param>
        /// <param name="nextauditor">下一级审核员名称 (required).</param>
        /// <param name="nextlevel">下一级审核员级别 (required).</param>
        /// <param name="processname">文档流程名称 (required).</param>
        public MessageGetResMsgType16(string accessorname = default(string), AccessortypeEnum accessortype = default(AccessortypeEnum), long? csf = default(long?), string id = default(string), bool? isdir = default(bool?), bool? isread = default(bool?), string sender = default(string), long? time = default(long?), long? type = default(long?), string url = default(string), string auditmsg = default(string), string auditorname = default(string), bool? auditresult = default(bool?), long? docaudittype = default(long?), string nextauditor = default(string), long? nextlevel = default(long?), string processname = default(string))
        {
            this.Accessorname = accessorname;
            this.Accessortype = accessortype;
            this.Csf = csf;
            this.Id = id;
            this.Isdir = isdir;
            this.Isread = isread;
            this.Sender = sender;
            this.Time = time;
            this.Type = type;
            this.Url = url;
            this.Auditmsg = auditmsg;
            this.Auditorname = auditorname;
            this.Auditresult = auditresult;
            this.Docaudittype = docaudittype;
            this.Nextauditor = nextauditor;
            this.Nextlevel = nextlevel;
            this.Processname = processname;
        }
        
        /// <summary>
        /// 接收者名字，如果是外链，为空字符串
        /// </summary>
        /// <value>接收者名字，如果是外链，为空字符串</value>
        [DataMember(Name="accessorname", EmitDefaultValue=false)]
        public string Accessorname { get; set; }


        /// <summary>
        /// 文件密级，5~15，文件夹为0
        /// </summary>
        /// <value>文件密级，5~15，文件夹为0</value>
        [DataMember(Name="csf", EmitDefaultValue=false)]
        public long? Csf { get; set; }

        /// <summary>
        /// 此条消息的唯一标识
        /// </summary>
        /// <value>此条消息的唯一标识</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// 是否为文件夹
        /// </summary>
        /// <value>是否为文件夹</value>
        [DataMember(Name="isdir", EmitDefaultValue=false)]
        public bool? Isdir { get; set; }

        /// <summary>
        /// 消息是否已读
        /// </summary>
        /// <value>消息是否已读</value>
        [DataMember(Name="isread", EmitDefaultValue=false)]
        public bool? Isread { get; set; }

        /// <summary>
        /// 发送者名字
        /// </summary>
        /// <value>发送者名字</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// 共享操作的时间(unix utc ns)
        /// </summary>
        /// <value>共享操作的时间(unix utc ns)</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public long? Time { get; set; }

        /// <summary>
        /// 此条消息的类型  1. 开启共享  2. 关闭共享  3. 设置所有者  4. 取消所有者  5. 开启共享申请  6. 关闭共享申请  7. 设置所有者申请  8. 取消所有者申请  9. 开启外链申请  10. 开启共享审核结果  11. 关闭共享审核结果  12. 开启所有者审核结果  13. 关闭所有者审核结果  14. 开启外链审核结果  15. 待审流程消息  16. 流程进度消息   17. 流程结果消息  18. 简单消息  19. 提交密级申请消息  20. 密级申请审核结果  21. 隔离消息  22. 隔离被还原消息  23. 杀毒消息  24. 创建文档收集任务消息  25. 文档收发变更消息  26. 文档收发提醒消息  27. 取消文档收发任务消息  28. 文件到期通知消息  29. 短信验证码发送  30. 继承变更申请消息  31. 继承变更审核结果
        /// </summary>
        /// <value>此条消息的类型  1. 开启共享  2. 关闭共享  3. 设置所有者  4. 取消所有者  5. 开启共享申请  6. 关闭共享申请  7. 设置所有者申请  8. 取消所有者申请  9. 开启外链申请  10. 开启共享审核结果  11. 关闭共享审核结果  12. 开启所有者审核结果  13. 关闭所有者审核结果  14. 开启外链审核结果  15. 待审流程消息  16. 流程进度消息   17. 流程结果消息  18. 简单消息  19. 提交密级申请消息  20. 密级申请审核结果  21. 隔离消息  22. 隔离被还原消息  23. 杀毒消息  24. 创建文档收集任务消息  25. 文档收发变更消息  26. 文档收发提醒消息  27. 取消文档收发任务消息  28. 文件到期通知消息  29. 短信验证码发送  30. 继承变更申请消息  31. 继承变更审核结果</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public long? Type { get; set; }

        /// <summary>
        /// 内链，相对地址
        /// </summary>
        /// <value>内链，相对地址</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// 审核意见
        /// </summary>
        /// <value>审核意见</value>
        [DataMember(Name="auditmsg", EmitDefaultValue=false)]
        public string Auditmsg { get; set; }

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
        /// 审核模式
        /// </summary>
        /// <value>审核模式</value>
        [DataMember(Name="docaudittype", EmitDefaultValue=false)]
        public long? Docaudittype { get; set; }

        /// <summary>
        /// 下一级审核员名称
        /// </summary>
        /// <value>下一级审核员名称</value>
        [DataMember(Name="nextauditor", EmitDefaultValue=false)]
        public string Nextauditor { get; set; }

        /// <summary>
        /// 下一级审核员级别
        /// </summary>
        /// <value>下一级审核员级别</value>
        [DataMember(Name="nextlevel", EmitDefaultValue=false)]
        public long? Nextlevel { get; set; }

        /// <summary>
        /// 文档流程名称
        /// </summary>
        /// <value>文档流程名称</value>
        [DataMember(Name="processname", EmitDefaultValue=false)]
        public string Processname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageGetResMsgType16 {\n");
            sb.Append("  Accessorname: ").Append(Accessorname).Append("\n");
            sb.Append("  Accessortype: ").Append(Accessortype).Append("\n");
            sb.Append("  Csf: ").Append(Csf).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Isdir: ").Append(Isdir).Append("\n");
            sb.Append("  Isread: ").Append(Isread).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Auditmsg: ").Append(Auditmsg).Append("\n");
            sb.Append("  Auditorname: ").Append(Auditorname).Append("\n");
            sb.Append("  Auditresult: ").Append(Auditresult).Append("\n");
            sb.Append("  Docaudittype: ").Append(Docaudittype).Append("\n");
            sb.Append("  Nextauditor: ").Append(Nextauditor).Append("\n");
            sb.Append("  Nextlevel: ").Append(Nextlevel).Append("\n");
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
            return this.Equals(input as MessageGetResMsgType16);
        }

        /// <summary>
        /// Returns true if MessageGetResMsgType16 instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageGetResMsgType16 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageGetResMsgType16 input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Csf == input.Csf ||
                    (this.Csf != null &&
                    this.Csf.Equals(input.Csf))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Isdir == input.Isdir ||
                    (this.Isdir != null &&
                    this.Isdir.Equals(input.Isdir))
                ) && 
                (
                    this.Isread == input.Isread ||
                    (this.Isread != null &&
                    this.Isread.Equals(input.Isread))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Auditmsg == input.Auditmsg ||
                    (this.Auditmsg != null &&
                    this.Auditmsg.Equals(input.Auditmsg))
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
                    this.Docaudittype == input.Docaudittype ||
                    (this.Docaudittype != null &&
                    this.Docaudittype.Equals(input.Docaudittype))
                ) && 
                (
                    this.Nextauditor == input.Nextauditor ||
                    (this.Nextauditor != null &&
                    this.Nextauditor.Equals(input.Nextauditor))
                ) && 
                (
                    this.Nextlevel == input.Nextlevel ||
                    (this.Nextlevel != null &&
                    this.Nextlevel.Equals(input.Nextlevel))
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
                if (this.Accessorname != null)
                    hashCode = hashCode * 59 + this.Accessorname.GetHashCode();
                if (this.Accessortype != null)
                    hashCode = hashCode * 59 + this.Accessortype.GetHashCode();
                if (this.Csf != null)
                    hashCode = hashCode * 59 + this.Csf.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Isdir != null)
                    hashCode = hashCode * 59 + this.Isdir.GetHashCode();
                if (this.Isread != null)
                    hashCode = hashCode * 59 + this.Isread.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Auditmsg != null)
                    hashCode = hashCode * 59 + this.Auditmsg.GetHashCode();
                if (this.Auditorname != null)
                    hashCode = hashCode * 59 + this.Auditorname.GetHashCode();
                if (this.Auditresult != null)
                    hashCode = hashCode * 59 + this.Auditresult.GetHashCode();
                if (this.Docaudittype != null)
                    hashCode = hashCode * 59 + this.Docaudittype.GetHashCode();
                if (this.Nextauditor != null)
                    hashCode = hashCode * 59 + this.Nextauditor.GetHashCode();
                if (this.Nextlevel != null)
                    hashCode = hashCode * 59 + this.Nextlevel.GetHashCode();
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
