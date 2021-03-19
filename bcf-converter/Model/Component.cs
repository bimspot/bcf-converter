using System.Text.Json.Serialization;

namespace bcf_converter.Model {
  /// <summary>
  ///   The Component describes a single building element.
  /// </summary>
  public struct Component {
    /// <summary>
    ///   A unique IfcGuid of the component.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("ifc_guid")]
    public string ifcGuid;

    /// <summary>
    ///   The name of the system in which the component is originated.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("originating_system")]
    public string originatingSystem;

    /// <summary>
    ///   System specific identifier of the component in the originating BIM
    ///   tool.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("authoring_tool_id")]
    public string authoringToolId;

    /// <summary>
    ///   Creates and returns an instance of the Component.
    /// </summary>
    /// <param name="ifcGuid">A unique IfcGuid of the component.</param>
    /// <param name="originatingSystem">
    ///   The name of the system in which the component is originated.
    /// </param>
    /// <param name="authoringToolId">
    ///   System specific identifier of the component in the originating BIM
    ///   tool.
    /// </param>
    public Component(string ifcGuid, string originatingSystem,
      string authoringToolId) {
      this.ifcGuid = ifcGuid;
      this.originatingSystem = originatingSystem;
      this.authoringToolId = authoringToolId;
    }
  }
}