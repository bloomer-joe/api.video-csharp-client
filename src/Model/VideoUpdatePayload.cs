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
  public class VideoUpdatePayload: DeepObject   {

    [DataMember(Name="playerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playerId")]
    public OptionalNullable<string> playerid_optional { get; set; } = null;

    /// <summary>
    /// The unique ID for the player you want to associate with your video.
    /// </summary>
    /// <value>The unique ID for the player you want to associate with your video.</value>
    public string playerid
    {
        get
        {
            return this.playerid_optional != null ? this.playerid_optional.value : null;
        }

        set
        {
            this.playerid_optional = new OptionalNullable<string>(value);
        }
    }

        /// <summary>
    /// The title you want to use for your video.
    /// </summary>
    /// <value>The title you want to use for your video.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string title { get; set; }
    /// <summary>
    /// A brief description of the video.
    /// </summary>
    /// <value>A brief description of the video.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string description { get; set; }
    /// <summary>
    /// Whether the video is publicly available or not. False means it is set to private. Default is true. Tutorials on [private videos](https://api.video/blog/endpoints/private-videos/).
    /// </summary>
    /// <value>Whether the video is publicly available or not. False means it is set to private. Default is true. Tutorials on [private videos](https://api.video/blog/endpoints/private-videos/).</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public Nullable<bool> _public { get; set; }
    /// <summary>
    /// Whether the video is a 360 degree or immersive video.
    /// </summary>
    /// <value>Whether the video is a 360 degree or immersive video.</value>
    [DataMember(Name="panoramic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "panoramic")]
    public Nullable<bool> panoramic { get; set; }
    /// <summary>
    /// Whether the player supports the mp4 format.
    /// </summary>
    /// <value>Whether the player supports the mp4 format.</value>
    [DataMember(Name="mp4Support", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mp4Support")]
    public Nullable<bool> mp4support { get; set; }
    /// <summary>
    /// A list of terms or words you want to tag the video with. Make sure the list includes all the tags you want as whatever you send in this list will overwrite the existing list for the video.
    /// </summary>
    /// <value>A list of terms or words you want to tag the video with. Make sure the list includes all the tags you want as whatever you send in this list will overwrite the existing list for the video.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> tags { get; set; }
    /// <summary>
    /// A list (array) of dictionaries where each dictionary contains a key value pair that describes the video. As with tags, you must send the complete list of metadata you want as whatever you send here will overwrite the existing metadata for the video.
    /// </summary>
    /// <value>A list (array) of dictionaries where each dictionary contains a key value pair that describes the video. As with tags, you must send the complete list of metadata you want as whatever you send here will overwrite the existing metadata for the video.</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public List<Metadata> metadata { get; set; }
    /// <summary>
    /// Use this parameter to set the language of the video. When this parameter is set, the API creates a transcript of the video using the language you specify. You must use the [IETF language tag](https://en.wikipedia.org/wiki/IETF_language_tag) format.  `language` is a permanent attribute of the video. You can update it to another language using the [`PATCH /videos/{videoId}`](https://docs.api.video/reference/api/Videos#update-a-video-object) operation. This triggers the API to generate a new transcript using a different language.
    /// </summary>
    /// <value>Use this parameter to set the language of the video. When this parameter is set, the API creates a transcript of the video using the language you specify. You must use the [IETF language tag](https://en.wikipedia.org/wiki/IETF_language_tag) format.  `language` is a permanent attribute of the video. You can update it to another language using the [`PATCH /videos/{videoId}`](https://docs.api.video/reference/api/Videos#update-a-video-object) operation. This triggers the API to generate a new transcript using a different language.</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string language { get; set; }
    /// <summary>
    /// Use this parameter to enable transcription.   - When `true`, the API generates a transcript for the video. - The default value is `false`. - If you define a video language using the `language` parameter, the API uses that language to transcribe the video. If you do not define a language, the API detects it based on the video.  - When the API generates a transcript, it will be available as a caption for the video.
    /// </summary>
    /// <value>Use this parameter to enable transcription.   - When `true`, the API generates a transcript for the video. - The default value is `false`. - If you define a video language using the `language` parameter, the API uses that language to transcribe the video. If you do not define a language, the API detects it based on the video.  - When the API generates a transcript, it will be available as a caption for the video.</value>
    [DataMember(Name="transcript", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transcript")]
    public Nullable<bool> transcript { get; set; }
    /// <summary>
    /// Use this parameter to enable summarization.   - When `true`, the API generates a summary for the video, based on the transcription. - The default value is `false`. - If you define a video language using the `language` parameter, the API uses that language to summarize the video. If you do not define a language, the API detects it based on the video.
    /// </summary>
    /// <value>Use this parameter to enable summarization.   - When `true`, the API generates a summary for the video, based on the transcription. - The default value is `false`. - If you define a video language using the `language` parameter, the API uses that language to summarize the video. If you do not define a language, the API detects it based on the video.</value>
    [DataMember(Name="transcriptSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transcriptSummary")]
    public Nullable<bool> transcriptsummary { get; set; }
    /// <summary>
    /// Use this parameter to define the elements of a summary that you want to generate. If you do not define this parameter, the API generates a full summary with all attributes. The possible values are `abstract` and `takeaways`.
    /// </summary>
    /// <value>Use this parameter to define the elements of a summary that you want to generate. If you do not define this parameter, the API generates a full summary with all attributes. The possible values are `abstract` and `takeaways`.</value>
    [DataMember(Name="transcriptSummaryAttributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transcriptSummaryAttributes")]
    public List<string> transcriptsummaryattributes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoUpdatePayload {\n");
      sb.Append("  PlayerId: ").Append(playerid).Append("\n");
      sb.Append("  Title: ").Append(title).Append("\n");
      sb.Append("  Description: ").Append(description).Append("\n");
      sb.Append("  Public: ").Append(_public).Append("\n");
      sb.Append("  Panoramic: ").Append(panoramic).Append("\n");
      sb.Append("  Mp4Support: ").Append(mp4support).Append("\n");
      sb.Append("  Tags: ").Append(tags).Append("\n");
      sb.Append("  Metadata: ").Append(metadata).Append("\n");
      sb.Append("  Language: ").Append(language).Append("\n");
      sb.Append("  Transcript: ").Append(transcript).Append("\n");
      sb.Append("  TranscriptSummary: ").Append(transcriptsummary).Append("\n");
      sb.Append("  TranscriptSummaryAttributes: ").Append(transcriptsummaryattributes).Append("\n");
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
