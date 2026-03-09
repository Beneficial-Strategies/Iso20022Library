// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Available message format to display or print.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tW6kUHr5EeSZrs_hiwNOWA")]
[Description(@"Available message format to display or print.")]
[Derivations(typeof(OutputFormat5Code),typeof(OutputFormat2Code),typeof(OutputFormat3Code),typeof(OutputFormat1Code),typeof(OutputFormat4Code))]
public enum OutputFormatCode
{
    /// <summary>
    /// Text without format attributes.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_yWkVMHr5EeSZrs_hiwNOWA")]
    [Description(@"Text without format attributes.")]
    SimpleText,
    
    /// <summary>
    /// Predefined configured messages, identified by a reference.
    /// Encoded/decoded by serializers as &quot;MREF&quot;.
    /// </summary>
    [EnumMember(Value = "MREF")]
    [IsoId("_2CqzgHr5EeSZrs_hiwNOWA")]
    [Description(@"Predefined configured messages, identified by a reference.")]
    MessageReference,
    
    /// <summary>
    /// XHTML document which includes a subset of the XHTML output tag.
    /// Encoded/decoded by serializers as &quot;HTML&quot;.
    /// </summary>
    [EnumMember(Value = "HTML")]
    [IsoId("_4w1C4Hr5EeSZrs_hiwNOWA")]
    [Description(@"XHTML document which includes a subset of the XHTML output tag.")]
    XHTML,
    
    /// <summary>
    /// Screen to display identified by a reference.
    /// Encoded/decoded by serializers as &quot;SREF&quot;.
    /// </summary>
    [EnumMember(Value = "SREF")]
    [IsoId("_aR8PAM4xEeSiNPH-YrkZ3A")]
    [Description(@"Screen to display identified by a reference.")]
    ScreenReference,
    
    /// <summary>
    /// Barcode to output in several possible format.
    /// Encoded/decoded by serializers as &quot;BARC&quot;.
    /// </summary>
    [EnumMember(Value = "BARC")]
    [IsoId("_XlImcGpUEemFuJNacM8hZA")]
    [Description(@"Barcode to output in several possible format.")]
    Barcode,
    
    /// <summary>
    /// A text to display as a menu before requesting an input.
    /// Encoded/decoded by serializers as &quot;MENT&quot;.
    /// </summary>
    [EnumMember(Value = "MENT")]
    [IsoId("_d3t-0GpUEemFuJNacM8hZA")]
    [Description(@"A text to display as a menu before requesting an input.")]
    MenuEntry,
    
    /// <summary>
    /// File name and location identification for stored messages or data.
    /// Encoded/decoded by serializers as &quot;FLNM&quot;.
    /// </summary>
    [EnumMember(Value = "FLNM")]
    [IsoId("_JtYkFnyKEemHsOqJOzMVfg")]
    [Description(@"File name and location identification for stored messages or data.")]
    FileName,
    
    /// <summary>
    /// Multi-media messaging service
    /// Encoded/decoded by serializers as &quot;MMSI&quot;.
    /// </summary>
    [EnumMember(Value = "MMSI")]
    [IsoId("_JtYkF3yKEemHsOqJOzMVfg")]
    [Description(@"Multi-media messaging service")]
    MultiMediaMessaging,
    
    /// <summary>
    /// Other type of output of message defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_JtYkGHyKEemHsOqJOzMVfg")]
    [Description(@"Other type of output of message defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of output format defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_JtYkGXyKEemHsOqJOzMVfg")]
    [Description(@"Other type of output format defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Short message service
    /// Encoded/decoded by serializers as &quot;SMSI&quot;.
    /// </summary>
    [EnumMember(Value = "SMSI")]
    [IsoId("_JtYkGnyKEemHsOqJOzMVfg")]
    [Description(@"Short message service")]
    ShortMessageService,
    
    /// <summary>
    /// Uniform Resource Locator (URL) reference for the message.
    /// Encoded/decoded by serializers as &quot;URLI&quot;.
    /// </summary>
    [EnumMember(Value = "URLI")]
    [IsoId("_JtYkG3yKEemHsOqJOzMVfg")]
    [Description(@"Uniform Resource Locator (URL) reference for the message.")]
    UniformResourceLocator,
    
    /// <summary>
    /// A formatted print line.
    /// Encoded/decoded by serializers as &quot;PLIN&quot;.
    /// </summary>
    [EnumMember(Value = "PLIN")]
    [IsoId("_nbH5gMlSEeuJ35KoBRZFOg")]
    [Description(@"A formatted print line.")]
    PrintLine,
    
    /// <summary>
    /// Java Syntax Object Notation format.
    /// Encoded/decoded by serializers as &quot;JSON&quot;.
    /// </summary>
    [EnumMember(Value = "JSON")]
    [IsoId("_1NF0kMlSEeuJ35KoBRZFOg")]
    [Description(@"Java Syntax Object Notation format.")]
    JSON,
    
    /// <summary>
    /// eXtensible Markup Language format.
    /// Encoded/decoded by serializers as &quot;XMLF&quot;.
    /// </summary>
    [EnumMember(Value = "XMLF")]
    [IsoId("_8nMOoMlSEeuJ35KoBRZFOg")]
    [Description(@"eXtensible Markup Language format.")]
    XML,
    
    /// <summary>
    /// Electronic data interchange for administration, commerce and transport.
    /// Encoded/decoded by serializers as &quot;EDIF&quot;.
    /// </summary>
    [EnumMember(Value = "EDIF")]
    [IsoId("_MV-bsMlTEeuJ35KoBRZFOg")]
    [Description(@"Electronic data interchange for administration, commerce and transport.")]
    EDIFACT,
    
    /// <summary>
    /// Comma separated value format.
    /// Encoded/decoded by serializers as &quot;CSVF&quot;.
    /// </summary>
    [EnumMember(Value = "CSVF")]
    [IsoId("_YZZKQMlTEeuJ35KoBRZFOg")]
    [Description(@"Comma separated value format.")]
    CSV,
    
    /// <summary>
    /// Joint Photographic Experts Group format.
    /// Encoded/decoded by serializers as &quot;JPEG&quot;.
    /// </summary>
    [EnumMember(Value = "JPEG")]
    [IsoId("_dkt_oMlTEeuJ35KoBRZFOg")]
    [Description(@"Joint Photographic Experts Group format.")]
    JPEG,
    
    /// <summary>
    /// Portable Document Format.
    /// Encoded/decoded by serializers as &quot;PDFF&quot;.
    /// </summary>
    [EnumMember(Value = "PDFF")]
    [IsoId("_xskesMlTEeuJ35KoBRZFOg")]
    [Description(@"Portable Document Format.")]
    PDF,
    
    /// <summary>
    /// Portable Network Graphics format.
    /// Encoded/decoded by serializers as &quot;PNGF&quot;.
    /// </summary>
    [EnumMember(Value = "PNGF")]
    [IsoId("_3DW9MMlTEeuJ35KoBRZFOg")]
    [Description(@"Portable Network Graphics format.")]
    PNG,
    
    /// <summary>
    /// Scalable vector graphic format.
    /// Encoded/decoded by serializers as &quot;SVGF&quot;.
    /// </summary>
    [EnumMember(Value = "SVGF")]
    [IsoId("_BhESMMlUEeuJ35KoBRZFOg")]
    [Description(@"Scalable vector graphic format.")]
    SVG,
    
}
