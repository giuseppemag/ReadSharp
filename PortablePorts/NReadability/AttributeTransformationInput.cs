﻿using System.Xml.Linq;

namespace ReadSharp.Ports.NReadability
{
  public class AttributeTransformationInput
  {
    public string AttributeValue { get; set; }

    public XElement Element { get; set; }
  }
}
