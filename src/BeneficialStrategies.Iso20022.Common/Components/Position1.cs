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
/// Attributes of a position in a financial instrument or financial product.
/// </summary>
[IsoId("_hpBo0LC8EeaSl6vJk5Bd8w")]
[DisplayName("Position")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Position1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Position1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Position1( System.String reqProductIdentification,ActiveCurrencyAnd24Amount reqGrossNotional,AmountAndDirection102 reqNetNotional,ActiveCurrencyAndAmount reqGrossMarketValue )
    {
        ProductIdentification = reqProductIdentification;
        GrossNotional = reqGrossNotional;
        NetNotional = reqNetNotional;
        GrossMarketValue = reqGrossMarketValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// CCP’s unique internal identifier for product.
    /// </summary>
    [IsoId("_pAx5gLC8EeaSl6vJk5Bd8w")]
    [DisplayName("Product Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctId")]
    #endif
    [IsoXmlTag("PdctId")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax256Text ProductIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProductIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProductIdentification { get; init; } 
    #else
    public System.String ProductIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Obligations of a clearing member with respect to a central counterparty based on the position at end of day.
    /// </summary>
    [IsoId("_9_UI8LC8EeaSl6vJk5Bd8w")]
    [DisplayName("Risk Requirement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskRqrmnt")]
    #endif
    [IsoXmlTag("RskRqrmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EndOfDayRequirement1? RiskRequirement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EndOfDayRequirement1? RiskRequirement { get; init; } 
    #else
    public EndOfDayRequirement1? RiskRequirement { get; set; } 
    #endif
    
    /// <summary>
    /// Gross notional of positions of the product without netting of long/short positions, or delta equivalent notional for options.
    /// </summary>
    [IsoId("_kmlCQLDAEeaSl6vJk5Bd8w")]
    [DisplayName("Gross Notional")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssNtnl")]
    #endif
    [IsoXmlTag("GrssNtnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAnd24Amount GrossNotional { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAnd24Amount GrossNotional { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd24Amount GrossNotional { get; init; } 
    #else
    public ActiveCurrencyAnd24Amount GrossNotional { get; set; } 
    #endif
    
    /// <summary>
    /// Net notional of positions of the product with netting between long and short positions, or delta equivalent notional for options. Indicates whether net long position is positive.
    /// </summary>
    [IsoId("_tsKGsLDAEeaSl6vJk5Bd8w")]
    [DisplayName("Net Notional")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetNtnl")]
    #endif
    [IsoXmlTag("NetNtnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 NetNotional { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 NetNotional { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 NetNotional { get; init; } 
    #else
    public AmountAndDirection102 NetNotional { get; set; } 
    #endif
    
    /// <summary>
    /// Change in value of position for a unit change in the index. Usage: for interest rate swaps the PV01 of the gross position, for credit default swaps the DV01 of the gross position, for index products with a fixed value per unit move, the total weighted value of a one unit move in the index for the gross contracts in the position, weighted by the delta of the contracts in the position.
    /// </summary>
    [IsoId("_pDrzcOPIEea7_eMQH225xA")]
    [DisplayName("Gross Delta Equivalent Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssDltaEqvtVal")]
    #endif
    [IsoXmlTag("GrssDltaEqvtVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? GrossDeltaEquivalentValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? GrossDeltaEquivalentValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? GrossDeltaEquivalentValue { get; set; } 
    #endif
    
    /// <summary>
    /// Change in value of position for a unit change in the index. Usage: for interest rate swaps the PV01 of the net position, for credit default swaps the DV01 of the net position, for index products with a fixed value per unit move, the total weighted value of a one unit move in the index for the net contracts in the position, weighted by the delta of the contracts in the position. Indicates whether net long position is positive.
    /// </summary>
    [IsoId("_sNRakOPIEea7_eMQH225xA")]
    [DisplayName("Net Delta Equivalent Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetDltaEqvtVal")]
    #endif
    [IsoXmlTag("NetDltaEqvtVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection102? NetDeltaEquivalentValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102? NetDeltaEquivalentValue { get; init; } 
    #else
    public AmountAndDirection102? NetDeltaEquivalentValue { get; set; } 
    #endif
    
    /// <summary>
    /// Gross weighted quantity of the lots in the position weighted by the delta of the contracts in the position.
    /// </summary>
    [IsoId("_v4CcIOPIEea7_eMQH225xA")]
    [DisplayName("Gross Delta Equivalent Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssDltaEqvtQty")]
    #endif
    [IsoXmlTag("GrssDltaEqvtQty")]
    [IsoSimpleType(IsoSimpleType.NonNegativeFraction5DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNonNegativeFraction5DecimalNumber? GrossDeltaEquivalentQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? GrossDeltaEquivalentQuantity { get; init; } 
    #else
    public System.UInt64? GrossDeltaEquivalentQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Net weighted quantity of the lots in the position weighted by the delta of the contracts in the position.
    /// </summary>
    [IsoId("_yafx0OPIEea7_eMQH225xA")]
    [DisplayName("Net Delta Equivalent Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetDltaEqvtQty")]
    #endif
    [IsoXmlTag("NetDltaEqvtQty")]
    [IsoSimpleType(IsoSimpleType.Fraction5DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoFraction5DecimalNumber? NetDeltaEquivalentQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NetDeltaEquivalentQuantity { get; init; } 
    #else
    public System.UInt64? NetDeltaEquivalentQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Gross market value of the positions of the product without netting of long/short positions.
    /// </summary>
    [IsoId("_Cx7KsDT1EemwtJBLtapBmw")]
    [DisplayName("Gross Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssMktVal")]
    #endif
    [IsoXmlTag("GrssMktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount GrossMarketValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount GrossMarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount GrossMarketValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount GrossMarketValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
