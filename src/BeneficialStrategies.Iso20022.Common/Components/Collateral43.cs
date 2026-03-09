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
[IsoId("_otPoFAF1EeutW5-TpeYJhA")]
[DisplayName("Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Collateral43
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Collateral43 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Collateral43( CollateralAccount3 reqAccountIdentification,Summary2 reqReportSummary )
    {
        AccountIdentification = reqAccountIdentification;
        ReportSummary = reqReportSummary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the collateral account, that is the identification, the type and optionally the name.
    /// </summary>
    [IsoId("_otPoFgF1EeutW5-TpeYJhA")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralAccount3 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralAccount3 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAccount3 AccountIdentification { get; init; } 
    #else
    public CollateralAccount3 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Summary of the collateral valuation.
    /// </summary>
    [IsoId("_otPoFwF1EeutW5-TpeYJhA")]
    [DisplayName("Report Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSummry")]
    #endif
    [IsoXmlTag("RptSummry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Summary2 ReportSummary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Summary2 ReportSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Summary2 ReportSummary { get; init; } 
    #else
    public Summary2 ReportSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the collateral valuation that has been posted.
    /// </summary>
    [IsoId("_otPoFQF1EeutW5-TpeYJhA")]
    [DisplayName("Collateral Valuation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollValtn")]
    #endif
    [IsoXmlTag("CollValtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralValuation12? CollateralValuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralValuation12? CollateralValuation { get; init; } 
    #else
    public CollateralValuation12? CollateralValuation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
