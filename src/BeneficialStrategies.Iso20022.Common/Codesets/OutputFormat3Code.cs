// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of output format.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sseY0NuXEeiB5uLfkg9ZJA")]
[Description(@"Type of output format.")]
[DerivedFrom(typeof(OutputFormatCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OutputFormat3Code>))]
#endif
public enum OutputFormat3Code
{
    /// <summary>
    /// Barcode to output in several possible format.
    /// Encoded/decoded by serializers as &quot;BARC&quot;.
    /// </summary>
    [EnumMember(Value = "BARC")]
    [IsoId("_A6E6kduYEeiB5uLfkg9ZJA")]
    [Description(@"Barcode to output in several possible format.")]
    Barcode = OutputFormatCode.Barcode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A text to display as a menu before requesting an input.
    /// Encoded/decoded by serializers as &quot;MENT&quot;.
    /// </summary>
    [EnumMember(Value = "MENT")]
    [IsoId("_A-QP8duYEeiB5uLfkg9ZJA")]
    [Description(@"A text to display as a menu before requesting an input.")]
    MenuEntry = OutputFormatCode.MenuEntry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Predefined configured messages, identified by a reference.
    /// Encoded/decoded by serializers as &quot;MREF&quot;.
    /// </summary>
    [EnumMember(Value = "MREF")]
    [IsoId("_BFHF4duYEeiB5uLfkg9ZJA")]
    [Description(@"Predefined configured messages, identified by a reference.")]
    MessageReference = OutputFormatCode.MessageReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Screen to display identified by a reference.
    /// Encoded/decoded by serializers as &quot;SREF&quot;.
    /// </summary>
    [EnumMember(Value = "SREF")]
    [IsoId("_CYgAYduYEeiB5uLfkg9ZJA")]
    [Description(@"Screen to display identified by a reference.")]
    ScreenReference = OutputFormatCode.ScreenReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Text without format attributes.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_CfgAQduYEeiB5uLfkg9ZJA")]
    [Description(@"Text without format attributes.")]
    SimpleText = OutputFormatCode.SimpleText, // same ordinal as derivation source for type conversions

    /// <summary>
    /// XHTML document which includes a subset of the XHTML output tag.
    /// Encoded/decoded by serializers as &quot;HTML&quot;.
    /// </summary>
    [EnumMember(Value = "HTML")]
    [IsoId("_CmojAduYEeiB5uLfkg9ZJA")]
    [Description(@"XHTML document which includes a subset of the XHTML output tag.")]
    XHTML = OutputFormatCode.XHTML, // same ordinal as derivation source for type conversions
}
