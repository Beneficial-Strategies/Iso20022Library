// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value date and the amounts traded in a foreign exchange option trade.
/// </summary>
[IsoId("_TImtuNp-Ed-ak6NoX_4Aeg_993174808")]
[DisplayName("Amounts And Value Date")]
public record AmountsAndValueDate4
{
    /// <summary>
    /// Call amount and currency of a foreign exchange option trade.
    /// </summary>
    [IsoId("_TIwesNp-Ed-ak6NoX_4Aeg_993174851")]
    [DisplayName("Call Amount")]
    [IsoXmlTag("CallAmt")]
    public required ActiveOrHistoricCurrencyAndAmount CallAmount { get; init; }

    /// <summary>
    /// Put amount and currency of a foreign exchange option trade.
    /// </summary>
    [IsoId("_TIwesdp-Ed-ak6NoX_4Aeg_993175120")]
    [DisplayName("Put Amount")]
    [IsoXmlTag("PutAmt")]
    public required ActiveOrHistoricCurrencyAndAmount PutAmount { get; init; }

    /// <summary>
    /// The single settlement currency for the payment made by the seller to the buyer if the option is exercised in case of a Non Deliverable Option.
    /// </summary>
    [IsoId("_TIwestp-Ed-ak6NoX_4Aeg_-152255063")]
    [DisplayName("Option Settlement Currency")]
    [IsoXmlTag("OptnSttlmCcy")]
    public ActiveOrHistoricCurrencyCode? OptionSettlementCurrency { get; init; }

    /// <summary>
    /// Date on which the trade is settled, ie, the amounts are due.
    /// </summary>
    [IsoId("_TIwes9p-Ed-ak6NoX_4Aeg_993175103")]
    [DisplayName("Final Settlement Date")]
    [IsoXmlTag("FnlSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate FinalSettlementDate { get; init; }
}
