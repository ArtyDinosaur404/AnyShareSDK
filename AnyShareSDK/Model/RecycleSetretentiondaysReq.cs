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
    /// RecycleSetretentiondaysReq
    /// </summary>
    [DataContract]
    public partial class RecycleSetretentiondaysReq :  IEquatable<RecycleSetretentiondaysReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecycleSetretentiondaysReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecycleSetretentiondaysReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecycleSetretentiondaysReq" /> class.
        /// </summary>
        /// <param name="docid">个人文档或者文档库的gns路径 (required).</param>
        /// <param name="days">保留天数 (required).</param>
        public RecycleSetretentiondaysReq(string docid = default(string), long? days = default(long?))
        {
            this.Docid = docid;
            this.Days = days;
        }
        
        /// <summary>
        /// 个人文档或者文档库的gns路径
        /// </summary>
        /// <value>个人文档或者文档库的gns路径</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 保留天数
        /// </summary>
        /// <value>保留天数</value>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public long? Days { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecycleSetretentiondaysReq {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
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
            return this.Equals(input as RecycleSetretentiondaysReq);
        }

        /// <summary>
        /// Returns true if RecycleSetretentiondaysReq instances are equal
        /// </summary>
        /// <param name="input">Instance of RecycleSetretentiondaysReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecycleSetretentiondaysReq input)
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
                    this.Days == input.Days ||
                    (this.Days != null &&
                    this.Days.Equals(input.Days))
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
                if (this.Days != null)
                    hashCode = hashCode * 59 + this.Days.GetHashCode();
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
