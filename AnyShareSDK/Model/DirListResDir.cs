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
    /// DirListResDir
    /// </summary>
    [DataContract]
    public partial class DirListResDir :  IEquatable<DirListResDir>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirListResDir" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DirListResDir() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DirListResDir" /> class.
        /// </summary>
        /// <param name="docid">目录中文件/目录的gns路径 (required).</param>
        /// <param name="name">目录中文件/目录的名称，UTF8编码 (required).</param>
        /// <param name="rev">目录中文件版本号或目录数据变化标识 (required).</param>
        /// <param name="size">目录中文件的大小，目录大小为-1 (required).</param>
        /// <param name="createTime">目录/文件创建的服务端时间 (required).</param>
        /// <param name="creator">目录/文件创建者 (required).</param>
        /// <param name="modified">目录修改时间/文件上传时间，UTC时间，此为文件上传到服务器时间 (required).</param>
        /// <param name="editor">目录修改者/文件编辑者 (required).</param>
        /// <param name="clientMtime">如果是文件，返回由客户端设置的文件本地修改时间    若未设置，返回modified的值  .</param>
        /// <param name="csflevel">文件密级  - 0：默认值，创建文件时文件密级设为创建者密级，覆盖版本时不改变密级  - 5~15：正常密级  - 0x7FFF：空密级   (required).</param>
        /// <param name="attr">总共32位，右下角表示最低位，左上角表示最高位，如：    0&lt;sub&gt;32&lt;/sub&gt;000,0000,0000,0000&lt;sub&gt;17&lt;/sub&gt;    0&lt;sub&gt;16&lt;/sub&gt;000,0000,0000,0000&lt;sub&gt;1&lt;/sub&gt;  - 1：只读（用户针对访问对象是否是只读属性）  - 2：锁定（表示访问对象是否被锁定）  - 3：允许显示  - 4：拒绝显示  - 5：允许预览  - 6：拒绝预览  - 7：允许下载  - 8：拒绝下载  - 9：允许新建  - 10：拒绝新建  - 11：允许修改  - 12：拒绝修改  - 13：允许删除  - 14：拒绝删除  - 15：允许复制  - 16：拒绝复制     第25位到28位表示该用户的密级    可能为以下值：    0101(5)~1111(15)    attr中带上用户的密级是方便客户端探测到用户的密级变化，从而探测到新的文件（因为密级变大或者变小，看到的文件会变多或变少）  .</param>
        /// <param name="duedate">文件到期提醒时间 (required).</param>
        public DirListResDir(string docid = default(string), string name = default(string), string rev = default(string), long? size = default(long?), long? createTime = default(long?), string creator = default(string), long? modified = default(long?), string editor = default(string), long? clientMtime = default(long?), long? csflevel = default(long?), long? attr = default(long?), long? duedate = default(long?))
        {
            this.Docid = docid;
            this.Name = name;
            this.Rev = rev;
            this.Size = size;
            this.CreateTime = createTime;
            this.Creator = creator;
            this.Modified = modified;
            this.Editor = editor;
            this.Csflevel = csflevel;
            this.Duedate = duedate;
            this.ClientMtime = clientMtime;
            this.Attr = attr;
        }
        
        /// <summary>
        /// 目录中文件/目录的gns路径
        /// </summary>
        /// <value>目录中文件/目录的gns路径</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 目录中文件/目录的名称，UTF8编码
        /// </summary>
        /// <value>目录中文件/目录的名称，UTF8编码</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 目录中文件版本号或目录数据变化标识
        /// </summary>
        /// <value>目录中文件版本号或目录数据变化标识</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public string Rev { get; set; }

        /// <summary>
        /// 目录中文件的大小，目录大小为-1
        /// </summary>
        /// <value>目录中文件的大小，目录大小为-1</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// 目录/文件创建的服务端时间
        /// </summary>
        /// <value>目录/文件创建的服务端时间</value>
        [DataMember(Name="create_time", EmitDefaultValue=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 目录/文件创建者
        /// </summary>
        /// <value>目录/文件创建者</value>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public string Creator { get; set; }

        /// <summary>
        /// 目录修改时间/文件上传时间，UTC时间，此为文件上传到服务器时间
        /// </summary>
        /// <value>目录修改时间/文件上传时间，UTC时间，此为文件上传到服务器时间</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public long? Modified { get; set; }

        /// <summary>
        /// 目录修改者/文件编辑者
        /// </summary>
        /// <value>目录修改者/文件编辑者</value>
        [DataMember(Name="editor", EmitDefaultValue=false)]
        public string Editor { get; set; }

        /// <summary>
        /// 如果是文件，返回由客户端设置的文件本地修改时间    若未设置，返回modified的值  
        /// </summary>
        /// <value>如果是文件，返回由客户端设置的文件本地修改时间    若未设置，返回modified的值  </value>
        [DataMember(Name="client_mtime", EmitDefaultValue=false)]
        public long? ClientMtime { get; set; }

        /// <summary>
        /// 文件密级  - 0：默认值，创建文件时文件密级设为创建者密级，覆盖版本时不改变密级  - 5~15：正常密级  - 0x7FFF：空密级  
        /// </summary>
        /// <value>文件密级  - 0：默认值，创建文件时文件密级设为创建者密级，覆盖版本时不改变密级  - 5~15：正常密级  - 0x7FFF：空密级  </value>
        [DataMember(Name="csflevel", EmitDefaultValue=false)]
        public long? Csflevel { get; set; }

        /// <summary>
        /// 总共32位，右下角表示最低位，左上角表示最高位，如：    0&lt;sub&gt;32&lt;/sub&gt;000,0000,0000,0000&lt;sub&gt;17&lt;/sub&gt;    0&lt;sub&gt;16&lt;/sub&gt;000,0000,0000,0000&lt;sub&gt;1&lt;/sub&gt;  - 1：只读（用户针对访问对象是否是只读属性）  - 2：锁定（表示访问对象是否被锁定）  - 3：允许显示  - 4：拒绝显示  - 5：允许预览  - 6：拒绝预览  - 7：允许下载  - 8：拒绝下载  - 9：允许新建  - 10：拒绝新建  - 11：允许修改  - 12：拒绝修改  - 13：允许删除  - 14：拒绝删除  - 15：允许复制  - 16：拒绝复制     第25位到28位表示该用户的密级    可能为以下值：    0101(5)~1111(15)    attr中带上用户的密级是方便客户端探测到用户的密级变化，从而探测到新的文件（因为密级变大或者变小，看到的文件会变多或变少）  
        /// </summary>
        /// <value>总共32位，右下角表示最低位，左上角表示最高位，如：    0&lt;sub&gt;32&lt;/sub&gt;000,0000,0000,0000&lt;sub&gt;17&lt;/sub&gt;    0&lt;sub&gt;16&lt;/sub&gt;000,0000,0000,0000&lt;sub&gt;1&lt;/sub&gt;  - 1：只读（用户针对访问对象是否是只读属性）  - 2：锁定（表示访问对象是否被锁定）  - 3：允许显示  - 4：拒绝显示  - 5：允许预览  - 6：拒绝预览  - 7：允许下载  - 8：拒绝下载  - 9：允许新建  - 10：拒绝新建  - 11：允许修改  - 12：拒绝修改  - 13：允许删除  - 14：拒绝删除  - 15：允许复制  - 16：拒绝复制     第25位到28位表示该用户的密级    可能为以下值：    0101(5)~1111(15)    attr中带上用户的密级是方便客户端探测到用户的密级变化，从而探测到新的文件（因为密级变大或者变小，看到的文件会变多或变少）  </value>
        [DataMember(Name="attr", EmitDefaultValue=false)]
        public long? Attr { get; set; }

        /// <summary>
        /// 文件到期提醒时间
        /// </summary>
        /// <value>文件到期提醒时间</value>
        [DataMember(Name="duedate", EmitDefaultValue=false)]
        public long? Duedate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirListResDir {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Editor: ").Append(Editor).Append("\n");
            sb.Append("  ClientMtime: ").Append(ClientMtime).Append("\n");
            sb.Append("  Csflevel: ").Append(Csflevel).Append("\n");
            sb.Append("  Attr: ").Append(Attr).Append("\n");
            sb.Append("  Duedate: ").Append(Duedate).Append("\n");
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
            return this.Equals(input as DirListResDir);
        }

        /// <summary>
        /// Returns true if DirListResDir instances are equal
        /// </summary>
        /// <param name="input">Instance of DirListResDir to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirListResDir input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Rev == input.Rev ||
                    (this.Rev != null &&
                    this.Rev.Equals(input.Rev))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.Editor == input.Editor ||
                    (this.Editor != null &&
                    this.Editor.Equals(input.Editor))
                ) && 
                (
                    this.ClientMtime == input.ClientMtime ||
                    (this.ClientMtime != null &&
                    this.ClientMtime.Equals(input.ClientMtime))
                ) && 
                (
                    this.Csflevel == input.Csflevel ||
                    (this.Csflevel != null &&
                    this.Csflevel.Equals(input.Csflevel))
                ) && 
                (
                    this.Attr == input.Attr ||
                    (this.Attr != null &&
                    this.Attr.Equals(input.Attr))
                ) && 
                (
                    this.Duedate == input.Duedate ||
                    (this.Duedate != null &&
                    this.Duedate.Equals(input.Duedate))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Rev != null)
                    hashCode = hashCode * 59 + this.Rev.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Editor != null)
                    hashCode = hashCode * 59 + this.Editor.GetHashCode();
                if (this.ClientMtime != null)
                    hashCode = hashCode * 59 + this.ClientMtime.GetHashCode();
                if (this.Csflevel != null)
                    hashCode = hashCode * 59 + this.Csflevel.GetHashCode();
                if (this.Attr != null)
                    hashCode = hashCode * 59 + this.Attr.GetHashCode();
                if (this.Duedate != null)
                    hashCode = hashCode * 59 + this.Duedate.GetHashCode();
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
