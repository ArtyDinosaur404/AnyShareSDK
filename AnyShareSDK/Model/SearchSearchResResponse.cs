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
    /// 文档相关信息和下次请求的边界值
    /// </summary>
    [DataContract]
    public partial class SearchSearchResResponse :  IEquatable<SearchSearchResResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSearchResResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchSearchResResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSearchResResponse" /> class.
        /// </summary>
        /// <param name="next">返回下次发起请求的start (required).</param>
        /// <param name="docs">返回各个文档的信息 (required).</param>
        /// <param name="hits">返回检索命中总数（查询第一页时返回）.</param>
        public SearchSearchResResponse(string next = default(string), List<SearchSearchResResponseDoc> docs = default(List<SearchSearchResResponseDoc>), long? hits = default(long?))
        {
            this.Next = next;
            this.Docs = docs;
            this.Hits = hits;
        }
        
        /// <summary>
        /// 返回下次发起请求的start
        /// </summary>
        /// <value>返回下次发起请求的start</value>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }

        /// <summary>
        /// 返回各个文档的信息
        /// </summary>
        /// <value>返回各个文档的信息</value>
        [DataMember(Name="docs", EmitDefaultValue=false)]
        public List<SearchSearchResResponseDoc> Docs { get; set; }

        /// <summary>
        /// 返回检索命中总数（查询第一页时返回）
        /// </summary>
        /// <value>返回检索命中总数（查询第一页时返回）</value>
        [DataMember(Name="hits", EmitDefaultValue=false)]
        public long? Hits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchSearchResResponse {\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Docs: ").Append(Docs).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
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
            return this.Equals(input as SearchSearchResResponse);
        }

        /// <summary>
        /// Returns true if SearchSearchResResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchSearchResResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchSearchResResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                ) && 
                (
                    this.Docs == input.Docs ||
                    this.Docs != null &&
                    input.Docs != null &&
                    this.Docs.SequenceEqual(input.Docs)
                ) && 
                (
                    this.Hits == input.Hits ||
                    (this.Hits != null &&
                    this.Hits.Equals(input.Hits))
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
                if (this.Next != null)
                    hashCode = hashCode * 59 + this.Next.GetHashCode();
                if (this.Docs != null)
                    hashCode = hashCode * 59 + this.Docs.GetHashCode();
                if (this.Hits != null)
                    hashCode = hashCode * 59 + this.Hits.GetHashCode();
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
