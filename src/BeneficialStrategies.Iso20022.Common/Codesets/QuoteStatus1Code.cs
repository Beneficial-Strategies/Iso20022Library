// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the status of a quote acknowledgement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZYQG0tp-Ed-ak6NoX_4Aeg_-363697938")]
[Description(@"Identifies the status of a quote acknowledgement.")]
[DerivedFrom(typeof(QuoteStatusCode))]
public enum QuoteStatus1Code
{
    /// <summary>
    /// Indicates that the quote is accepted for further negotiation.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_ZYQG09p-Ed-ak6NoX_4Aeg_710683030")]
    [Description(@"Indicates that the quote is accepted for further negotiation.")]
    Accepted = QuoteStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that all quotes are cancelled for a financial instrument&apos;s symbol.
    /// Encoded/decoded by serializers as &quot;SYMB&quot;.
    /// </summary>
    [EnumMember(Value = "SYMB")]
    [IsoId("_ZYQG1Np-Ed-ak6NoX_4Aeg_710683065")]
    [Description(@"Indicates that all quotes are cancelled for a financial instrument's symbol.")]
    CancelSymbol = QuoteStatusCode.CancelSymbol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that all quotes are cancelled for a specific security.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_ZYQG1dp-Ed-ak6NoX_4Aeg_710683125")]
    [Description(@"Indicates that all quotes are cancelled for a specific security.")]
    CancelSecurity = QuoteStatusCode.CancelSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that all quotes are cancelled for an underlying financial instrument.
    /// Encoded/decoded by serializers as &quot;UNSY&quot;.
    /// </summary>
    [EnumMember(Value = "UNSY")]
    [IsoId("_ZYQG1tp-Ed-ak6NoX_4Aeg_710683160")]
    [Description(
        @"Indicates that all quotes are cancelled for an underlying financial instrument."
    )]
    CancelUnderlying = QuoteStatusCode.CancelUnderlying, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that all quotes are cancelled.
    /// Encoded/decoded by serializers as &quot;ALLE&quot;.
    /// </summary>
    [EnumMember(Value = "ALLE")]
    [IsoId("_ZYQG19p-Ed-ak6NoX_4Aeg_710683437")]
    [Description(@"Indicates that all quotes are cancelled.")]
    CancelAll = QuoteStatusCode.CancelAll, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the quote is not accepted.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZYQG2Np-Ed-ak6NoX_4Aeg_710683472")]
    [Description(@"Indicates that the quote is not accepted.")]
    Rejected = QuoteStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that all quotes are removed from the market.
    /// Encoded/decoded by serializers as &quot;REMO&quot;.
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("_ZYQG2dp-Ed-ak6NoX_4Aeg_710683917")]
    [Description(@"Indicates that all quotes are removed from the market.")]
    RemovedFromMarket = QuoteStatusCode.RemovedFromMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the quote is not valid anymore.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_ZYZ30Np-Ed-ak6NoX_4Aeg_710683977")]
    [Description(@"Indicates that the quote is not valid anymore.")]
    Expired = QuoteStatusCode.Expired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the quote is being requested.
    /// Encoded/decoded by serializers as &quot;QUER&quot;.
    /// </summary>
    [EnumMember(Value = "QUER")]
    [IsoId("_ZYZ30dp-Ed-ak6NoX_4Aeg_710684012")]
    [Description(@"Indicates that the quote is being requested.")]
    Query = QuoteStatusCode.Query, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that no quote can be computed or communicated.
    /// Encoded/decoded by serializers as &quot;NQUO&quot;.
    /// </summary>
    [EnumMember(Value = "NQUO")]
    [IsoId("_ZYZ30tp-Ed-ak6NoX_4Aeg_710684013")]
    [Description(@"Indicates that no quote can be computed or communicated.")]
    QuoteNotFound = QuoteStatusCode.QuoteNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the quote is being processed.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZYZ309p-Ed-ak6NoX_4Aeg_710684030")]
    [Description(@"Indicates that the quote is being processed.")]
    Pending = QuoteStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the counterparty is not interested in the transaction.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_ZYZ31Np-Ed-ak6NoX_4Aeg_710684055")]
    [Description(@"Indicates that the counterparty is not interested in the transaction.")]
    Pass = QuoteStatusCode.Pass, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Warning due to a situation of locked market.
    /// Encoded/decoded by serializers as &quot;LMWA&quot;.
    /// </summary>
    [EnumMember(Value = "LMWA")]
    [IsoId("_ZYZ31dp-Ed-ak6NoX_4Aeg_710684072")]
    [Description(@"Warning due to a situation of locked market.")]
    LockedMarketWarning = QuoteStatusCode.LockedMarketWarning, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Warning due to a situation of cross market.
    /// Encoded/decoded by serializers as &quot;CMWA&quot;.
    /// </summary>
    [EnumMember(Value = "CMWA")]
    [IsoId("_ZYZ31tp-Ed-ak6NoX_4Aeg_710684115")]
    [Description(@"Warning due to a situation of cross market.")]
    CrossMarketWarning = QuoteStatusCode.CrossMarketWarning, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the quote is canceled due to a situation of locked market.
    /// Encoded/decoded by serializers as &quot;CDLM&quot;.
    /// </summary>
    [EnumMember(Value = "CDLM")]
    [IsoId("_ZYZ319p-Ed-ak6NoX_4Aeg_710684132")]
    [Description(@"Indicates that the quote is canceled due to a situation of locked market.")]
    CanceledDueToLockMarket = QuoteStatusCode.CanceledDueToLockMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the quote is canceled due to a situation of cross market.
    /// Encoded/decoded by serializers as &quot;CDCM&quot;.
    /// </summary>
    [EnumMember(Value = "CDCM")]
    [IsoId("_ZYZ32Np-Ed-ak6NoX_4Aeg_710684150")]
    [Description(@"Indicates that the quote is canceled due to a situation of cross market.")]
    CanceledDueToCrossMarket = QuoteStatusCode.CanceledDueToCrossMarket, // same ordinal as derivation source for type conversions
}
