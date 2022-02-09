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
    /// Auth1ExtloginclientReq
    /// </summary>
    [DataContract]
    public partial class Auth1ExtloginclientReq :  IEquatable<Auth1ExtloginclientReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1ExtloginclientReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Auth1ExtloginclientReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1ExtloginclientReq" /> class.
        /// </summary>
        /// <param name="account">用户登录账号（不能使用admin登录） (required).</param>
        /// <param name="appid">爱数分配给第三方系统的应用id (required).</param>
        /// <param name="key">组合appid，appkey，account后进行md5算法后得到（不区分大小写）  例如：  appid&#x3D;eisoo  appkey&#x3D;ae217ce4-bf33-11e9-aa67-665056af7572  account&#x3D;xiaoming  key&#x3D;md5(eisooae217ce4-bf33-11e9-aa67-665056af7572xiaoming) (required).</param>
        /// <param name="deviceinfo">deviceinfo.</param>
        public Auth1ExtloginclientReq(string account = default(string), string appid = default(string), string key = default(string), Auth1ExtloginclientReqDeviceinfo deviceinfo = default(Auth1ExtloginclientReqDeviceinfo))
        {
            this.Account = account;
            this.Appid = appid;
            this.Key = key;
            this.Deviceinfo = deviceinfo;
        }
        
        /// <summary>
        /// 用户登录账号（不能使用admin登录）
        /// </summary>
        /// <value>用户登录账号（不能使用admin登录）</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// 爱数分配给第三方系统的应用id
        /// </summary>
        /// <value>爱数分配给第三方系统的应用id</value>
        [DataMember(Name="appid", EmitDefaultValue=false)]
        public string Appid { get; set; }

        /// <summary>
        /// 组合appid，appkey，account后进行md5算法后得到（不区分大小写）  例如：  appid&#x3D;eisoo  appkey&#x3D;ae217ce4-bf33-11e9-aa67-665056af7572  account&#x3D;xiaoming  key&#x3D;md5(eisooae217ce4-bf33-11e9-aa67-665056af7572xiaoming)
        /// </summary>
        /// <value>组合appid，appkey，account后进行md5算法后得到（不区分大小写）  例如：  appid&#x3D;eisoo  appkey&#x3D;ae217ce4-bf33-11e9-aa67-665056af7572  account&#x3D;xiaoming  key&#x3D;md5(eisooae217ce4-bf33-11e9-aa67-665056af7572xiaoming)</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Deviceinfo
        /// </summary>
        [DataMember(Name="deviceinfo", EmitDefaultValue=false)]
        public Auth1ExtloginclientReqDeviceinfo Deviceinfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Auth1ExtloginclientReq {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Appid: ").Append(Appid).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Deviceinfo: ").Append(Deviceinfo).Append("\n");
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
            return this.Equals(input as Auth1ExtloginclientReq);
        }

        /// <summary>
        /// Returns true if Auth1ExtloginclientReq instances are equal
        /// </summary>
        /// <param name="input">Instance of Auth1ExtloginclientReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Auth1ExtloginclientReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Appid == input.Appid ||
                    (this.Appid != null &&
                    this.Appid.Equals(input.Appid))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Deviceinfo == input.Deviceinfo ||
                    (this.Deviceinfo != null &&
                    this.Deviceinfo.Equals(input.Deviceinfo))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Appid != null)
                    hashCode = hashCode * 59 + this.Appid.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Deviceinfo != null)
                    hashCode = hashCode * 59 + this.Deviceinfo.GetHashCode();
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
