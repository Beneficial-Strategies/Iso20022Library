// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the format of the data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_M3WN8MlUEeuJ35KoBRZFOg")]
[Description(@"Specifies the format of the data.")]
[DerivedFrom(typeof(OutputFormatCode))]
public enum OutputFormat5Code
{
    /// <summary>
    /// Other type of output of message defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_bKsXwclUEeuJ35KoBRZFOg")]
    [Description(@"Other type of output of message defined at national level.")]
    OtherNational = OutputFormatCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of output format defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_btaqUclUEeuJ35KoBRZFOg")]
    [Description(@"Other type of output format defined at private level.")]
    OtherPrivate = OutputFormatCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Text without format attributes.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_hhloYslUEeuJ35KoBRZFOg")]
    [Description(@"Text without format attributes.")]
    SimpleText = OutputFormatCode.SimpleText, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Uniform Resource Locator (URL) reference for the message.
    /// Encoded/decoded by serializers as &quot;URLI&quot;.
    /// </summary>
    [EnumMember(Value = "URLI")]
    [IsoId("_iCEfQclUEeuJ35KoBRZFOg")]
    [Description(@"Uniform Resource Locator (URL) reference for the message.")]
    UniformResourceLocator = OutputFormatCode.UniformResourceLocator, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// XHTML document which includes a subset of the XHTML output tag.
    /// Encoded/decoded by serializers as &quot;HTML&quot;.
    /// </summary>
    [EnumMember(Value = "HTML")]
    [IsoId("_qSpOUslUEeuJ35KoBRZFOg")]
    [Description(@"XHTML document which includes a subset of the XHTML output tag.")]
    XHTML = OutputFormatCode.XHTML, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A formatted print line.
    /// Encoded/decoded by serializers as &quot;PLIN&quot;.
    /// </summary>
    [EnumMember(Value = "PLIN")]
    [IsoId("_rjgZQslUEeuJ35KoBRZFOg")]
    [Description(@"A formatted print line.")]
    PrintLine = OutputFormatCode.PrintLine, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Java Syntax Object Notation format.
    /// Encoded/decoded by serializers as &quot;JSON&quot;.
    /// </summary>
    [EnumMember(Value = "JSON")]
    [IsoId("_uDqB0slUEeuJ35KoBRZFOg")]
    [Description(@"Java Syntax Object Notation format.")]
    JSON = OutputFormatCode.JSON, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// eXtensible Markup Language format.
    /// Encoded/decoded by serializers as &quot;XMLF&quot;.
    /// </summary>
    [EnumMember(Value = "XMLF")]
    [IsoId("_ulcgQclUEeuJ35KoBRZFOg")]
    [Description(@"eXtensible Markup Language format.")]
    XML = OutputFormatCode.XML, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic data interchange for administration, commerce and transport.
    /// Encoded/decoded by serializers as &quot;EDIF&quot;.
    /// </summary>
    [EnumMember(Value = "EDIF")]
    [IsoId("_viTKEslUEeuJ35KoBRZFOg")]
    [Description(@"Electronic data interchange for administration, commerce and transport.")]
    EDIFACT = OutputFormatCode.EDIFACT, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Comma separated value format.
    /// Encoded/decoded by serializers as &quot;CSVF&quot;.
    /// </summary>
    [EnumMember(Value = "CSVF")]
    [IsoId("_wd9hEslUEeuJ35KoBRZFOg")]
    [Description(@"Comma separated value format.")]
    CSV = OutputFormatCode.CSV, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Joint Photographic Experts Group format.
    /// Encoded/decoded by serializers as &quot;JPEG&quot;.
    /// </summary>
    [EnumMember(Value = "JPEG")]
    [IsoId("_w_v_gMlUEeuJ35KoBRZFOg")]
    [Description(@"Joint Photographic Experts Group format.")]
    JPEG = OutputFormatCode.JPEG, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Portable Document Format.
    /// Encoded/decoded by serializers as &quot;PDFF&quot;.
    /// </summary>
    [EnumMember(Value = "PDFF")]
    [IsoId("_x23NsslUEeuJ35KoBRZFOg")]
    [Description(@"Portable Document Format.")]
    PDF = OutputFormatCode.PDF, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Portable Network Graphics format.
    /// Encoded/decoded by serializers as &quot;PNGF&quot;.
    /// </summary>
    [EnumMember(Value = "PNGF")]
    [IsoId("_yYLLAclUEeuJ35KoBRZFOg")]
    [Description(@"Portable Network Graphics format.")]
    PNG = OutputFormatCode.PNG, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scalable vector graphic format.
    /// Encoded/decoded by serializers as &quot;SVGF&quot;.
    /// </summary>
    [EnumMember(Value = "SVGF")]
    [IsoId("_0G8Z8slUEeuJ35KoBRZFOg")]
    [Description(@"Scalable vector graphic format.")]
    SVG = OutputFormatCode.SVG, // same ordinal as derivation source for type conversions
    
}
