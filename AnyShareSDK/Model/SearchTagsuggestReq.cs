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
    /// SearchTagsuggestReq
    /// </summary>
    [DataContract]
    public partial class SearchTagsuggestReq :  IEquatable<SearchTagsuggestReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTagsuggestReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchTagsuggestReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTagsuggestReq" /> class.
        /// </summary>
        /// <param name="count">需要建议的最大返回个数，大于0，默认是10.</param>
        /// <param name="prefix">需要建议的标签前缀，不能为空 (required).</param>
        public SearchTagsuggestReq(long? count = default(long?), string prefix = default(string))
        {
            this.Prefix = prefix;
            this.Count = count;
        }
        
        /// <summary>
        /// 需要建议的最大返回个数，大于0，默认是10
        /// </summary>
        /// <value>需要建议的最大返回个数，大于0，默认是10</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// 需要建议的标签前缀，不能为空
        /// </summary>
        /// <value>需要建议的标签前缀，不能为空</value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchTagsuggestReq {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
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
            return this.Equals(input as SearchTagsuggestReq);
        }

        /// <summary>
        /// Returns true if SearchTagsuggestReq instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchTagsuggestReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchTagsuggestReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
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
