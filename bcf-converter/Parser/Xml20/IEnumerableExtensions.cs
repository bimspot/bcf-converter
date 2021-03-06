using System.Collections.Generic;
using System.Xml.Linq;
using bcf_converter.Model;

namespace bcf_converter.Parser.Xml20 {
  /// <summary>
  ///   A list of convenience extension methods on the IEnumerable interface
  ///   where the items in the list are of `XElement` class.
  ///   The BCF version specific parsing logic is defined here.
  /// </summary>
  public static class IEnumerableExtensions {
    /// <summary>
    ///   Creates a list of Components using the data in the list of XElements.
    /// </summary>
    /// <param name="items">
    ///   A list of XElement's with the component elements in XML.
    /// </param>
    /// <returns>Returns a list of Component instances.</returns>
    public static List<Component> componentList(
      this IEnumerable<XElement> items) {
      var list = new List<Component>();
      foreach (var xElement in items)
        list.Add(new Component {
          ifcGuid = xElement.Attribute("IfcGuid")?.Value,
          authoringToolId = xElement.Element("AuthoringToolId")?.Value,
          originatingSystem = xElement.Element("OriginatingSystem")?.Value
        });
      return list;
    }
  }
}