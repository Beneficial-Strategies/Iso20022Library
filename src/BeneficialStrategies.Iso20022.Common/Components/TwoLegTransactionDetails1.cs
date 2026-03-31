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
[IsoId("_Athp0NokEeC60axPepSq7g_480086930")]
[DisplayName("Two Leg Transaction Details")]
public record TwoLegTransactionDetails1
{
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_Atra0NokEeC60axPepSq7g_2139369483")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate1Choice_? TradeDate { get; init; }

    /// <summary>
    /// Unambiguous identification of the reference assigned in the first leg of the transaction.
    /// </summary>
    [IsoId("_Atra0dokEeC60axPepSq7g_769169945")]
    [DisplayName("Opening Leg Identification")]
    [IsoXmlTag("OpngLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OpeningLegIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_Atra0tokEeC60axPepSq7g_991534697")]
    [DisplayName("Closing Leg Identification")]
    [IsoXmlTag("ClsgLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClosingLegIdentification { get; init; }

    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_Atra09okEeC60axPepSq7g_-341298891")]
    [DisplayName("Gross Trade Amount")]
    [IsoXmlTag("GrssTradAmt")]
    public AmountAndDirection29? GrossTradeAmount { get; init; }

    /// <summary>
    /// Identifies other amounts pertaining to the transaction.
    /// </summary>
    [IsoId("_Atra1NokEeC60axPepSq7g_1134902269")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public ValueList<OtherAmounts16> OtherAmounts { get; init; } = [];

    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_Atra1dokEeC60axPepSq7g_301140228")]
    [DisplayName("Second Leg Narrative")]
    [IsoXmlTag("ScndLegNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SecondLegNarrative { get; init; }

    /// <summary>
    /// Negotiated fixed price of the security to buy it back.
    /// </summary>
    [IsoId("_Atra1tokEeC60axPepSq7g_-1489715652")]
    [DisplayName("End Price")]
    [IsoXmlTag("EndPric")]
    public Price4? EndPrice { get; init; }

    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_At1L0NokEeC60axPepSq7g_-1579165412")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public ClosingDate1Choice_? ClosingDate { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities. The amount includes the principal with any commissions and fees or accrued interest.
    /// </summary>
    [IsoId("_At1L0dokEeC60axPepSq7g_109778330")]
    [DisplayName("Closing Settlement Amount")]
    [IsoXmlTag("ClsgSttlmAmt")]
    public AmountAndDirection5? ClosingSettlementAmount { get; init; }

    /// <summary>
    /// Processing date of the trading session.
    /// </summary>
    [IsoId("_At1L0tokEeC60axPepSq7g_602625373")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public TradeDate4Choice_? ProcessingDate { get; init; }

    /// <summary>
    /// Specifies the type of the second leg transaction.
    /// </summary>
    [IsoId("_At1L09okEeC60axPepSq7g_-810604027")]
    [DisplayName("Two Leg Transaction Type")]
    [IsoXmlTag("TwoLegTxTp")]
    public TwoLegTransactionType1Choice_? TwoLegTransactionType { get; init; }
}
