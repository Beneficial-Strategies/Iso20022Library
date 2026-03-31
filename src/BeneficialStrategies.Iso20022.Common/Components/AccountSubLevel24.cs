// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Sub Level24.
/// </summary>
[IsoId("_w26Q01x7Ee6fgZt44_IqFA")]
[DisplayName("Account Sub Level24")]
public record AccountSubLevel24
{
    /// <summary>
    /// Below Threshold Shareholding Quantity.
    /// </summary>
    [DisplayName("Below Threshold Shareholding Quantity")]
    [IsoXmlTag("BlwThrshldShrhldgQty")]
    public FinancialInstrumentQuantity18Choice_? BelowThresholdShareholdingQuantity { get; init; }

    /// <summary>
    /// Disclosure.
    /// </summary>
    [DisplayName("Disclosure")]
    [IsoXmlTag("Dsclsr")]
    public ValueList<AccountSubLevel25> Disclosure { get; init; } = [];

    /// <summary>
    /// Non Disclosed Shareholding Quantity.
    /// </summary>
    [DisplayName("Non Disclosed Shareholding Quantity")]
    [IsoXmlTag("NonDscldShrhldgQty")]
    public FinancialInstrumentQuantity18Choice_? NonDisclosedShareholdingQuantity { get; init; }
}
