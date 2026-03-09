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
/// Facilitates the redemption of one or more lots.
/// </summary>
[IsoId("_Sd15cNp-Ed-ak6NoX_4Aeg_-767969447")]
[DisplayName("Lot Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LotDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LotDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LotDetails1( System.DateOnly reqTradeDate,System.String reqOrderReference )
    {
        TradeDate = reqTradeDate;
        OrderReference = reqOrderReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Description of the lot.
    /// </summary>
    [IsoId("_Sd15cdp-Ed-ak6NoX_4Aeg_186028060")]
    [DisplayName("Lot Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotDesc")]
    #endif
    [IsoXmlTag("LotDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? LotDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LotDescription { get; init; } 
    #else
    public System.String? LotDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Date the units were created.
    /// </summary>
    [IsoId("_Sd15ctp-Ed-ak6NoX_4Aeg_-1080360479")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate TradeDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly TradeDate { get; init; } 
    #else
    public System.DateOnly TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the original order that resulted in the lot.
    /// </summary>
    [IsoId("_Sd15c9p-Ed-ak6NoX_4Aeg_1722044927")]
    [DisplayName("Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrRef")]
    #endif
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OrderReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OrderReference { get; init; } 
    #else
    public System.String OrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Deal reference of the original subscription execution that resulted in the lot.
    /// </summary>
    [IsoId("_Sd15dNp-Ed-ak6NoX_4Aeg_658630436")]
    [DisplayName("Deal Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealRef")]
    #endif
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DealReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DealReference { get; init; } 
    #else
    public System.String? DealReference { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of the lot.
    /// </summary>
    [IsoId("_Sd15ddp-Ed-ak6NoX_4Aeg_-1763708618")]
    [DisplayName("Lot Quantity And Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotQtyAndAmt")]
    #endif
    [IsoXmlTag("LotQtyAndAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SidePocketQuantityAndAmount1? LotQuantityAndAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SidePocketQuantityAndAmount1? LotQuantityAndAmount { get; init; } 
    #else
    public SidePocketQuantityAndAmount1? LotQuantityAndAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
