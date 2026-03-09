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
[IsoId("_9s6WsePHEea7_eMQH225xA")]
[DisplayName("Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amount3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Amount3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Amount3( ActiveCurrencyAndAmount reqReportingAmount )
    {
        ReportingAmount = reqReportingAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount expressed in the original currency.
    /// </summary>
    [IsoId("_94OO0ePHEea7_eMQH225xA")]
    [DisplayName("Original Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlAmt")]
    #endif
    [IsoXmlTag("OrgnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? OriginalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount expressed in the reporting currency.
    /// </summary>
    [IsoId("_EAsB4OPIEea7_eMQH225xA")]
    [DisplayName("Reporting Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgAmt")]
    #endif
    [IsoXmlTag("RptgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount ReportingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount ReportingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount ReportingAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount ReportingAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
