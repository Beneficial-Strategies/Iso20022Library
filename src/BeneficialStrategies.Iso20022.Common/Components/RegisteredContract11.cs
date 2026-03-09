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
/// Document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_Gyw1EbGJEeuSTr8k0UEM8A")]
[DisplayName("Registered Contract")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegisteredContract11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegisteredContract11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegisteredContract11( TradeParty5 reqReportingParty,BranchAndFinancialInstitutionIdentification6 reqRegistrationAgent,BranchAndFinancialInstitutionIdentification6 reqIssuerFinancialInstitution,UnderlyingContract3Choice_ reqContract,DocumentIdentification29 reqRegisteredContractIdentification,RegisteredContractCommunication1 reqSubmission,RegisteredContractCommunication1 reqDelivery,System.String reqEstimatedDateIndicator,System.String reqInterCompanyLoan )
    {
        ReportingParty = reqReportingParty;
        RegistrationAgent = reqRegistrationAgent;
        IssuerFinancialInstitution = reqIssuerFinancialInstitution;
        Contract = reqContract;
        RegisteredContractIdentification = reqRegisteredContractIdentification;
        Submission = reqSubmission;
        Delivery = reqDelivery;
        EstimatedDateIndicator = reqEstimatedDateIndicator;
        InterCompanyLoan = reqInterCompanyLoan;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the contract registration creation, amendment or closure request.
    /// </summary>
    [IsoId("_G0BZUbGJEeuSTr8k0UEM8A")]
    [DisplayName("Original Contract Registration Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCtrctRegnReq")]
    #endif
    [IsoXmlTag("OrgnlCtrctRegnReq")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalContractRegistrationRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalContractRegistrationRequest { get; init; } 
    #else
    public System.String? OriginalContractRegistrationRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_G0BZU7GJEeuSTr8k0UEM8A")]
    [DisplayName("Reporting Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPty")]
    #endif
    [IsoXmlTag("RptgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeParty5 ReportingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeParty5 ReportingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty5 ReportingParty { get; init; } 
    #else
    public TradeParty5 ReportingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_G0BZVbGJEeuSTr8k0UEM8A")]
    [DisplayName("Registration Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnAgt")]
    #endif
    [IsoXmlTag("RegnAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution of the issuer of the contract.
    /// </summary>
    [IsoId("_G0BZV7GJEeuSTr8k0UEM8A")]
    [DisplayName("Issuer Financial Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrFI")]
    #endif
    [IsoXmlTag("IssrFI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification6 IssuerFinancialInstitution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification6 IssuerFinancialInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6 IssuerFinancialInstitution { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6 IssuerFinancialInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the contract being registered.
    /// </summary>
    [IsoId("_G0BZWbGJEeuSTr8k0UEM8A")]
    [DisplayName("Contract")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctrct")]
    #endif
    [IsoXmlTag("Ctrct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingContract3Choice_ Contract { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingContract3Choice_ Contract { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingContract3Choice_ Contract { get; init; } 
    #else
    public UnderlyingContract3Choice_ Contract { get; set; } 
    #endif
    
    /// <summary>
    /// Contract balance on date of contract registration.
    /// </summary>
    [IsoId("_G0BZW7GJEeuSTr8k0UEM8A")]
    [DisplayName("Contract Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctBal")]
    #endif
    [IsoXmlTag("CtrctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractBalance1? ContractBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractBalance1? ContractBalance { get; init; } 
    #else
    public ContractBalance1? ContractBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the payment schedule provided in the contract.
    /// </summary>
    [IsoId("_G0BZXbGJEeuSTr8k0UEM8A")]
    [DisplayName("Payment Schedule Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSchdlTp")]
    #endif
    [IsoXmlTag("PmtSchdlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentScheduleType2Choice_? PaymentScheduleType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentScheduleType2Choice_? PaymentScheduleType { get; init; } 
    #else
    public PaymentScheduleType2Choice_? PaymentScheduleType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the registered contract as assigned by the registration agent.
    /// </summary>
    [IsoId("_G0BZX7GJEeuSTr8k0UEM8A")]
    [DisplayName("Registered Contract Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdCtrctId")]
    #endif
    [IsoXmlTag("RegdCtrctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification29 RegisteredContractIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification29 RegisteredContractIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification29 RegisteredContractIdentification { get; init; } 
    #else
    public DocumentIdentification29 RegisteredContractIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously defined registered contract linked to the same underlying contract.
    /// Usage:
    /// This is the identification of a previous contract registration for the same underlying contract, which was closed. In most cases, this is used when a reporting party moves from one registration agent to another.
    /// </summary>
    [IsoId("_G0BZZ7GJEeuSTr8k0UEM8A")]
    [DisplayName("Previous Registered Contract Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRegdCtrctId")]
    #endif
    [IsoXmlTag("PrvsRegdCtrctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? PreviousRegisteredContractIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? PreviousRegisteredContractIdentification { get; init; } 
    #else
    public DocumentIdentification22? PreviousRegisteredContractIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Journal of previously closed registered contracts for the same underlying contract, which were requested at the same registration agent.
    /// </summary>
    [IsoId("_G0BZb7GJEeuSTr8k0UEM8A")]
    [DisplayName("Registered Contract Journal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdCtrctJrnl")]
    #endif
    [IsoXmlTag("RegdCtrctJrnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegisteredContractJournal2? RegisteredContractJournal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegisteredContractJournal2? RegisteredContractJournal { get; init; } 
    #else
    public RegisteredContractJournal2? RegisteredContractJournal { get; set; } 
    #endif
    
    /// <summary>
    /// Details on amendments to the registered contract.
    /// </summary>
    [IsoId("_G0BZcbGJEeuSTr8k0UEM8A")]
    [DisplayName("Amendment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amdmnt")]
    #endif
    [IsoXmlTag("Amdmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegisteredContractAmendment1? Amendment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegisteredContractAmendment1? Amendment { get; init; } 
    #else
    public RegisteredContractAmendment1? Amendment { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the communication method for the submission of the registered contract.
    /// </summary>
    [IsoId("_G0BZc7GJEeuSTr8k0UEM8A")]
    [DisplayName("Submission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Submissn")]
    #endif
    [IsoXmlTag("Submissn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RegisteredContractCommunication1 Submission { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RegisteredContractCommunication1 Submission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegisteredContractCommunication1 Submission { get; init; } 
    #else
    public RegisteredContractCommunication1 Submission { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the communication method for the delivery of the registered contract.
    /// </summary>
    [IsoId("_G0BZdbGJEeuSTr8k0UEM8A")]
    [DisplayName("Delivery")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dlvry")]
    #endif
    [IsoXmlTag("Dlvry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RegisteredContractCommunication1 Delivery { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RegisteredContractCommunication1 Delivery { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegisteredContractCommunication1 Delivery { get; init; } 
    #else
    public RegisteredContractCommunication1 Delivery { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money the borrower pays back to the lender outside of interests and charges.
    /// Usage:
    /// Only applicable for loan contracts.
    /// </summary>
    [IsoId("_G0BZd7GJEeuSTr8k0UEM8A")]
    [DisplayName("Loan Principal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LnPrncplAmt")]
    #endif
    [IsoXmlTag("LnPrncplAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? LoanPrincipalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? LoanPrincipalAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? LoanPrincipalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the dates provided are estimates or not.
    /// </summary>
    [IsoId("_G0BZebGJEeuSTr8k0UEM8A")]
    [DisplayName("Estimated Date Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdDtInd")]
    #endif
    [IsoXmlTag("EstmtdDtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator EstimatedDateIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EstimatedDateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EstimatedDateIndicator { get; init; } 
    #else
    public System.String EstimatedDateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether loan in which both the lender and the borrower are divisions of the same corporation or not.
    /// Usage:
    /// Only applicable for loan contracts.
    /// </summary>
    [IsoId("_G0BZe7GJEeuSTr8k0UEM8A")]
    [DisplayName("Inter Company Loan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrCpnyLn")]
    #endif
    [IsoXmlTag("IntrCpnyLn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator InterCompanyLoan { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InterCompanyLoan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InterCompanyLoan { get; init; } 
    #else
    public System.String InterCompanyLoan { get; set; } 
    #endif
    
    /// <summary>
    /// Further information on the registered contract.
    /// </summary>
    [IsoId("_G0BZfbGJEeuSTr8k0UEM8A")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_G0BZf7GJEeuSTr8k0UEM8A")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
