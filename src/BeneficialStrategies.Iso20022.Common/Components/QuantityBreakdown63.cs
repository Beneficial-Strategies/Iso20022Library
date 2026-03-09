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
/// Details of breakdown of a quantity.
/// </summary>
[IsoId("_vi1uUSqIEeyR9JrVGfaMKw")]
[DisplayName("Quantity Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QuantityBreakdown63
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_v6rmkyqIEeyR9JrVGfaMKw")]
    [DisplayName("Lot Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotNb")]
    #endif
    [IsoXmlTag("LotNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification37? LotNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification37? LotNumber { get; init; } 
    #else
    public GenericIdentification37? LotNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_v6rmmyqIEeyR9JrVGfaMKw")]
    [DisplayName("Lot Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotQty")]
    #endif
    [IsoXmlTag("LotQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity33Choice_? LotQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity33Choice_? LotQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity33Choice_? LotQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_v6rmoyqIEeyR9JrVGfaMKw")]
    [DisplayName("Securities Sub Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesSubBalTp")]
    #endif
    [IsoXmlTag("SctiesSubBalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; } 
    #else
    public GenericIdentification30? SecuritiesSubBalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    [IsoId("_v6rmpSqIEeyR9JrVGfaMKw")]
    [DisplayName("Lot Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotDtTm")]
    #endif
    [IsoXmlTag("LotDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? LotDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? LotDateTime { get; init; } 
    #else
    public DateAndDateTime2Choice_? LotDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    [IsoId("_v6rmrSqIEeyR9JrVGfaMKw")]
    [DisplayName("Lot Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotPric")]
    #endif
    [IsoXmlTag("LotPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price7? LotPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price7? LotPrice { get; init; } 
    #else
    public Price7? LotPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_v6rmtSqIEeyR9JrVGfaMKw")]
    [DisplayName("Type Of Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfPric")]
    #endif
    [IsoXmlTag("TpOfPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; } 
    #else
    public TypeOfPrice29Choice_? TypeOfPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
