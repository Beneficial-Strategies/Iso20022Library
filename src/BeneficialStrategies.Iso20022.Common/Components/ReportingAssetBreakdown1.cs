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
/// Specifies the breakdown of a reported amount that can be split across a range of assets: bonds, cash, equities, or another asset class.
/// </summary>
[IsoId("_J02CgDWzEemdWfjs3tykFQ")]
[DisplayName("Reporting Asset Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportingAssetBreakdown1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportingAssetBreakdown1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportingAssetBreakdown1( ProductType6Code reqReportingAssetType,ActiveCurrencyAndAmount reqAmount )
    {
        ReportingAssetType = reqReportingAssetType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Class of the asset which is a component of the breakdown.
    /// </summary>
    [IsoId("_f9yPkDWzEemdWfjs3tykFQ")]
    [DisplayName("Reporting Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgAsstTp")]
    #endif
    [IsoXmlTag("RptgAsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProductType6Code ReportingAssetType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProductType6Code ReportingAssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductType6Code ReportingAssetType { get; init; } 
    #else
    public ProductType6Code ReportingAssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the reporting asset.
    /// </summary>
    [IsoId("_xu3rkDWzEemdWfjs3tykFQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the reporting asset.
    /// </summary>
    [IsoId("_9bzMwDWzEemdWfjs3tykFQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
