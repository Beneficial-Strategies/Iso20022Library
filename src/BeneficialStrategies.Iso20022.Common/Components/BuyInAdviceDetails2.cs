// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Buy In Advice Details2.
/// </summary>
[IsoId("_XdDqYYZGEe-6cOl7zMpJaA")]
[DisplayName("Buy In Advice Details2")]
public record BuyInAdviceDetails2
{
    /// <summary>
    /// Buy In Deferral.
    /// </summary>
    [DisplayName("Buy In Deferral")]
    [IsoXmlTag("BuyInDfrrl")]
    public required BuyInDeferral1Code BuyInDeferral { get; init; }

    /// <summary>
    /// Buy In Price.
    /// </summary>
    [DisplayName("Buy In Price")]
    [IsoXmlTag("BuyInPric")]
    public RateAndAmountFormat39Choice_? BuyInPrice { get; init; }

    /// <summary>
    /// Buy In Settlement Date.
    /// </summary>
    [DisplayName("Buy In Settlement Date")]
    [IsoXmlTag("BuyInSttlmDt")]
    public DateAndDateTime2Choice_? BuyInSettlementDate { get; init; }

    /// <summary>
    /// Buy In State.
    /// </summary>
    [DisplayName("Buy In State")]
    [IsoXmlTag("BuyInStat")]
    public required BuyInState1Code BuyInState { get; init; }

    /// <summary>
    /// Cash Compensation Amount.
    /// </summary>
    [DisplayName("Cash Compensation Amount")]
    [IsoXmlTag("CshCompstnAmt")]
    public AmountAndDirection102? CashCompensationAmount { get; init; }

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Quantity.
    /// </summary>
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; }

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References31 Reference { get; init; }
}
