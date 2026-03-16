// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the status of a quote acknowledgement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZYZ32dp-Ed-ak6NoX_4Aeg_-1173342394")]
[Description(@"Identifies the status of a quote acknowledgement.")]
[DerivedFrom(typeof(QuoteStatusCode))]
public enum QuoteStatus2Code
{
    /// <summary>
    /// Indicates that all quotes are cancelled for a financial instrument&apos;s symbol.
    /// Encoded/decoded by serializers as &quot;SYMB&quot;.
    /// </summary>
    [EnumMember(Value = "SYMB")]
    [IsoId("_ZYjBwNp-Ed-ak6NoX_4Aeg_-1041278909")]
    [Description(@"Indicates that all quotes are cancelled for a financial instrument's symbol.")]
    CancelSymbol = QuoteStatusCode.CancelSymbol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that all quotes are cancelled for a specific security.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_ZYjBwdp-Ed-ak6NoX_4Aeg_-1041278866")]
    [Description(@"Indicates that all quotes are cancelled for a specific security.")]
    CancelSecurity = QuoteStatusCode.CancelSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that all quotes are cancelled for an underlying financial instrument.
    /// Encoded/decoded by serializers as &quot;UNSY&quot;.
    /// </summary>
    [EnumMember(Value = "UNSY")]
    [IsoId("_ZYjBwtp-Ed-ak6NoX_4Aeg_-1041278806")]
    [Description(
        @"Indicates that all quotes are cancelled for an underlying financial instrument."
    )]
    CancelUnderlying = QuoteStatusCode.CancelUnderlying, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that all quotes are cancelled.
    /// Encoded/decoded by serializers as &quot;ALLE&quot;.
    /// </summary>
    [EnumMember(Value = "ALLE")]
    [IsoId("_ZYjBw9p-Ed-ak6NoX_4Aeg_-1041278771")]
    [Description(@"Indicates that all quotes are cancelled.")]
    CancelAll = QuoteStatusCode.CancelAll, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that no quote can be computed or communicated.
    /// Encoded/decoded by serializers as &quot;NQUO&quot;.
    /// </summary>
    [EnumMember(Value = "NQUO")]
    [IsoId("_ZYjBxNp-Ed-ak6NoX_4Aeg_-799316486")]
    [Description(@"Indicates that no quote can be computed or communicated.")]
    QuoteNotFound = QuoteStatusCode.QuoteNotFound, // same ordinal as derivation source for type conversions
}
