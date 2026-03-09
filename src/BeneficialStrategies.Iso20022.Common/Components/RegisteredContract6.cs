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
[IsoId("_EXwBT249EeiU9cctagi5ow")]
[DisplayName("Registered Contract")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegisteredContract6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegisteredContract6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegisteredContract6( System.String reqRegisteredContractClosureIdentification,TradeParty5 reqReportingParty,BranchAndFinancialInstitutionIdentification6 reqRegistrationAgent,DocumentIdentification29 reqOriginalRegisteredContract,Priority2Code reqPriority,ContractClosureReason1Choice_ reqClosureReason )
    {
        RegisteredContractClosureIdentification = reqRegisteredContractClosureIdentification;
        ReportingParty = reqReportingParty;
        RegistrationAgent = reqRegistrationAgent;
        OriginalRegisteredContract = reqOriginalRegisteredContract;
        Priority = reqPriority;
        ClosureReason = reqClosureReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the registered contract closure.
    /// </summary>
    [IsoId("_EjORcW49EeiU9cctagi5ow")]
    [DisplayName("Registered Contract Closure Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdCtrctClsrId")]
    #endif
    [IsoXmlTag("RegdCtrctClsrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RegisteredContractClosureIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RegisteredContractClosureIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RegisteredContractClosureIdentification { get; init; } 
    #else
    public System.String RegisteredContractClosureIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party who registered the currency control contract.
    /// </summary>
    [IsoId("_EjOReW49EeiU9cctagi5ow")]
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
    /// Agent who registered the currency control contract.
    /// </summary>
    [IsoId("_EjORe249EeiU9cctagi5ow")]
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
    /// Original registered contract identification.
    /// </summary>
    [IsoId("_EjORfW49EeiU9cctagi5ow")]
    [DisplayName("Original Registered Contract")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlRegdCtrct")]
    #endif
    [IsoXmlTag("OrgnlRegdCtrct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification29 OriginalRegisteredContract { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification29 OriginalRegisteredContract { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification29 OriginalRegisteredContract { get; init; } 
    #else
    public DocumentIdentification29 OriginalRegisteredContract { get; set; } 
    #endif
    
    /// <summary>
    /// Priority of the registered contract closure.
    /// </summary>
    [IsoId("_EjORhW49EeiU9cctagi5ow")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Priority2Code Priority { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Priority2Code Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Priority2Code Priority { get; init; } 
    #else
    public Priority2Code Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Reason of the closure.
    /// </summary>
    [IsoId("_EjORh249EeiU9cctagi5ow")]
    [DisplayName("Closure Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsrRsn")]
    #endif
    [IsoXmlTag("ClsrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContractClosureReason1Choice_ ClosureReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContractClosureReason1Choice_ ClosureReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractClosureReason1Choice_ ClosureReason { get; init; } 
    #else
    public ContractClosureReason1Choice_ ClosureReason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_EjORiW49EeiU9cctagi5ow")]
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
