// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed ownership information about the shareholding quantity to be disclosed,  or the shareholding quantity not to be disclosed and the shareholding quantity below threshold.
/// </summary>
[IsoId("_Mhe_8_NyEeqRfth943bvEA")]
[DisplayName("Account Sub Level")]
public record AccountSubLevel22
{
    /// <summary>
    /// Quantity of shares for which shareholding details are not disclosed.
    /// </summary>
    [IsoId("_M0-jofNyEeqRfth943bvEA")]
    [DisplayName("Non Disclosed Shareholding Quantity")]
    [IsoXmlTag("NonDscldShrhldgQty")]
    public FinancialInstrumentQuantity18Choice_? NonDisclosedShareholdingQuantity { get; init; }

    /// <summary>
    /// Quantity of shares for which shareholding details are not reported as the quantity of shares owned by the shareholder is under the threshold limit.
    /// </summary>
    [IsoId("_M0-jo_NyEeqRfth943bvEA")]
    [DisplayName("Below Threshold Shareholding Quantity")]
    [IsoXmlTag("BlwThrshldShrhldgQty")]
    public FinancialInstrumentQuantity18Choice_? BelowThresholdShareholdingQuantity { get; init; }

    /// <summary>
    /// Details of the account sub-levels and holdings.
    /// </summary>
    [IsoId("_M0-jpfNyEeqRfth943bvEA")]
    [DisplayName("Disclosure")]
    [IsoXmlTag("Dsclsr")]
    public ValueList<AccountSubLevel23> Disclosure { get; init; } = [];
}
