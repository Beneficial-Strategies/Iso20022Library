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
/// Global collateral status of all transactions covered in the message, in the reporting currency, that is, the total of the exposure amount, of the posted collateral, of the margin amounts, of the accrued interest, of the fees or commissions and of the principals. In addition, it provides collateral-specific information.
/// </summary>
[IsoId("_5qoZgRIlEeyLzJfz3xPQNA")]
[DisplayName("Overall Collateral Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OverallCollateralDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OverallCollateralDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OverallCollateralDetails2( CollateralAmount15 reqValuationAmounts,DateAndDateTime2Choice_ reqValuationDate )
    {
        ValuationAmounts = reqValuationAmounts;
        ValuationDate = reqValuationDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details on the collateral valuation.
    /// </summary>
    [IsoId("_6CxMsRIlEeyLzJfz3xPQNA")]
    [DisplayName("Valuation Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnAmts")]
    #endif
    [IsoXmlTag("ValtnAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralAmount15 ValuationAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralAmount15 ValuationAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAmount15 ValuationAmounts { get; init; } 
    #else
    public CollateralAmount15 ValuationAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// The collateral excess/shortage expressed in the percentage of the collateral required.
    /// </summary>
    [IsoId("_6CxMsxIlEeyLzJfz3xPQNA")]
    [DisplayName("Margin Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnRate")]
    #endif
    [IsoXmlTag("MrgnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? MarginRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MarginRate { get; init; } 
    #else
    public System.Decimal? MarginRate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message.
    /// </summary>
    [IsoId("_6CxMtRIlEeyLzJfz3xPQNA")]
    [DisplayName("Global Collateral Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GblCollSts")]
    #endif
    [IsoXmlTag("GblCollSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralStatus1Code? GlobalCollateralStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralStatus1Code? GlobalCollateralStatus { get; init; } 
    #else
    public CollateralStatus1Code? GlobalCollateralStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation date/time of both the collateral and the exposure.
    /// </summary>
    [IsoId("_6CxMtxIlEeyLzJfz3xPQNA")]
    [DisplayName("Valuation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDt")]
    #endif
    [IsoXmlTag("ValtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ ValuationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ ValuationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ ValuationDate { get; init; } 
    #else
    public DateAndDateTime2Choice_ ValuationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information on the collateral.
    /// </summary>
    [IsoId("_6CxMuRIlEeyLzJfz3xPQNA")]
    [DisplayName("Collateral Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollAddtlDtls")]
    #endif
    [IsoXmlTag("CollAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? CollateralAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralAdditionalDetails { get; init; } 
    #else
    public System.String? CollateralAdditionalDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
