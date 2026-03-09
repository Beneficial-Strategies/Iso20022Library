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
/// Quantity of a security.
/// </summary>
[IsoId("_So3dsdp-Ed-ak6NoX_4Aeg_-562125146")]
[DisplayName("Side Pocket Quantity And Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SidePocketQuantityAndAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total of quantity of units subscribed or redeemed in the lot or side pocket.
    /// </summary>
    [IsoId("_So3dstp-Ed-ak6NoX_4Aeg_-562125137")]
    [DisplayName("Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsNb")]
    #endif
    [IsoXmlTag("UnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? UnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? UnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1? UnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money invested or redeemed into the lot or side pocket.
    /// </summary>
    [IsoId("_So3ds9p-Ed-ak6NoX_4Aeg_1851394913")]
    [DisplayName("Ordered Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrdAmt")]
    #endif
    [IsoXmlTag("OrdrdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? OrderedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? OrderedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? OrderedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the financial instrument quantity invested or redeemed in the lot or side pocket.
    /// </summary>
    [IsoId("_So3dtNp-Ed-ak6NoX_4Aeg_-562124806")]
    [DisplayName("Holdings Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgsRate")]
    #endif
    [IsoXmlTag("HldgsRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? HoldingsRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? HoldingsRate { get; init; } 
    #else
    public System.Decimal? HoldingsRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
