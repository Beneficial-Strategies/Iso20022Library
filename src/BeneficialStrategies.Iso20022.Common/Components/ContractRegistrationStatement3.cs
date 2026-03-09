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
/// Statement of the journal entries for all activities related to the registered currency control contract.
/// </summary>
[IsoId("_W1hHAbGJEeuSTr8k0UEM8A")]
[DisplayName("Contract Registration Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractRegistrationStatement3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContractRegistrationStatement3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContractRegistrationStatement3( TradeParty5 reqReportingParty,BranchAndFinancialInstitutionIdentification6 reqRegistrationAgent,ReportingPeriod4 reqReportingPeriod,RegisteredContract12 reqRegisteredContract,ActiveCurrencyAndAmount reqTotalContractTurnoverSum )
    {
        ReportingParty = reqReportingParty;
        RegistrationAgent = reqRegistrationAgent;
        ReportingPeriod = reqReportingPeriod;
        RegisteredContract = reqRegisteredContract;
        TotalContractTurnoverSum = reqTotalContractTurnoverSum;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the contract registration statement.
    /// </summary>
    [IsoId("_W2ewUbGJEeuSTr8k0UEM8A")]
    [DisplayName("Statement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtId")]
    #endif
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? StatementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StatementIdentification { get; init; } 
    #else
    public System.String? StatementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_W2ewU7GJEeuSTr8k0UEM8A")]
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
    [IsoId("_W2ewVbGJEeuSTr8k0UEM8A")]
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
    /// Specifies the period for which the statement is provided.
    /// </summary>
    [IsoId("_W2ewV7GJEeuSTr8k0UEM8A")]
    [DisplayName("Reporting Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPrd")]
    #endif
    [IsoXmlTag("RptgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportingPeriod4 ReportingPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportingPeriod4 ReportingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingPeriod4 ReportingPeriod { get; init; } 
    #else
    public ReportingPeriod4 ReportingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Registered currency control contract.
    /// </summary>
    [IsoId("_W2ewWbGJEeuSTr8k0UEM8A")]
    [DisplayName("Registered Contract")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdCtrct")]
    #endif
    [IsoXmlTag("RegdCtrct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RegisteredContract12 RegisteredContract { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RegisteredContract12 RegisteredContract { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegisteredContract12 RegisteredContract { get; init; } 
    #else
    public RegisteredContract12 RegisteredContract { get; set; } 
    #endif
    
    /// <summary>
    /// Journal of the transactions recorded under the registered currency control contract.
    /// </summary>
    [IsoId("_W2ewW7GJEeuSTr8k0UEM8A")]
    [DisplayName("Transaction Journal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxJrnl")]
    #endif
    [IsoXmlTag("TxJrnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionCertificate4? TransactionJournal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionCertificate4? TransactionJournal { get; init; } 
    #else
    public TransactionCertificate4? TransactionJournal { get; set; } 
    #endif
    
    /// <summary>
    /// Journal of the supporting documents recorded under the registered currency control contract.
    /// </summary>
    [IsoId("_W2ewXbGJEeuSTr8k0UEM8A")]
    [DisplayName("Supporting Document Journal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpprtgDocJrnl")]
    #endif
    [IsoXmlTag("SpprtgDocJrnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupportingDocument3? SupportingDocumentJournal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupportingDocument3? SupportingDocumentJournal { get; init; } 
    #else
    public SupportingDocument3? SupportingDocumentJournal { get; set; } 
    #endif
    
    /// <summary>
    /// Journal of additional supporting documents recorded under the registered currency control contract.
    /// </summary>
    [IsoId("_W2ewX7GJEeuSTr8k0UEM8A")]
    [DisplayName("Additional Supporting Document Journal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSpprtgDocJrnl")]
    #endif
    [IsoXmlTag("AddtlSpprtgDocJrnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupportingDocument3? AdditionalSupportingDocumentJournal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupportingDocument3? AdditionalSupportingDocumentJournal { get; init; } 
    #else
    public SupportingDocument3? AdditionalSupportingDocumentJournal { get; set; } 
    #endif
    
    /// <summary>
    /// Details on the currency control rule against which has been violated.
    /// </summary>
    [IsoId("_W2ewYbGJEeuSTr8k0UEM8A")]
    [DisplayName("Regulatory Rule Validation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryRuleVldtn")]
    #endif
    [IsoXmlTag("RgltryRuleVldtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericValidationRuleIdentification1? RegulatoryRuleValidation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericValidationRuleIdentification1? RegulatoryRuleValidation { get; init; } 
    #else
    public GenericValidationRuleIdentification1? RegulatoryRuleValidation { get; set; } 
    #endif
    
    /// <summary>
    /// Total turn over amount recorded under the currency control contract for the amount of all.
    /// </summary>
    [IsoId("_W2ewY7GJEeuSTr8k0UEM8A")]
    [DisplayName("Total Contract Turnover Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCtrctTrnvrSum")]
    #endif
    [IsoXmlTag("TtlCtrctTrnvrSum")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalContractTurnoverSum { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalContractTurnoverSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalContractTurnoverSum { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalContractTurnoverSum { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_W2ewZbGJEeuSTr8k0UEM8A")]
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
