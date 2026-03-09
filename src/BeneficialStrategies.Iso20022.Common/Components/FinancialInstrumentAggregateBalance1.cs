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
/// Aggregated position of holdings held in a securities account for a specified financial instrument.
/// </summary>
[IsoId("_1TSje4jiEeONZKAAW4pOaQ")]
[DisplayName("Financial Instrument Aggregate Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAggregateBalance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentAggregateBalance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentAggregateBalance1( System.DateOnly reqItemDate,FinancialInstrumentAggregateBalance1Choice_ reqHoldings )
    {
        ItemDate = reqItemDate;
        Holdings = reqHoldings;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of the line of holding in the statement.
    /// </summary>
    [IsoId("_1TSjfIjiEeONZKAAW4pOaQ")]
    [DisplayName("Item Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmDt")]
    #endif
    [IsoXmlTag("ItmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ItemDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ItemDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ItemDate { get; init; } 
    #else
    public System.DateOnly ItemDate { get; set; } 
    #endif
    
    /// <summary>
    /// Balances and sub-balances attributed to the holding.
    /// </summary>
    [IsoId("_SAtY8aCDEeOEyO7fCl8lLA")]
    [DisplayName("Holdings")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hldgs")]
    #endif
    [IsoXmlTag("Hldgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentAggregateBalance1Choice_ Holdings { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentAggregateBalance1Choice_ Holdings { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAggregateBalance1Choice_ Holdings { get; init; } 
    #else
    public FinancialInstrumentAggregateBalance1Choice_ Holdings { get; set; } 
    #endif
    
    /// <summary>
    /// Details on the price value, type and source.
    /// </summary>
    [IsoId("_KMa34TywEeSBD_ZW60GwCQ")]
    [DisplayName("Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pric")]
    #endif
    [IsoXmlTag("Pric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price6? Price { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price6? Price { get; init; } 
    #else
    public Price6? Price { get; set; } 
    #endif
    
    
    #nullable disable
    
}
