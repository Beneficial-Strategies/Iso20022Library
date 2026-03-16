// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securities Financing Transaction Details58.
/// </summary>
[IsoId("_Lkqx0YYfEe-Pv9KR9bv9IA")]
[DisplayName("Securities Financing Transaction Details58")]
public partial record SecuritiesFinancingTransactionDetails58
{
    #nullable enable

    /// <summary>
    /// Accrued Interest Amount.
    /// </summary>
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; } 

    /// <summary>
    /// Charges Rate.
    /// </summary>
    [DisplayName("Charges Rate")]
    [IsoXmlTag("ChrgsRate")]
    public Rate2? ChargesRate { get; init; } 

    /// <summary>
    /// Closing Leg Identification.
    /// </summary>
    [DisplayName("Closing Leg Identification")]
    [IsoXmlTag("ClsgLegId")]
    public IsoMax35Text? ClosingLegIdentification { get; init; } 

    /// <summary>
    /// Commission Calculation Date.
    /// </summary>
    [DisplayName("Commission Calculation Date")]
    [IsoXmlTag("ComssnClctnDt")]
    public DateAndDateTime2Choice_? CommissionCalculationDate { get; init; } 

    /// <summary>
    /// Deal Amount.
    /// </summary>
    [DisplayName("Deal Amount")]
    [IsoXmlTag("DealAmt")]
    public AmountAndDirection21? DealAmount { get; init; } 

    /// <summary>
    /// Earliest Call Back Date.
    /// </summary>
    [DisplayName("Earliest Call Back Date")]
    [IsoXmlTag("EarlstCallBckDt")]
    public DateAndDateTime2Choice_? EarliestCallBackDate { get; init; } 

    /// <summary>
    /// Forfeit Amount.
    /// </summary>
    [DisplayName("Forfeit Amount")]
    [IsoXmlTag("FrftAmt")]
    public AmountAndDirection21? ForfeitAmount { get; init; } 

    /// <summary>
    /// Interest Computation Method.
    /// </summary>
    [DisplayName("Interest Computation Method")]
    [IsoXmlTag("IntrstCmptnMtd")]
    public InterestComputationMethodFormat4Choice_? InterestComputationMethod { get; init; } 

    /// <summary>
    /// Interest Payment.
    /// </summary>
    [DisplayName("Interest Payment")]
    [IsoXmlTag("IntrstPmt")]
    public IsoYesNoIndicator? InterestPayment { get; init; } 

    /// <summary>
    /// Legal Framework.
    /// </summary>
    [DisplayName("Legal Framework")]
    [IsoXmlTag("LglFrmwk")]
    public LegalFramework3Choice_? LegalFramework { get; init; } 

    /// <summary>
    /// Local Broker Commission.
    /// </summary>
    [DisplayName("Local Broker Commission")]
    [IsoXmlTag("LclBrkrComssn")]
    public AmountAndDirection21? LocalBrokerCommission { get; init; } 

    /// <summary>
    /// Maturity Date Modification.
    /// </summary>
    [DisplayName("Maturity Date Modification")]
    [IsoXmlTag("MtrtyDtMod")]
    public IsoYesNoIndicator? MaturityDateModification { get; init; } 

    /// <summary>
    /// Premium Amount.
    /// </summary>
    [DisplayName("Premium Amount")]
    [IsoXmlTag("PrmAmt")]
    public AmountAndDirection21? PremiumAmount { get; init; } 

    /// <summary>
    /// Pricing Rate.
    /// </summary>
    [DisplayName("Pricing Rate")]
    [IsoXmlTag("PricgRate")]
    public RateOrName1Choice_? PricingRate { get; init; } 

    /// <summary>
    /// Rate Change Date.
    /// </summary>
    [DisplayName("Rate Change Date")]
    [IsoXmlTag("RateChngDt")]
    public DateAndDateTime2Choice_? RateChangeDate { get; init; } 

    /// <summary>
    /// Rate Type.
    /// </summary>
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public RateType35Choice_? RateType { get; init; } 

    /// <summary>
    /// Repurchase Rate.
    /// </summary>
    [DisplayName("Repurchase Rate")]
    [IsoXmlTag("RpRate")]
    public Rate2? RepurchaseRate { get; init; } 

    /// <summary>
    /// Revaluation.
    /// </summary>
    [DisplayName("Revaluation")]
    [IsoXmlTag("Rvaltn")]
    public RevaluationIndicator3Choice_? Revaluation { get; init; } 

    /// <summary>
    /// Second Leg Narrative.
    /// </summary>
    [DisplayName("Second Leg Narrative")]
    [IsoXmlTag("ScndLegNrrtv")]
    public IsoMax140Text? SecondLegNarrative { get; init; } 

    /// <summary>
    /// Securities Financing Trade Identification.
    /// </summary>
    [DisplayName("Securities Financing Trade Identification")]
    [IsoXmlTag("SctiesFincgTradId")]
    public IsoMax35Text? SecuritiesFinancingTradeIdentification { get; init; } 

    /// <summary>
    /// Securities Financing Unique Transaction Identifier.
    /// </summary>
    [DisplayName("Securities Financing Unique Transaction Identifier")]
    [IsoXmlTag("SctiesFincgUnqTxIdr")]
    public IsoUTIIdentifier? SecuritiesFinancingUniqueTransactionIdentifier { get; init; } 

    /// <summary>
    /// Securities Haircut.
    /// </summary>
    [DisplayName("Securities Haircut")]
    [IsoXmlTag("SctiesHrcut")]
    public Rate2? SecuritiesHaircut { get; init; } 

    /// <summary>
    /// Spread.
    /// </summary>
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public Rate2? Spread { get; init; } 

    /// <summary>
    /// Stock Loan Margin.
    /// </summary>
    [DisplayName("Stock Loan Margin")]
    [IsoXmlTag("StockLnMrgn")]
    public Rate2? StockLoanMargin { get; init; } 

    /// <summary>
    /// Termination Amount Per Piece Of Collateral.
    /// </summary>
    [DisplayName("Termination Amount Per Piece Of Collateral")]
    [IsoXmlTag("TermntnAmtPerPcOfColl")]
    public AmountAndDirection21? TerminationAmountPerPieceOfCollateral { get; init; } 

    /// <summary>
    /// Termination Date.
    /// </summary>
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    public TerminationDate6Choice_? TerminationDate { get; init; } 

    /// <summary>
    /// Termination Transaction Amount.
    /// </summary>
    [DisplayName("Termination Transaction Amount")]
    [IsoXmlTag("TermntnTxAmt")]
    public AmountAndDirection21? TerminationTransactionAmount { get; init; } 

    /// <summary>
    /// Total Number Of Collateral Instructions.
    /// </summary>
    [DisplayName("Total Number Of Collateral Instructions")]
    [IsoXmlTag("TtlNbOfCollInstrs")]
    public IsoExact3NumericText? TotalNumberOfCollateralInstructions { get; init; } 

    /// <summary>
    /// Transaction Call Delay.
    /// </summary>
    [DisplayName("Transaction Call Delay")]
    [IsoXmlTag("TxCallDely")]
    public IsoExact3NumericText? TransactionCallDelay { get; init; } 

    /// <summary>
    /// Variable Rate Support.
    /// </summary>
    [DisplayName("Variable Rate Support")]
    [IsoXmlTag("VarblRateSpprt")]
    public RateName1? VariableRateSupport { get; init; } 

    
    #nullable disable
    
}
