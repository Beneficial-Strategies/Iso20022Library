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
[IsoId("_2n360bGIEeuSTr8k0UEM8A")]
[DisplayName("Loan Contract")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoanContract3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoanContract3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoanContract3( DocumentIdentification22 reqContractDocumentIdentification,System.String reqIntraCompanyLoan )
    {
        ContractDocumentIdentification = reqContractDocumentIdentification;
        IntraCompanyLoan = reqIntraCompanyLoan;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contract document referenced from this loan agreement.
    /// </summary>
    [IsoId("_2o1kIbGIEeuSTr8k0UEM8A")]
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
    /// Type code of the loan contract.
    /// </summary>
    [IsoId("_o_ORYLb6Eeu9Cp6InX88Vw")]
    [DisplayName("Loan Type Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LnTpId")]
    #endif
    [IsoXmlTag("LnTpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LoanTypeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LoanTypeIdentification { get; init; } 
    #else
    public System.String? LoanTypeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is specified as the buyer for this loan agreement.
    /// </summary>
    [IsoId("_2o1kI7GIEeuSTr8k0UEM8A")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    public ValueList<TradeParty5> Buyer { get; init; } = new ValueList<TradeParty5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _2o1kI7GIEeuSTr8k0UEM8A
    
    /// <summary>
    /// Party that is specified as the seller for this loan agreement.
    /// </summary>
    [IsoId("_2o1kJbGIEeuSTr8k0UEM8A")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    public ValueList<TradeParty5> Seller { get; init; } = new ValueList<TradeParty5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _2o1kJbGIEeuSTr8k0UEM8A
    
    /// <summary>
    /// Loan amount as defined in the contract.
    /// </summary>
    [IsoId("_2o1kJ7GIEeuSTr8k0UEM8A")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_2o1kKbGIEeuSTr8k0UEM8A")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDate { get; init; } 
    #else
    public System.DateOnly? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the contract duration is extended or not.
    /// When absent, the flag meaning is NotApplicable.
    /// </summary>
    [IsoId("_2o1kK7GIEeuSTr8k0UEM8A")]
    [DisplayName("Prolongation Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrlngtnFlg")]
    #endif
    [IsoXmlTag("PrlngtnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ProlongationFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProlongationFlag { get; init; } 
    #else
    public System.String? ProlongationFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Start date of the loan contract.
    /// </summary>
    [IsoId("_2o1kLbGIEeuSTr8k0UEM8A")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDate { get; init; } 
    #else
    public System.DateOnly? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the loan is being settled.
    /// </summary>
    [IsoId("_2o1kL7GIEeuSTr8k0UEM8A")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SettlementCurrency { get; init; } 
    #else
    public string? SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Special conditions applicable when the amount is credited outside of the country.
    /// </summary>
    [IsoId("_2o1kMbGIEeuSTr8k0UEM8A")]
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
    [IsoId("_2o1kM7GIEeuSTr8k0UEM8A")]
    [DisplayName("Duration Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrtnCd")]
    #endif
    [IsoXmlTag("DrtnCd")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact1NumericText? DurationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DurationCode { get; init; } 
    #else
    public System.String? DurationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate for the loan.
    /// </summary>
    [IsoId("_2o1kNbGIEeuSTr8k0UEM8A")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRate2Choice_? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRate2Choice_? InterestRate { get; init; } 
    #else
    public InterestRate2Choice_? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// One part or division of the loan, used to define the repayment.
    /// </summary>
    [IsoId("_2o1kN7GIEeuSTr8k0UEM8A")]
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
    [IsoId("_2o1kObGIEeuSTr8k0UEM8A")]
    [DisplayName("Payment Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSchdl")]
    #endif
    [IsoXmlTag("PmtSchdl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentSchedule1? PaymentSchedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentSchedule1? PaymentSchedule { get; init; } 
    #else
    public PaymentSchedule1? PaymentSchedule { get; set; } 
    #endif
    
    /// <summary>
    /// Schedule of the interest payments defined for the loan contract.
    /// </summary>
    [IsoId("_2o1kO7GIEeuSTr8k0UEM8A")]
    [DisplayName("Interest Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstSchdl")]
    #endif
    [IsoXmlTag("IntrstSchdl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestPaymentSchedule1? InterestSchedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestPaymentSchedule1? InterestSchedule { get; init; } 
    #else
    public InterestPaymentSchedule1? InterestSchedule { get; set; } 
    #endif
    
    /// <summary>
    /// Loan is an intra company loan.
    /// </summary>
    [IsoId("_2o1kPbGIEeuSTr8k0UEM8A")]
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
    [IsoId("_2o1kP7GIEeuSTr8k0UEM8A")]
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
    [IsoId("_2o1kQbGIEeuSTr8k0UEM8A")]
    [DisplayName("Syndicated Loan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndctdLn")]
    #endif
    [IsoXmlTag("SndctdLn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SyndicatedLoan2? SyndicatedLoan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SyndicatedLoan2? SyndicatedLoan { get; init; } 
    #else
    public SyndicatedLoan2? SyndicatedLoan { get; set; } 
    #endif
    
    /// <summary>
    /// Documents provided as attachments to the loan contract.
    /// </summary>
    [IsoId("_2o1kQ7GIEeuSTr8k0UEM8A")]
    [DisplayName("Attachment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attchmnt")]
    #endif
    [IsoXmlTag("Attchmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentGeneralInformation5? Attachment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentGeneralInformation5? Attachment { get; init; } 
    #else
    public DocumentGeneralInformation5? Attachment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
