// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualifies the nature of response to a previoulsy addressed quote.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZYG85dp-Ed-ak6NoX_4Aeg_336258286")]
[Description(@"Qualifies the nature of response to a previoulsy addressed quote.")]
[Derivations(typeof(QuoteResponseType1Code))]
public enum QuoteResponseTypeCode
{
    /// <summary>
    /// Acceptance by a party of the conditions of a quote.
    /// Encoded/decoded by serializers as &quot;HILI&quot;.
    /// </summary>
    [EnumMember(Value = "HILI")]
    [IsoId("_ZYG85tp-Ed-ak6NoX_4Aeg_336258287")]
    [Description(@"Acceptance by a party of the conditions of a quote.")]
    HitLift,

    /// <summary>
    /// Rejection of the conditions of a quote and proposition of new quote details.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_ZYG859p-Ed-ak6NoX_4Aeg_336258288")]
    [Description(@"Rejection of the conditions of a quote and proposition of new quote details.")]
    CounterQuote,

    /// <summary>
    /// Rejection of the conditions of a quote due to its expiry.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_ZYG86Np-Ed-ak6NoX_4Aeg_336258289")]
    [Description(@"Rejection of the conditions of a quote due to its expiry.")]
    Expired,

    /// <summary>
    /// Purchase of a contract to offset a previously established short position.
    /// Encoded/decoded by serializers as &quot;COVE&quot;.
    /// </summary>
    [EnumMember(Value = "COVE")]
    [IsoId("_ZYG86dp-Ed-ak6NoX_4Aeg_336258290")]
    [Description(@"Purchase of a contract to offset a previously established short position.")]
    Cover,

    /// <summary>
    /// Trade completed with a third party, counter-party.
    /// Encoded/decoded by serializers as &quot;DONE&quot;.
    /// </summary>
    [EnumMember(Value = "DONE")]
    [IsoId("_ZYQG0Np-Ed-ak6NoX_4Aeg_336258291")]
    [Description(@"Trade completed with a third party, counter-party.")]
    DoneAway,

    /// <summary>
    /// Rejection of the conditions of a quote because the offer is being declined.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_ZYQG0dp-Ed-ak6NoX_4Aeg_336258292")]
    [Description(@"Rejection of the conditions of a quote because the offer is being declined.")]
    Pass,
}
