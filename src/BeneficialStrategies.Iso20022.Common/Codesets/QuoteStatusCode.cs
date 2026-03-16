// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the status of a quote acknowledgement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZYjBxdp-Ed-ak6NoX_4Aeg_336258615")]
[Description(@"Identifies the status of a quote acknowledgement.")]
[Derivations(typeof(QuoteStatus1Code), typeof(QuoteStatus2Code))]
public enum QuoteStatusCode
{
    /// <summary>
    /// Indicates that the quote is accepted for further negotiation.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_ZYjBxtp-Ed-ak6NoX_4Aeg_336258616")]
    [Description(@"Indicates that the quote is accepted for further negotiation.")]
    Accepted,

    /// <summary>
    /// Indicates that all quotes are cancelled for a financial instrument&apos;s symbol.
    /// Encoded/decoded by serializers as &quot;SYMB&quot;.
    /// </summary>
    [EnumMember(Value = "SYMB")]
    [IsoId("_ZYjBx9p-Ed-ak6NoX_4Aeg_336258617")]
    [Description(@"Indicates that all quotes are cancelled for a financial instrument's symbol.")]
    CancelSymbol,

    /// <summary>
    /// Indicates that all quotes are cancelled for a specific security.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_ZYjByNp-Ed-ak6NoX_4Aeg_336258626")]
    [Description(@"Indicates that all quotes are cancelled for a specific security.")]
    CancelSecurity,

    /// <summary>
    /// Indicates that all quotes are cancelled for an underlying financial instrument.
    /// Encoded/decoded by serializers as &quot;UNSY&quot;.
    /// </summary>
    [EnumMember(Value = "UNSY")]
    [IsoId("_ZYsywNp-Ed-ak6NoX_4Aeg_336258627")]
    [Description(
        @"Indicates that all quotes are cancelled for an underlying financial instrument."
    )]
    CancelUnderlying,

    /// <summary>
    /// Indicates that all quotes are cancelled.
    /// Encoded/decoded by serializers as &quot;ALLE&quot;.
    /// </summary>
    [EnumMember(Value = "ALLE")]
    [IsoId("_ZYsywdp-Ed-ak6NoX_4Aeg_336258628")]
    [Description(@"Indicates that all quotes are cancelled.")]
    CancelAll,

    /// <summary>
    /// Indicates that the quote is not accepted.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZYsywtp-Ed-ak6NoX_4Aeg_336258629")]
    [Description(@"Indicates that the quote is not accepted.")]
    Rejected,

    /// <summary>
    /// Indicates that all quotes are removed from the market.
    /// Encoded/decoded by serializers as &quot;REMO&quot;.
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("_ZYsyw9p-Ed-ak6NoX_4Aeg_336258630")]
    [Description(@"Indicates that all quotes are removed from the market.")]
    RemovedFromMarket,

    /// <summary>
    /// Indicates that the quote is not valid anymore.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_ZYsyxNp-Ed-ak6NoX_4Aeg_336258631")]
    [Description(@"Indicates that the quote is not valid anymore.")]
    Expired,

    /// <summary>
    /// Indicates that the quote is being requested.
    /// Encoded/decoded by serializers as &quot;QUER&quot;.
    /// </summary>
    [EnumMember(Value = "QUER")]
    [IsoId("_ZYsyxdp-Ed-ak6NoX_4Aeg_336258632")]
    [Description(@"Indicates that the quote is being requested.")]
    Query,

    /// <summary>
    /// Indicates that no quote can be computed or communicated.
    /// Encoded/decoded by serializers as &quot;NQUO&quot;.
    /// </summary>
    [EnumMember(Value = "NQUO")]
    [IsoId("_ZYsyxtp-Ed-ak6NoX_4Aeg_336258633")]
    [Description(@"Indicates that no quote can be computed or communicated.")]
    QuoteNotFound,

    /// <summary>
    /// Indicates that the quote is being processed.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZYsyx9p-Ed-ak6NoX_4Aeg_336258634")]
    [Description(@"Indicates that the quote is being processed.")]
    Pending,

    /// <summary>
    /// Indicates that the counterparty is not interested in the transaction.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_ZYsyyNp-Ed-ak6NoX_4Aeg_-86642452")]
    [Description(@"Indicates that the counterparty is not interested in the transaction.")]
    Pass,

    /// <summary>
    /// Warning due to a situation of locked market.
    /// Encoded/decoded by serializers as &quot;LMWA&quot;.
    /// </summary>
    [EnumMember(Value = "LMWA")]
    [IsoId("_ZYsyydp-Ed-ak6NoX_4Aeg_41725420")]
    [Description(@"Warning due to a situation of locked market.")]
    LockedMarketWarning,

    /// <summary>
    /// Warning due to a situation of cross market.
    /// Encoded/decoded by serializers as &quot;CMWA&quot;.
    /// </summary>
    [EnumMember(Value = "CMWA")]
    [IsoId("_ZYsyytp-Ed-ak6NoX_4Aeg_298464818")]
    [Description(@"Warning due to a situation of cross market.")]
    CrossMarketWarning,

    /// <summary>
    /// Indicates that the quote is canceled due to a situation of locked market.
    /// Encoded/decoded by serializers as &quot;CDLM&quot;.
    /// </summary>
    [EnumMember(Value = "CDLM")]
    [IsoId("_ZY2jwNp-Ed-ak6NoX_4Aeg_313241242")]
    [Description(@"Indicates that the quote is canceled due to a situation of locked market.")]
    CanceledDueToLockMarket,

    /// <summary>
    /// Indicates that the quote is canceled due to a situation of cross market.
    /// Encoded/decoded by serializers as &quot;CDCM&quot;.
    /// </summary>
    [EnumMember(Value = "CDCM")]
    [IsoId("_ZY2jwdp-Ed-ak6NoX_4Aeg_340948751")]
    [Description(@"Indicates that the quote is canceled due to a situation of cross market.")]
    CanceledDueToCrossMarket,
}
