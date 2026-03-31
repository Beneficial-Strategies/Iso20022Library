// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Output of message format.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ApRasE0yEeea0Mdu1TOzDQ")]
[Description(@"Output of message format.")]
[DerivedFrom(typeof(OutputFormatCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OutputFormat4Code>))]
#endif
public enum OutputFormat4Code
{
    /// <summary>
    /// File name and location identification for stored messages or data.
    /// Encoded/decoded by serializers as &quot;FLNM&quot;.
    /// </summary>
    [EnumMember(Value = "FLNM")]
    [IsoId("_zz2zIX0lEemfrNOe0zHQyg")]
    [Description(@"File name and location identification for stored messages or data.")]
    FileName = OutputFormatCode.FileName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Predefined configured messages, identified by a reference.
    /// Encoded/decoded by serializers as &quot;MREF&quot;.
    /// </summary>
    [EnumMember(Value = "MREF")]
    [IsoId("_zz2zI30lEemfrNOe0zHQyg")]
    [Description(@"Predefined configured messages, identified by a reference.")]
    MessageReference = OutputFormatCode.MessageReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of output of message defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_zz2zJX0lEemfrNOe0zHQyg")]
    [Description(@"Other type of output of message defined at national level.")]
    OtherNational = OutputFormatCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of output format defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_zz2zJ30lEemfrNOe0zHQyg")]
    [Description(@"Other type of output format defined at private level.")]
    OtherPrivate = OutputFormatCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Short message service
    /// Encoded/decoded by serializers as &quot;SMSI&quot;.
    /// </summary>
    [EnumMember(Value = "SMSI")]
    [IsoId("_zz2zKX0lEemfrNOe0zHQyg")]
    [Description(@"Short message service")]
    ShortMessageService = OutputFormatCode.ShortMessageService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Text without format attributes.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_zz2zK30lEemfrNOe0zHQyg")]
    [Description(@"Text without format attributes.")]
    SimpleText = OutputFormatCode.SimpleText, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Uniform Resource Locator (URL) reference for the message.
    /// Encoded/decoded by serializers as &quot;URLI&quot;.
    /// </summary>
    [EnumMember(Value = "URLI")]
    [IsoId("_zz2zLX0lEemfrNOe0zHQyg")]
    [Description(@"Uniform Resource Locator (URL) reference for the message.")]
    UniformResourceLocator = OutputFormatCode.UniformResourceLocator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// XHTML document which includes a subset of the XHTML output tag.
    /// Encoded/decoded by serializers as &quot;HTML&quot;.
    /// </summary>
    [EnumMember(Value = "HTML")]
    [IsoId("_zz2zL30lEemfrNOe0zHQyg")]
    [Description(@"XHTML document which includes a subset of the XHTML output tag.")]
    XHTML = OutputFormatCode.XHTML, // same ordinal as derivation source for type conversions
}
