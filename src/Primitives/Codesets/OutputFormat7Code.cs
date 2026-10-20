// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the format of the data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GQcvAXFXEfC68Y4jZPNEug")]
[Description(@"Specifies the format of the data.")]
[DerivedFrom(typeof(OutputFormatCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<OutputFormat7Code>))]
public enum OutputFormat7Code
{
    /// <summary>
    /// Comma separated value format.
    /// Encoded/decoded by serializers as &quot;CSVF&quot;.
    /// </summary>
    [EnumMember(Value = "CSVF")]
    [IsoId("_GTCJA3FXEfC68Y4jZPNEug")]
    [Description(@"Comma separated value format.")]
    CSV = OutputFormatCode.CSV, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic data interchange for administration, commerce and transport.
    /// Encoded/decoded by serializers as &quot;EDIF&quot;.
    /// </summary>
    [EnumMember(Value = "EDIF")]
    [IsoId("_GTCJAXFXEfC68Y4jZPNEug")]
    [Description(
        @"Electronic data interchange for administration, commerce and transport."
    )]
    EDIFACT = OutputFormatCode.EDIFACT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// XHTML document which includes a subset of the XHTML output tag.
    /// Encoded/decoded by serializers as &quot;HTML&quot;.
    /// </summary>
    [EnumMember(Value = "HTML")]
    [IsoId("_GTCI-XFXEfC68Y4jZPNEug")]
    [Description(@"XHTML document which includes a subset of the XHTML output tag.")]
    XHTML = OutputFormatCode.XHTML, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Joint Photographic Experts Group format.
    /// Encoded/decoded by serializers as &quot;JPEG&quot;.
    /// </summary>
    [EnumMember(Value = "JPEG")]
    [IsoId("_GTCJBXFXEfC68Y4jZPNEug")]
    [Description(@"Joint Photographic Experts Group format.")]
    JPEG = OutputFormatCode.JPEG, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Java Syntax Object Notation format.
    /// Encoded/decoded by serializers as &quot;JSON&quot;.
    /// </summary>
    [EnumMember(Value = "JSON")]
    [IsoId("_GTCI_XFXEfC68Y4jZPNEug")]
    [Description(@"Java Syntax Object Notation format.")]
    JSON = OutputFormatCode.JSON, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Portable Document Format.
    /// Encoded/decoded by serializers as &quot;PDFF&quot;.
    /// </summary>
    [EnumMember(Value = "PDFF")]
    [IsoId("_GTCJB3FXEfC68Y4jZPNEug")]
    [Description(@"Portable Document Format.")]
    PDF = OutputFormatCode.PDF, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A formatted print line.
    /// Encoded/decoded by serializers as &quot;PLIN&quot;.
    /// </summary>
    [EnumMember(Value = "PLIN")]
    [IsoId("_GTCI-3FXEfC68Y4jZPNEug")]
    [Description(@"A formatted print line.")]
    PrintLine = OutputFormatCode.PrintLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Portable Network Graphics format.
    /// Encoded/decoded by serializers as &quot;PNGF&quot;.
    /// </summary>
    [EnumMember(Value = "PNGF")]
    [IsoId("_GTCJCXFXEfC68Y4jZPNEug")]
    [Description(@"Portable Network Graphics format.")]
    PNG = OutputFormatCode.PNG, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scalable vector graphic format.
    /// Encoded/decoded by serializers as &quot;SVGF&quot;.
    /// </summary>
    [EnumMember(Value = "SVGF")]
    [IsoId("_GTCJC3FXEfC68Y4jZPNEug")]
    [Description(@"Scalable vector graphic format.")]
    SVG = OutputFormatCode.SVG, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Text without format attributes.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_GTCI9XFXEfC68Y4jZPNEug")]
    [Description(@"Text without format attributes.")]
    SimpleText = OutputFormatCode.SimpleText, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Uniform Resource Locator (URL) reference for the message.
    /// Encoded/decoded by serializers as &quot;URLI&quot;.
    /// </summary>
    [EnumMember(Value = "URLI")]
    [IsoId("_GTCI93FXEfC68Y4jZPNEug")]
    [Description(@"Uniform Resource Locator (URL) reference for the message.")]
    UniformResourceLocator = OutputFormatCode.UniformResourceLocator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// eXtensible Markup Language format.
    /// Encoded/decoded by serializers as &quot;XMLF&quot;.
    /// </summary>
    [EnumMember(Value = "XMLF")]
    [IsoId("_GTCI_3FXEfC68Y4jZPNEug")]
    [Description(@"eXtensible Markup Language format.")]
    XML = OutputFormatCode.XML, // same ordinal as derivation source for type conversions
}
