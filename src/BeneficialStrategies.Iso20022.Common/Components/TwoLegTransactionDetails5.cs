// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the first leg in a two leg transaction process.
/// </summary>
[IsoId("_x7vQEQhKEe2fOITqoTnSLQ")]
[DisplayName("Two Leg Transaction Details")]
public record TwoLegTransactionDetails5
{
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_yM4DYQhKEe2fOITqoTnSLQ")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice_? TradeDate { get; init; }

    /// <summary>
    /// Unambiguous identification of the reference assigned in the first leg of the transaction.
    /// </summary>
    [IsoId("_yM4DYwhKEe2fOITqoTnSLQ")]
    [DisplayName("Opening Leg Identification")]
    [IsoXmlTag("OpngLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OpeningLegIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_yM4DZQhKEe2fOITqoTnSLQ")]
    [DisplayName("Closing Leg Identification")]
    [IsoXmlTag("ClsgLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClosingLegIdentification { get; init; }

    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_yM4DZwhKEe2fOITqoTnSLQ")]
    [DisplayName("Gross Trade Amount")]
    [IsoXmlTag("GrssTradAmt")]
    public AmountAndDirection29? GrossTradeAmount { get; init; }

    /// <summary>
    /// Identifies other amounts pertaining to the transaction.
    /// </summary>
    [IsoId("_yM4DaQhKEe2fOITqoTnSLQ")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts16? OtherAmounts { get; init; }

    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_yM4DawhKEe2fOITqoTnSLQ")]
    [DisplayName("Second Leg Narrative")]
    [IsoXmlTag("ScndLegNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SecondLegNarrative { get; init; }

    /// <summary>
    /// Negotiated fixed price of the security to buy it back.
    /// </summary>
    [IsoId("_yM4DbQhKEe2fOITqoTnSLQ")]
    [DisplayName("End Price")]
    [IsoXmlTag("EndPric")]
    public Price14? EndPrice { get; init; }

    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_yM4DbwhKEe2fOITqoTnSLQ")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public ClosingDate4Choice_? ClosingDate { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities. The amount includes the principal with any commissions and fees or accrued interest.
    /// </summary>
    [IsoId("_yM4DdwhKEe2fOITqoTnSLQ")]
    [DisplayName("Closing Settlement Amount")]
    [IsoXmlTag("ClsgSttlmAmt")]
    public AmountAndDirection5? ClosingSettlementAmount { get; init; }

    /// <summary>
    /// Processing date of the trading session.
    /// </summary>
    [IsoId("_yM4DeQhKEe2fOITqoTnSLQ")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public TradeDate7Choice_? ProcessingDate { get; init; }

    /// <summary>
    /// Specifies the type of the second leg transaction.
    /// </summary>
    [IsoId("_yM4DewhKEe2fOITqoTnSLQ")]
    [DisplayName("Two Leg Transaction Type")]
    [IsoXmlTag("TwoLegTxTp")]
    public TwoLegTransactionType4Choice_? TwoLegTransactionType { get; init; }
}
