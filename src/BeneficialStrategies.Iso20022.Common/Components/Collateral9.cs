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
[IsoId("_67TXk2A4EeSMf75YyPqG7w")]
[DisplayName("Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Collateral9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Collateral9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Collateral9( CollateralAccount1 reqAccountIdentification,Summary1 reqReportSummary )
    {
        AccountIdentification = reqAccountIdentification;
        ReportSummary = reqReportSummary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the collateral account, that is the identification, the type and optionally the name.
    /// </summary>
    [IsoId("_7ZNbkWA4EeSMf75YyPqG7w")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralAccount1 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralAccount1 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAccount1 AccountIdentification { get; init; } 
    #else
    public CollateralAccount1 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the summary of the collateral valuation report.
    /// </summary>
    [IsoId("_7ZNbk2A4EeSMf75YyPqG7w")]
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
    [IsoId("_7ZNblWA4EeSMf75YyPqG7w")]
    [DisplayName("Collateral Valuation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollValtn")]
    #endif
    [IsoXmlTag("CollValtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralValuation2? CollateralValuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralValuation2? CollateralValuation { get; init; } 
    #else
    public CollateralValuation2? CollateralValuation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
