// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash-in and cash-out flows by party.
/// </summary>
[IsoId("_RP6Gt9p-Ed-ak6NoX_4Aeg_1330321865")]
[DisplayName("Breakdown By Party")]
public record BreakdownByParty1
{
    /// <summary>
    /// Party, eg, fund management company, for which the cash flow is being reported.
    /// </summary>
    [IsoId("_RP6GuNp-Ed-ak6NoX_4Aeg_-1549407706")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification2Choice_ Party { get; init; }

    /// <summary>
    /// Additional parameter/s applied to the cash flow by party.
    /// </summary>
    [IsoId("_RP6Gudp-Ed-ak6NoX_4Aeg_960937370")]
    [DisplayName("Additional Parameters")]
    [IsoXmlTag("AddtlParams")]
    public AdditionalParameters1? AdditionalParameters { get; init; }

    /// <summary>
    /// Cash movement into the fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_RP6Gutp-Ed-ak6NoX_4Aeg_-2077163620")]
    [DisplayName("Cash In Forecast")]
    [IsoXmlTag("CshInFcst")]
    public ValueList<CashInForecast3> CashInForecast { get; init; } = [];

    /// <summary>
    /// Cash movement out of the fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_RP6Gu9p-Ed-ak6NoX_4Aeg_-2070700651")]
    [DisplayName("Cash Out Forecast")]
    [IsoXmlTag("CshOutFcst")]
    public ValueList<CashOutForecast3> CashOutForecast { get; init; } = [];

    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the party.
    /// </summary>
    [IsoId("_RQDQoNp-Ed-ak6NoX_4Aeg_-2101175737")]
    [DisplayName("Net Cash Forecast")]
    [IsoXmlTag("NetCshFcst")]
    public ValueList<NetCashForecast2> NetCashForecast { get; init; } = [];
}
