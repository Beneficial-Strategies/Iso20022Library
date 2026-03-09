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
/// Document that a user must file with an authorized servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_h9BccdL0EeSDLevdaFPXHw")]
[DisplayName("Registered Contract")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegisteredContract4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegisteredContract4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegisteredContract4( TradeParty2 reqReportingParty,BranchAndFinancialInstitutionIdentification5 reqRegistrationAgent,BranchAndFinancialInstitutionIdentification5 reqIssuerFinancialInstitution,UnderlyingContract1Choice_ reqContract,DocumentIdentification29 reqRegisteredContractIdentification,RegisteredContractCommunication1 reqSubmission,RegisteredContractCommunication1 reqDelivery,System.String reqEstimatedDateIndicator,System.String reqInterCompanyLoan )
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
    [IsoId("_C2ASYdL6EeSDLevdaFPXHw")]
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
    [IsoId("_gjonYtOTEeSQ_-lmj1tzfw")]
    [DisplayName("Reporting Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPty")]
    #endif
    [IsoXmlTag("RptgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeParty2 ReportingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeParty2 ReportingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty2 ReportingParty { get; init; } 
    #else
    public TradeParty2 ReportingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_gjonY9OTEeSQ_-lmj1tzfw")]
    [DisplayName("Registration Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnAgt")]
    #endif
    [IsoXmlTag("RegnAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution of the issuer of the contract.
    /// </summary>
    [IsoId("_AqAcQNL3EeSDLevdaFPXHw")]
    [DisplayName("Issuer Financial Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrFI")]
    #endif
    [IsoXmlTag("IssrFI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification5 IssuerFinancialInstitution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification5 IssuerFinancialInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5 IssuerFinancialInstitution { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5 IssuerFinancialInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the contract being registered.
    /// </summary>
    [IsoId("_Zi0lYNL2EeSDLevdaFPXHw")]
    [DisplayName("Contract")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctrct")]
    #endif
    [IsoXmlTag("Ctrct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingContract1Choice_ Contract { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingContract1Choice_ Contract { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingContract1Choice_ Contract { get; init; } 
    #else
    public UnderlyingContract1Choice_ Contract { get; set; } 
    #endif
    
    /// <summary>
    /// Contract balance on date of contract registration.
    /// </summary>
    [IsoId("_i7VeAgtLEeWkxvNyFrBT8Q")]
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
    [IsoId("_i7VeAwtLEeWkxvNyFrBT8Q")]
    [DisplayName("Payment Schedule Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSchdlTp")]
    #endif
    [IsoXmlTag("PmtSchdlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentScheduleType1Choice_? PaymentScheduleType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentScheduleType1Choice_? PaymentScheduleType { get; init; } 
    #else
    public PaymentScheduleType1Choice_? PaymentScheduleType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the registered contract as assigned by the registration agent.
    /// </summary>
    [IsoId("_0bAv0NL2EeSDLevdaFPXHw")]
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
    [IsoId("_LMxlQtOYEeS75MhTUaTyUQ")]
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
    [IsoId("_Dedg4NL3EeSDLevdaFPXHw")]
    [DisplayName("Registered Contract Journal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdCtrctJrnl")]
    #endif
    [IsoXmlTag("RegdCtrctJrnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegisteredContractJournal1? RegisteredContractJournal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegisteredContractJournal1? RegisteredContractJournal { get; init; } 
    #else
    public RegisteredContractJournal1? RegisteredContractJournal { get; set; } 
    #endif
    
    /// <summary>
    /// Details on amendments to the registered contract.
    /// </summary>
    [IsoId("_78d5oNL3EeSDLevdaFPXHw")]
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
    [IsoId("_kv3v0NL6EeSDLevdaFPXHw")]
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
    [IsoId("_R3HEptL7EeSDLevdaFPXHw")]
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
    [IsoId("_dCKXQNM8EeSDLevdaFPXHw")]
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
    [IsoId("_WB77gNOZEeS75MhTUaTyUQ")]
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
    [IsoId("_W00xAtOZEeS75MhTUaTyUQ")]
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
    [IsoId("_xD4b8NL2EeSDLevdaFPXHw")]
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
    [IsoId("_94lKwTmyEeWDb47rJ6ki4Q")]
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
