// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Message format.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8r6YYHr5EeSZrs_hiwNOWA")]
[Description(@"Message format.")]
[DerivedFrom(typeof(OutputFormatCode))]
public enum OutputFormat1Code
{
    /// <summary>
    /// Predefined configured messages, identified by a reference.
    /// Encoded/decoded by serializers as &quot;MREF&quot;.
    /// </summary>
    [EnumMember(Value = "MREF")]
    [IsoId("_-Q8cgXr5EeSZrs_hiwNOWA")]
    [Description(@"Predefined configured messages, identified by a reference.")]
    MessageReference = OutputFormatCode.MessageReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Text without format attributes.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_-m43UXr5EeSZrs_hiwNOWA")]
    [Description(@"Text without format attributes.")]
    SimpleText = OutputFormatCode.SimpleText, // same ordinal as derivation source for type conversions

    /// <summary>
    /// XHTML document which includes a subset of the XHTML output tag.
    /// Encoded/decoded by serializers as &quot;HTML&quot;.
    /// </summary>
    [EnumMember(Value = "HTML")]
    [IsoId("_-sGugXr5EeSZrs_hiwNOWA")]
    [Description(@"XHTML document which includes a subset of the XHTML output tag.")]
    XHTML = OutputFormatCode.XHTML, // same ordinal as derivation source for type conversions
}
