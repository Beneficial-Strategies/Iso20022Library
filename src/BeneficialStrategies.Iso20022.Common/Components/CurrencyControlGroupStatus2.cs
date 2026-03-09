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
/// Provides the currency control group status details.
/// </summary>
[IsoId("_S5InHW49EeiU9cctagi5ow")]
[DisplayName("Currency Control Group Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyControlGroupStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyControlGroupStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyControlGroupStatus2( OriginalMessage5 reqOriginalReferences,TradeParty5 reqReportingParty,BranchAndFinancialInstitutionIdentification6 reqRegistrationAgent )
    {
        OriginalReferences = reqOriginalReferences;
        ReportingParty = reqReportingParty;
        RegistrationAgent = reqRegistrationAgent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Original underlying message references for which the status advice is provided.
    /// </summary>
    [IsoId("_TC94gW49EeiU9cctagi5ow")]
    [DisplayName("Original References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlRefs")]
    #endif
    [IsoXmlTag("OrgnlRefs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalMessage5 OriginalReferences { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalMessage5 OriginalReferences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMessage5 OriginalReferences { get; init; } 
    #else
    public OriginalMessage5 OriginalReferences { get; set; } 
    #endif
    
    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_TC94g249EeiU9cctagi5ow")]
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
    [IsoId("_TC94hW49EeiU9cctagi5ow")]
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
    /// For daily reporting this is the day to which the transaction data in the status message refers to.
    /// For periodic reporting this is the first and the last day to which the transaction data in the status message refers.
    /// </summary>
    [IsoId("_TC94h249EeiU9cctagi5ow")]
    [DisplayName("Reporting Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPrd")]
    #endif
    [IsoXmlTag("RptgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period4Choice_? ReportingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_? ReportingPeriod { get; init; } 
    #else
    public Period4Choice_? ReportingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status for the full report.
    /// </summary>
    [IsoId("_TC94iW49EeiU9cctagi5ow")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatisticalReportingStatus1Code? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticalReportingStatus1Code? Status { get; init; } 
    #else
    public StatisticalReportingStatus1Code? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_TC94i249EeiU9cctagi5ow")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValidationStatusReason2? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValidationStatusReason2? StatusReason { get; init; } 
    #else
    public ValidationStatusReason2? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the date and time when the status was issued.
    /// </summary>
    [IsoId("_TC94jW49EeiU9cctagi5ow")]
    [DisplayName("Status Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsDtTm")]
    #endif
    [IsoXmlTag("StsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? StatusDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? StatusDateTime { get; init; } 
    #else
    public System.DateTime? StatusDateTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
