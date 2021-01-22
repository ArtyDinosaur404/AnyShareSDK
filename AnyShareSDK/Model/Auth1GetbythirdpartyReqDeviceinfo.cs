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
    /// 设备信息
    /// </summary>
    [DataContract]
    public partial class Auth1GetbythirdpartyReqDeviceinfo :  IEquatable<Auth1GetbythirdpartyReqDeviceinfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetbythirdpartyReqDeviceinfo" /> class.
        /// </summary>
        /// <param name="name">设备名称.</param>
        /// <param name="ostype">操作系统类型  0：Unknown  1：IOS  2：Android  3：Windows phone  4：Windows  5：MacOSX  6：Web  7：MobileWeb.</param>
        /// <param name="devicetype">设备硬件类型，自定义。如：  iphone5s  ipad  联想一体机  mac.</param>
        /// <param name="udid">设备唯一标识号，  windows下取mac地址  ios取udid  web为空.</param>
        public Auth1GetbythirdpartyReqDeviceinfo(string name = default(string), long? ostype = default(long?), string devicetype = default(string), string udid = default(string))
        {
            this.Name = name;
            this.Ostype = ostype;
            this.Devicetype = devicetype;
            this.Udid = udid;
        }
        
        /// <summary>
        /// 设备名称
        /// </summary>
        /// <value>设备名称</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 操作系统类型  0：Unknown  1：IOS  2：Android  3：Windows phone  4：Windows  5：MacOSX  6：Web  7：MobileWeb
        /// </summary>
        /// <value>操作系统类型  0：Unknown  1：IOS  2：Android  3：Windows phone  4：Windows  5：MacOSX  6：Web  7：MobileWeb</value>
        [DataMember(Name="ostype", EmitDefaultValue=false)]
        public long? Ostype { get; set; }

        /// <summary>
        /// 设备硬件类型，自定义。如：  iphone5s  ipad  联想一体机  mac
        /// </summary>
        /// <value>设备硬件类型，自定义。如：  iphone5s  ipad  联想一体机  mac</value>
        [DataMember(Name="devicetype", EmitDefaultValue=false)]
        public string Devicetype { get; set; }

        /// <summary>
        /// 设备唯一标识号，  windows下取mac地址  ios取udid  web为空
        /// </summary>
        /// <value>设备唯一标识号，  windows下取mac地址  ios取udid  web为空</value>
        [DataMember(Name="udid", EmitDefaultValue=false)]
        public string Udid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Auth1GetbythirdpartyReqDeviceinfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ostype: ").Append(Ostype).Append("\n");
            sb.Append("  Devicetype: ").Append(Devicetype).Append("\n");
            sb.Append("  Udid: ").Append(Udid).Append("\n");
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
            return this.Equals(input as Auth1GetbythirdpartyReqDeviceinfo);
        }

        /// <summary>
        /// Returns true if Auth1GetbythirdpartyReqDeviceinfo instances are equal
        /// </summary>
        /// <param name="input">Instance of Auth1GetbythirdpartyReqDeviceinfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Auth1GetbythirdpartyReqDeviceinfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Ostype == input.Ostype ||
                    (this.Ostype != null &&
                    this.Ostype.Equals(input.Ostype))
                ) && 
                (
                    this.Devicetype == input.Devicetype ||
                    (this.Devicetype != null &&
                    this.Devicetype.Equals(input.Devicetype))
                ) && 
                (
                    this.Udid == input.Udid ||
                    (this.Udid != null &&
                    this.Udid.Equals(input.Udid))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Ostype != null)
                    hashCode = hashCode * 59 + this.Ostype.GetHashCode();
                if (this.Devicetype != null)
                    hashCode = hashCode * 59 + this.Devicetype.GetHashCode();
                if (this.Udid != null)
                    hashCode = hashCode * 59 + this.Udid.GetHashCode();
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
