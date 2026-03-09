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
/// Information related to counterparty identification.
/// </summary>
[IsoId("_ntOsvXg-Eeu3kecHd7QKUQ")]
[DisplayName("Counterparty")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Counterparty34
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Counterparty34 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Counterparty34( OrganisationIdentification10Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the reporting counterparty of the contract.
    /// </summary>
    [IsoId("_n79FMXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification10Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification10Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification10Choice_ Identification { get; init; } 
    #else
    public OrganisationIdentification10Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the reporting counterparty is a central counterparty, a financial, non-financial counterparty or other type of counterparty in accordance with regulation.
    /// </summary>
    [IsoId("_n79FM3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Nature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntr")]
    #endif
    [IsoXmlTag("Ntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CounterpartyTradeNature9Choice_? Nature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyTradeNature9Choice_? Nature { get; init; } 
    #else
    public CounterpartyTradeNature9Choice_? Nature { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the trading capacity of the seller.
    /// </summary>
    [IsoId("_n79FNXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Trading Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgCpcty")]
    #endif
    [IsoXmlTag("TradgCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingCapacity7Code? TradingCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingCapacity7Code? TradingCapacity { get; init; } 
    #else
    public TradingCapacity7Code? TradingCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the direction of the derivative transaction from the perspective of the reporting counterparty.
    /// Usage:
    /// DirectionOfTheFirstLeg should be used for most swaps and swap-like contracts including interest rate swaps, credit total return swaps, and equity swaps (except for credit default swaps, variance, volatility, and correlation swaps) as well as for the foreign exchange swaps, forwards and non-deliverable forwards.
    /// CounterpartySide should be used for the instruments such as most forwards and forward-like contracts (except for foreign exchange forwards and foreign exchange non-deliverable forwards); most options and option-like contracts including swaptions, caps and floors; credit default swaps; variance, volatility and correlation swaps; contracts for difference and spreadbets.
    /// </summary>
    [IsoId("_n79FN3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Drctn")]
    #endif
    [IsoXmlTag("Drctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Direction2Choice_? Direction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Direction2Choice_? Direction { get; init; } 
    #else
    public Direction2Choice_? Direction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
