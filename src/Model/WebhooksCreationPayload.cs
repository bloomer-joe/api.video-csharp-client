using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WebhooksCreationPayload: DeepObject   {
    /// <summary>
    /// An array of webhook events that you want to subscribe to.
    /// </summary>
    /// <value>An array of webhook events that you want to subscribe to.</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<string> events { get; set; }
    /// <summary>
    /// The the url to which HTTP notifications are sent. It could be any http or https URL.
    /// </summary>
    /// <value>The the url to which HTTP notifications are sent. It could be any http or https URL.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebhooksCreationPayload {\n");
      sb.Append("  Events: ").Append(events).Append("\n");
      sb.Append("  Url: ").Append(url).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

}
}
