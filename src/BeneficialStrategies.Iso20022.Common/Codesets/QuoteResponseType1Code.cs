// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualifies the nature of response to a previoulsy addressed quote.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZX9L59p-Ed-ak6NoX_4Aeg_-1172648945")]
[Description(@"Qualifies the nature of response to a previoulsy addressed quote.")]
[DerivedFrom(typeof(QuoteResponseTypeCode))]
public enum QuoteResponseType1Code
{
    /// <summary>
    /// Acceptance by a party of the conditions of a quote.
    /// Encoded/decoded by serializers as &quot;HILI&quot;.
    /// </summary>
    [EnumMember(Value = "HILI")]
    [IsoId("_ZX9L6Np-Ed-ak6NoX_4Aeg_-1103387160")]
    [Description(@"Acceptance by a party of the conditions of a quote.")]
    HitLift = QuoteResponseTypeCode.HitLift, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejection of the conditions of a quote and proposition of new quote details.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_ZYG84Np-Ed-ak6NoX_4Aeg_-1103386770")]
    [Description(@"Rejection of the conditions of a quote and proposition of new quote details.")]
    CounterQuote = QuoteResponseTypeCode.CounterQuote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejection of the conditions of a quote due to its expiry.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_ZYG84dp-Ed-ak6NoX_4Aeg_-1103386727")]
    [Description(@"Rejection of the conditions of a quote due to its expiry.")]
    Expired = QuoteResponseTypeCode.Expired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Purchase of a contract to offset a previously established short position.
    /// Encoded/decoded by serializers as &quot;COVE&quot;.
    /// </summary>
    [EnumMember(Value = "COVE")]
    [IsoId("_ZYG84tp-Ed-ak6NoX_4Aeg_-1103386436")]
    [Description(@"Purchase of a contract to offset a previously established short position.")]
    Cover = QuoteResponseTypeCode.Cover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade completed with a third party, counter-party.
    /// Encoded/decoded by serializers as &quot;DONE&quot;.
    /// </summary>
    [EnumMember(Value = "DONE")]
    [IsoId("_ZYG849p-Ed-ak6NoX_4Aeg_-1103386401")]
    [Description(@"Trade completed with a third party, counter-party.")]
    DoneAway = QuoteResponseTypeCode.DoneAway, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejection of the conditions of a quote because the offer is being declined.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_ZYG85Np-Ed-ak6NoX_4Aeg_-1103386359")]
    [Description(@"Rejection of the conditions of a quote because the offer is being declined.")]
    Pass = QuoteResponseTypeCode.Pass, // same ordinal as derivation source for type conversions
}
