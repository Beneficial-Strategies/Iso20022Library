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
/// Provides for each collateral account the report summary and the valuation of each piece of collateral.
/// </summary>
[IsoId("_z0NexYFvEeWtPe6Crjmeug")]
[DisplayName("Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Collateral13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Collateral13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Collateral13( CollateralAccount2 reqAccountIdentification,Summary1 reqReportSummary )
    {
        AccountIdentification = reqAccountIdentification;
        ReportSummary = reqReportSummary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the collateral account, that is the identification, the type and optionally the name.
    /// </summary>
    [IsoId("_0KFBEYFvEeWtPe6Crjmeug")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralAccount2 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralAccount2 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAccount2 AccountIdentification { get; init; } 
    #else
    public CollateralAccount2 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the summary of the collateral valuation report.
    /// </summary>
    [IsoId("_0KFBE4FvEeWtPe6Crjmeug")]
    [DisplayName("Report Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSummry")]
    #endif
    [IsoXmlTag("RptSummry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Summary1 ReportSummary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Summary1 ReportSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Summary1 ReportSummary { get; init; } 
    #else
    public Summary1 ReportSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additionnal information about the collateral valuation that has been posted.
    /// </summary>
    [IsoId("_0KFBFYFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Valuation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollValtn")]
    #endif
    [IsoXmlTag("CollValtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralValuation5? CollateralValuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralValuation5? CollateralValuation { get; init; } 
    #else
    public CollateralValuation5? CollateralValuation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
