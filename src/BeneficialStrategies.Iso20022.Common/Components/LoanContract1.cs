// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contract by which an amount of money in exchange for future repayment of the principal amount along with interest or other finance charges.
/// </summary>
[IsoId("_uCfA8NLJEeSdq5yU2aaSNw")]
[DisplayName("Loan Contract")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoanContract1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoanContract1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoanContract1( DocumentIdentification22 reqContractDocumentIdentification,ActiveCurrencyAndAmount reqAmount,System.DateOnly reqMaturityDate,System.String reqProlongationFlag,System.DateOnly reqStartDate,string reqSettlementCurrency,System.String reqDurationCode,InterestRate2Choice_ reqInterestRate,InterestPaymentSchedule1Choice_ reqInterestSchedule,System.String reqIntraCompanyLoan )
    {
        ContractDocumentIdentification = reqContractDocumentIdentification;
        Amount = reqAmount;
        MaturityDate = reqMaturityDate;
        ProlongationFlag = reqProlongationFlag;
        StartDate = reqStartDate;
        SettlementCurrency = reqSettlementCurrency;
        DurationCode = reqDurationCode;
        InterestRate = reqInterestRate;
        InterestSchedule = reqInterestSchedule;
        IntraCompanyLoan = reqIntraCompanyLoan;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contract document referenced from this loan agreement.
    /// </summary>
    [IsoId("_PSp2JdNDEeSDLevdaFPXHw")]
    [DisplayName("Contract Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctDocId")]
    #endif
    [IsoXmlTag("CtrctDocId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification22 ContractDocumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification22 ContractDocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22 ContractDocumentIdentification { get; init; } 
    #else
    public DocumentIdentification22 ContractDocumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is specified as the buyer for this loan agreement.
    /// </summary>
    [IsoId("_PSp2I9NDEeSDLevdaFPXHw")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    public ValueList<TradeParty2> Buyer { get; init; } = new ValueList<TradeParty2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _PSp2I9NDEeSDLevdaFPXHw
    
    /// <summary>
    /// Party that is specified as the seller for this loan agreement.
    /// </summary>
    [IsoId("_PSp2JNNDEeSDLevdaFPXHw")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    public ValueList<TradeParty2> Seller { get; init; } = new ValueList<TradeParty2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _PSp2JNNDEeSDLevdaFPXHw
    
    /// <summary>
    /// Loan amount as defined in the contract.
    /// </summary>
    [IsoId("_1NQTMdNFEeSDLevdaFPXHw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_eSC7tNNFEeSDLevdaFPXHw")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate MaturityDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly MaturityDate { get; init; } 
    #else
    public System.DateOnly MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the contract duration is extended or not.
    /// </summary>
    [IsoId("_eSC7tdNFEeSDLevdaFPXHw")]
    [DisplayName("Prolongation Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrlngtnFlg")]
    #endif
    [IsoXmlTag("PrlngtnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator ProlongationFlag { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProlongationFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProlongationFlag { get; init; } 
    #else
    public System.String ProlongationFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Start date of the loan contract.
    /// </summary>
    [IsoId("_eSC7ttNFEeSDLevdaFPXHw")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate StartDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly StartDate { get; init; } 
    #else
    public System.DateOnly StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the loan is being settled.
    /// </summary>
    [IsoId("_eSC7t9NFEeSDLevdaFPXHw")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SettlementCurrency { get; init; } 
    #else
    public string SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// When the amount is credited outside of the country, special conditions are applicable.
    /// </summary>
    [IsoId("_z85K09OCEeSQ_-lmj1tzfw")]
    [DisplayName("Special Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclConds")]
    #endif
    [IsoXmlTag("SpclConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecialCondition1? SpecialConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecialCondition1? SpecialConditions { get; init; } 
    #else
    public SpecialCondition1? SpecialConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Loan duration in a coded form.
    /// </summary>
    [IsoId("_xGFgUNODEeSQ_-lmj1tzfw")]
    [DisplayName("Duration Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrtnCd")]
    #endif
    [IsoXmlTag("DrtnCd")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact1NumericText DurationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DurationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DurationCode { get; init; } 
    #else
    public System.String DurationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate for the loan.
    /// </summary>
    [IsoId("_i_afMNNEEeSDLevdaFPXHw")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InterestRate2Choice_ InterestRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InterestRate2Choice_ InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRate2Choice_ InterestRate { get; init; } 
    #else
    public InterestRate2Choice_ InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// One part or division of the loan, used to define the repayment.
    /// </summary>
    [IsoId("_QOgk8tNEEeSDLevdaFPXHw")]
    [DisplayName("Tranche")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trch")]
    #endif
    [IsoXmlTag("Trch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoanContractTranche1? Tranche { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoanContractTranche1? Tranche { get; init; } 
    #else
    public LoanContractTranche1? Tranche { get; set; } 
    #endif
    
    /// <summary>
    /// Schedule of the payments defined for the loan contract.
    /// </summary>
    [IsoId("_bGxH8NNEEeSDLevdaFPXHw")]
    [DisplayName("Payment Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSchdl")]
    #endif
    [IsoXmlTag("PmtSchdl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentSchedule1Choice_? PaymentSchedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentSchedule1Choice_? PaymentSchedule { get; init; } 
    #else
    public PaymentSchedule1Choice_? PaymentSchedule { get; set; } 
    #endif
    
    /// <summary>
    /// Schedule of the interest payments defined for the loan contract.
    /// </summary>
    [IsoId("_ipBAgdOIEeSQ_-lmj1tzfw")]
    [DisplayName("Interest Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstSchdl")]
    #endif
    [IsoXmlTag("IntrstSchdl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InterestPaymentSchedule1Choice_ InterestSchedule { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InterestPaymentSchedule1Choice_ InterestSchedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestPaymentSchedule1Choice_ InterestSchedule { get; init; } 
    #else
    public InterestPaymentSchedule1Choice_ InterestSchedule { get; set; } 
    #endif
    
    /// <summary>
    /// Loan is an intra company loan.
    /// </summary>
    [IsoId("_qhLCcDm4EeWDb47rJ6ki4Q")]
    [DisplayName("Intra Company Loan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntraCpnyLn")]
    #endif
    [IsoXmlTag("IntraCpnyLn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator IntraCompanyLoan { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IntraCompanyLoan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IntraCompanyLoan { get; init; } 
    #else
    public System.String IntraCompanyLoan { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the collateral for the loan.
    /// </summary>
    [IsoId("_guNRkNNEEeSDLevdaFPXHw")]
    [DisplayName("Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Coll")]
    #endif
    [IsoXmlTag("Coll")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractCollateral1? Collateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractCollateral1? Collateral { get; init; } 
    #else
    public ContractCollateral1? Collateral { get; set; } 
    #endif
    
    /// <summary>
    /// Loan offered by a group of lenders (called a syndicate) who work together to provide funds for a single borrower.
    /// </summary>
    [IsoId("_KEsEMNOKEeSQ_-lmj1tzfw")]
    [DisplayName("Syndicated Loan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndctdLn")]
    #endif
    [IsoXmlTag("SndctdLn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SyndicatedLoan1? SyndicatedLoan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SyndicatedLoan1? SyndicatedLoan { get; init; } 
    #else
    public SyndicatedLoan1? SyndicatedLoan { get; set; } 
    #endif
    
    /// <summary>
    /// Documents provided as attachments to the loan contract.
    /// </summary>
    [IsoId("_HKFzkdNDEeSDLevdaFPXHw")]
    [DisplayName("Attachment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attchmnt")]
    #endif
    [IsoXmlTag("Attchmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentGeneralInformation3? Attachment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentGeneralInformation3? Attachment { get; init; } 
    #else
    public DocumentGeneralInformation3? Attachment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
