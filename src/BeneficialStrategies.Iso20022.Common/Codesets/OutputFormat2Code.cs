// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information format.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iMwOkIqHEeSRT5rEzcAHEw")]
[Description(@"Information format.")]
[DerivedFrom(typeof(OutputFormatCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OutputFormat2Code>))]
#endif
public enum OutputFormat2Code
{
    /// <summary>
    /// Predefined configured messages, identified by a reference.
    /// Encoded/decoded by serializers as &quot;MREF&quot;.
    /// </summary>
    [EnumMember(Value = "MREF")]
    [IsoId("_lPN6AYqHEeSRT5rEzcAHEw")]
    [Description(@"Predefined configured messages, identified by a reference.")]
    MessageReference = OutputFormatCode.MessageReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Screen to display identified by a reference.
    /// Encoded/decoded by serializers as &quot;SREF&quot;.
    /// </summary>
    [EnumMember(Value = "SREF")]
    [IsoId("_lUIPMYqHEeSRT5rEzcAHEw")]
    [Description(@"Screen to display identified by a reference.")]
    ScreenReference = OutputFormatCode.ScreenReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Text without format attributes.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_lY5acYqHEeSRT5rEzcAHEw")]
    [Description(@"Text without format attributes.")]
    SimpleText = OutputFormatCode.SimpleText, // same ordinal as derivation source for type conversions

    /// <summary>
    /// XHTML document which includes a subset of the XHTML output tag.
    /// Encoded/decoded by serializers as &quot;HTML&quot;.
    /// </summary>
    [EnumMember(Value = "HTML")]
    [IsoId("_ld0WsYqHEeSRT5rEzcAHEw")]
    [Description(@"XHTML document which includes a subset of the XHTML output tag.")]
    XHTML = OutputFormatCode.XHTML, // same ordinal as derivation source for type conversions
}
