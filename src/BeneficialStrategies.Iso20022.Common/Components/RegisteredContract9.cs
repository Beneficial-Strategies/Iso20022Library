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
/// Amendment data of document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_WABfgW49EeiU9cctagi5ow")]
[DisplayName("Registered Contract")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegisteredContract9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegisteredContract9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegisteredContract9( System.String reqContractRegistrationAmendmentIdentification,TradeParty5 reqReportingParty,BranchAndFinancialInstitutionIdentification6 reqRegistrationAgent )
    {
        ContractRegistrationAmendmentIdentification = reqContractRegistrationAmendmentIdentification;
        ReportingParty = reqReportingParty;
        RegistrationAgent = reqRegistrationAgent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the contract registration amendment.
    /// </summary>
    [IsoId("_WJQ7EW49EeiU9cctagi5ow")]
    [DisplayName("Contract Registration Amendment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctRegnAmdmntId")]
    #endif
    [IsoXmlTag("CtrctRegnAmdmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ContractRegistrationAmendmentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ContractRegistrationAmendmentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ContractRegistrationAmendmentIdentification { get; init; } 
    #else
    public System.String ContractRegistrationAmendmentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_WJQ7E249EeiU9cctagi5ow")]
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
    [IsoId("_WJQ7FW49EeiU9cctagi5ow")]
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
    /// Amendment details applied on one or several registered contracts.
    /// </summary>
    [IsoId("_WJQ7F249EeiU9cctagi5ow")]
    [DisplayName("Registered Contract Amendment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdCtrctAmdmnt")]
    #endif
    [IsoXmlTag("RegdCtrctAmdmnt")]
    public ValueList<RegisteredContract10> RegisteredContractAmendment { get; init; } = new ValueList<RegisteredContract10>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _WJQ7F249EeiU9cctagi5ow
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_WJQ7H249EeiU9cctagi5ow")]
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
