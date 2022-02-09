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
    /// SearchSearchReq
    /// </summary>
    [DataContract]
    public partial class SearchSearchReq :  IEquatable<SearchSearchReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSearchReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchSearchReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSearchReq" /> class.
        /// </summary>
        /// <param name="customattr">自定义属性搜索条件数组.</param>
        /// <param name="ext">搜索匹配后缀，以点开头（例如”.doc”）.</param>
        /// <param name="keys">搜索关键字  默认按照短语搜索，需要单独搜索的关键字用“%20”分割  .</param>
        /// <param name="range">指定的某个目录下，具体为gns路径（例如gns://XXX/_*），  搜索所有目录：传空  搜索某个目录及子目录：gns://XXX/_*  搜索仅某个目录下文件：gns://XXX/  .</param>
        /// <param name="rows">请求返回的查询记录条数，如果返回的条数少于当前值，则表示服务端已无更多数据无需再取 (required).</param>
        /// <param name="start">第一页从0开始，往后的页传入回复消息中的next (required).</param>
        /// <param name="tags">欲搜索的标签字符串数组.</param>
        /// <param name="hl">是否需要返回高亮内容，默认true   返回形式：\&quot;&lt;em&gt;&lt;/em&gt;\&quot;  .</param>
        /// <param name="style">为0，查找range下的有权限文件  为1，查找range下有权限文件和发现共享文件  为2，查找range下的发现共享文件  .</param>
        /// <param name="doctype">为1，查找文件  为2，查找文件夹  为3，查找文件&amp;文件夹  默认3  .</param>
        /// <param name="keysfields">搜索关键字所在字段（仅当keys不为空时有效），数组中有效元素为”basename”,”content”。 [”basename”]表示匹配文件名；[”content”]表示匹配文件内容；[”basename”, ”content”]表示匹配全文.</param>
        /// <param name="sort">排序规则：默认为按相关度排序  按文件大小升序为”size”,降序为”-size”；  按修改时间升序为”modified”,降序为”-modified”；  按创建时间升序为”created”,降序为”-created”；  .</param>
        /// <param name="size">size.</param>
        /// <param name="createtime">createtime.</param>
        /// <param name="modifytime">modifytime.</param>
        public SearchSearchReq(List<SearchSearchReqCustomattr> customattr = default(List<SearchSearchReqCustomattr>), List<string> ext = default(List<string>), string keys = default(string), List<string> range = default(List<string>), long? rows = default(long?), long? start = default(long?), List<string> tags = default(List<string>), bool? hl = default(bool?), long? style = default(long?), long? doctype = default(long?), List<string> keysfields = default(List<string>), string sort = default(string), SearchSearchReqSize size = default(SearchSearchReqSize), SearchSearchReqCreatetime createtime = default(SearchSearchReqCreatetime), SearchSearchReqModifytime modifytime = default(SearchSearchReqModifytime))
        {
            this.Rows = rows;
            this.Start = start;
            this.Customattr = customattr;
            this.Ext = ext;
            this.Keys = keys;
            this.Range = range;
            this.Tags = tags;
            this.Hl = hl;
            this.Style = style;
            this.Doctype = doctype;
            this.Keysfields = keysfields;
            this.Sort = sort;
            this.Size = size;
            this.Createtime = createtime;
            this.Modifytime = modifytime;
        }
        
        /// <summary>
        /// 自定义属性搜索条件数组
        /// </summary>
        /// <value>自定义属性搜索条件数组</value>
        [DataMember(Name="customattr", EmitDefaultValue=false)]
        public List<SearchSearchReqCustomattr> Customattr { get; set; }

        /// <summary>
        /// 搜索匹配后缀，以点开头（例如”.doc”）
        /// </summary>
        /// <value>搜索匹配后缀，以点开头（例如”.doc”）</value>
        [DataMember(Name="ext", EmitDefaultValue=false)]
        public List<string> Ext { get; set; }

        /// <summary>
        /// 搜索关键字  默认按照短语搜索，需要单独搜索的关键字用“%20”分割  
        /// </summary>
        /// <value>搜索关键字  默认按照短语搜索，需要单独搜索的关键字用“%20”分割  </value>
        [DataMember(Name="keys", EmitDefaultValue=false)]
        public string Keys { get; set; }

        /// <summary>
        /// 指定的某个目录下，具体为gns路径（例如gns://XXX/_*），  搜索所有目录：传空  搜索某个目录及子目录：gns://XXX/_*  搜索仅某个目录下文件：gns://XXX/  
        /// </summary>
        /// <value>指定的某个目录下，具体为gns路径（例如gns://XXX/_*），  搜索所有目录：传空  搜索某个目录及子目录：gns://XXX/_*  搜索仅某个目录下文件：gns://XXX/  </value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public List<string> Range { get; set; }

        /// <summary>
        /// 请求返回的查询记录条数，如果返回的条数少于当前值，则表示服务端已无更多数据无需再取
        /// </summary>
        /// <value>请求返回的查询记录条数，如果返回的条数少于当前值，则表示服务端已无更多数据无需再取</value>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public long? Rows { get; set; }

        /// <summary>
        /// 第一页从0开始，往后的页传入回复消息中的next
        /// </summary>
        /// <value>第一页从0开始，往后的页传入回复消息中的next</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public long? Start { get; set; }

        /// <summary>
        /// 欲搜索的标签字符串数组
        /// </summary>
        /// <value>欲搜索的标签字符串数组</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 是否需要返回高亮内容，默认true   返回形式：\&quot;&lt;em&gt;&lt;/em&gt;\&quot;  
        /// </summary>
        /// <value>是否需要返回高亮内容，默认true   返回形式：\&quot;&lt;em&gt;&lt;/em&gt;\&quot;  </value>
        [DataMember(Name="hl", EmitDefaultValue=false)]
        public bool? Hl { get; set; }

        /// <summary>
        /// 为0，查找range下的有权限文件  为1，查找range下有权限文件和发现共享文件  为2，查找range下的发现共享文件  
        /// </summary>
        /// <value>为0，查找range下的有权限文件  为1，查找range下有权限文件和发现共享文件  为2，查找range下的发现共享文件  </value>
        [DataMember(Name="style", EmitDefaultValue=false)]
        public long? Style { get; set; }

        /// <summary>
        /// 为1，查找文件  为2，查找文件夹  为3，查找文件&amp;文件夹  默认3  
        /// </summary>
        /// <value>为1，查找文件  为2，查找文件夹  为3，查找文件&amp;文件夹  默认3  </value>
        [DataMember(Name="doctype", EmitDefaultValue=false)]
        public long? Doctype { get; set; }

        /// <summary>
        /// 搜索关键字所在字段（仅当keys不为空时有效），数组中有效元素为”basename”,”content”。 [”basename”]表示匹配文件名；[”content”]表示匹配文件内容；[”basename”, ”content”]表示匹配全文
        /// </summary>
        /// <value>搜索关键字所在字段（仅当keys不为空时有效），数组中有效元素为”basename”,”content”。 [”basename”]表示匹配文件名；[”content”]表示匹配文件内容；[”basename”, ”content”]表示匹配全文</value>
        [DataMember(Name="keysfields", EmitDefaultValue=false)]
        public List<string> Keysfields { get; set; }

        /// <summary>
        /// 排序规则：默认为按相关度排序  按文件大小升序为”size”,降序为”-size”；  按修改时间升序为”modified”,降序为”-modified”；  按创建时间升序为”created”,降序为”-created”；  
        /// </summary>
        /// <value>排序规则：默认为按相关度排序  按文件大小升序为”size”,降序为”-size”；  按修改时间升序为”modified”,降序为”-modified”；  按创建时间升序为”created”,降序为”-created”；  </value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public string Sort { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public SearchSearchReqSize Size { get; set; }

        /// <summary>
        /// Gets or Sets Createtime
        /// </summary>
        [DataMember(Name="createtime", EmitDefaultValue=false)]
        public SearchSearchReqCreatetime Createtime { get; set; }

        /// <summary>
        /// Gets or Sets Modifytime
        /// </summary>
        [DataMember(Name="modifytime", EmitDefaultValue=false)]
        public SearchSearchReqModifytime Modifytime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchSearchReq {\n");
            sb.Append("  Customattr: ").Append(Customattr).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Hl: ").Append(Hl).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
            sb.Append("  Doctype: ").Append(Doctype).Append("\n");
            sb.Append("  Keysfields: ").Append(Keysfields).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Createtime: ").Append(Createtime).Append("\n");
            sb.Append("  Modifytime: ").Append(Modifytime).Append("\n");
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
            return this.Equals(input as SearchSearchReq);
        }

        /// <summary>
        /// Returns true if SearchSearchReq instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchSearchReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchSearchReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Customattr == input.Customattr ||
                    this.Customattr != null &&
                    input.Customattr != null &&
                    this.Customattr.SequenceEqual(input.Customattr)
                ) && 
                (
                    this.Ext == input.Ext ||
                    this.Ext != null &&
                    input.Ext != null &&
                    this.Ext.SequenceEqual(input.Ext)
                ) && 
                (
                    this.Keys == input.Keys ||
                    (this.Keys != null &&
                    this.Keys.Equals(input.Keys))
                ) && 
                (
                    this.Range == input.Range ||
                    this.Range != null &&
                    input.Range != null &&
                    this.Range.SequenceEqual(input.Range)
                ) && 
                (
                    this.Rows == input.Rows ||
                    (this.Rows != null &&
                    this.Rows.Equals(input.Rows))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Hl == input.Hl ||
                    (this.Hl != null &&
                    this.Hl.Equals(input.Hl))
                ) && 
                (
                    this.Style == input.Style ||
                    (this.Style != null &&
                    this.Style.Equals(input.Style))
                ) && 
                (
                    this.Doctype == input.Doctype ||
                    (this.Doctype != null &&
                    this.Doctype.Equals(input.Doctype))
                ) && 
                (
                    this.Keysfields == input.Keysfields ||
                    this.Keysfields != null &&
                    input.Keysfields != null &&
                    this.Keysfields.SequenceEqual(input.Keysfields)
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Createtime == input.Createtime ||
                    (this.Createtime != null &&
                    this.Createtime.Equals(input.Createtime))
                ) && 
                (
                    this.Modifytime == input.Modifytime ||
                    (this.Modifytime != null &&
                    this.Modifytime.Equals(input.Modifytime))
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
                if (this.Customattr != null)
                    hashCode = hashCode * 59 + this.Customattr.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                if (this.Keys != null)
                    hashCode = hashCode * 59 + this.Keys.GetHashCode();
                if (this.Range != null)
                    hashCode = hashCode * 59 + this.Range.GetHashCode();
                if (this.Rows != null)
                    hashCode = hashCode * 59 + this.Rows.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Hl != null)
                    hashCode = hashCode * 59 + this.Hl.GetHashCode();
                if (this.Style != null)
                    hashCode = hashCode * 59 + this.Style.GetHashCode();
                if (this.Doctype != null)
                    hashCode = hashCode * 59 + this.Doctype.GetHashCode();
                if (this.Keysfields != null)
                    hashCode = hashCode * 59 + this.Keysfields.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Createtime != null)
                    hashCode = hashCode * 59 + this.Createtime.GetHashCode();
                if (this.Modifytime != null)
                    hashCode = hashCode * 59 + this.Modifytime.GetHashCode();
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
