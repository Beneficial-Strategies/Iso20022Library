// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loan Contract4.
/// </summary>
[IsoId("_2Q955TEyEe6g-ffJsqGiSA")]
[DisplayName("Loan Contract4")]
public partial record LoanContract4
{
    #nullable enable

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; } 

    /// <summary>
    /// Attachment.
    /// </summary>
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public ValueList<DocumentGeneralInformation5> Attachment { get; init; } = [];

    /// <summary>
    /// Buyer.
    /// </summary>
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public ValueList<TradeParty6> Buyer { get; init; } = [];

    /// <summary>
    /// Collateral.
    /// </summary>
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public ContractCollateral1? Collateral { get; init; } 

    /// <summary>
    /// Contract Document Identification.
    /// </summary>
    [DisplayName("Contract Document Identification")]
    [IsoXmlTag("CtrctDocId")]
    public required DocumentIdentification22 ContractDocumentIdentification { get; init; } 

    /// <summary>
    /// Duration Code.
    /// </summary>
    [DisplayName("Duration Code")]
    [IsoXmlTag("DrtnCd")]
    public IsoExact1NumericText? DurationCode { get; init; } 

    /// <summary>
    /// Interest Rate.
    /// </summary>
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRate2Choice_? InterestRate { get; init; } 

    /// <summary>
    /// Interest Schedule.
    /// </summary>
    [DisplayName("Interest Schedule")]
    [IsoXmlTag("IntrstSchdl")]
    public ValueList<InterestPaymentSchedule1> InterestSchedule { get; init; } = [];

    /// <summary>
    /// Intra Company Loan.
    /// </summary>
    [DisplayName("Intra Company Loan")]
    [IsoXmlTag("IntraCpnyLn")]
    public required IsoTrueFalseIndicator IntraCompanyLoan { get; init; } 

    /// <summary>
    /// Loan Type Identification.
    /// </summary>
    [DisplayName("Loan Type Identification")]
    [IsoXmlTag("LnTpId")]
    public IsoMax35Text? LoanTypeIdentification { get; init; } 

    /// <summary>
    /// Maturity Date.
    /// </summary>
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public IsoISODate? MaturityDate { get; init; } 

    /// <summary>
    /// Payment Schedule.
    /// </summary>
    [DisplayName("Payment Schedule")]
    [IsoXmlTag("PmtSchdl")]
    public ValueList<PaymentSchedule1> PaymentSchedule { get; init; } = [];

    /// <summary>
    /// Prolongation Flag.
    /// </summary>
    [DisplayName("Prolongation Flag")]
    [IsoXmlTag("PrlngtnFlg")]
    public IsoTrueFalseIndicator? ProlongationFlag { get; init; } 

    /// <summary>
    /// Seller.
    /// </summary>
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public ValueList<TradeParty6> Seller { get; init; } = [];

    /// <summary>
    /// Settlement Currency.
    /// </summary>
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public ActiveCurrencyCode? SettlementCurrency { get; init; } 

    /// <summary>
    /// Special Conditions.
    /// </summary>
    [DisplayName("Special Conditions")]
    [IsoXmlTag("SpclConds")]
    public SpecialCondition1? SpecialConditions { get; init; } 

    /// <summary>
    /// Start Date.
    /// </summary>
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public IsoISODate? StartDate { get; init; } 

    /// <summary>
    /// Syndicated Loan.
    /// </summary>
    [DisplayName("Syndicated Loan")]
    [IsoXmlTag("SndctdLn")]
    public ValueList<SyndicatedLoan3> SyndicatedLoan { get; init; } = [];

    /// <summary>
    /// Tranche.
    /// </summary>
    [DisplayName("Tranche")]
    [IsoXmlTag("Trch")]
    public ValueList<LoanContractTranche1> Tranche { get; init; } = [];

    
    #nullable disable
    
}
