// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securities Financing Transaction Details55.
/// </summary>
[IsoId("_Em0g0YYdEe-Pv9KR9bv9IA")]
[DisplayName("Securities Financing Transaction Details55")]
public partial record SecuritiesFinancingTransactionDetails55
{
    #nullable enable

    /// <summary>
    /// Accrued Interest Amount.
    /// </summary>
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; } 

    /// <summary>
    /// Closing Leg Identification.
    /// </summary>
    [DisplayName("Closing Leg Identification")]
    [IsoXmlTag("ClsgLegId")]
    public IsoMax35Text? ClosingLegIdentification { get; init; } 

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
    /// Maturity Date Modification.
    /// </summary>
    [DisplayName("Maturity Date Modification")]
    [IsoXmlTag("MtrtyDtMod")]
    public IsoYesNoIndicator? MaturityDateModification { get; init; } 

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
