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
/// Provides the amount in the reporting currency and optionally in the original currency.
/// </summary>
[IsoId("_STHQJdp-Ed-ak6NoX_4Aeg_-1176417681")]
[DisplayName("Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amount2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Amount2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Amount2( ImpliedCurrencyAndAmount reqReportingAmount )
    {
        ReportingAmount = reqReportingAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount expressed in the original currency.
    /// </summary>
    [IsoId("_STHQJtp-Ed-ak6NoX_4Aeg_-1815431520")]
    [DisplayName("Original Currency Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCcyAmt")]
    #endif
    [IsoXmlTag("OrgnlCcyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? OriginalCurrencyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? OriginalCurrencyAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? OriginalCurrencyAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount expressed in the reporting currency.
    /// </summary>
    [IsoId("_STHQJ9p-Ed-ak6NoX_4Aeg_-1708296347")]
    [DisplayName("Reporting Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgAmt")]
    #endif
    [IsoXmlTag("RptgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount ReportingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount ReportingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount ReportingAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount ReportingAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
