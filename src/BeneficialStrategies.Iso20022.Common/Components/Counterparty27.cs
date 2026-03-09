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
[IsoId("_BOdH0ZQKEeiILOjNP8ro1w")]
[DisplayName("Counterparty")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Counterparty27
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Counterparty27 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Counterparty27( OrganisationIdentification7Choice_ reqIdentification,CounterpartyTradeNature4Choice_ reqNature,TradingCapacity7Code reqTradingCapacity,OptionParty1Code reqCounterpartySide )
    {
        Identification = reqIdentification;
        Nature = reqNature;
        TradingCapacity = reqTradingCapacity;
        CounterpartySide = reqCounterpartySide;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the reporting counterparty of the contract.
    /// </summary>
    [IsoId("_BY0kwZQKEeiILOjNP8ro1w")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification7Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification7Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification7Choice_ Identification { get; init; } 
    #else
    public OrganisationIdentification7Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the reporting counterparty is a central counterparty, a financial, non-financial counterparty or other type of counterparty in accordance with regulation.
    /// </summary>
    [IsoId("_BY0kw5QKEeiILOjNP8ro1w")]
    [DisplayName("Nature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntr")]
    #endif
    [IsoXmlTag("Ntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CounterpartyTradeNature4Choice_ Nature { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CounterpartyTradeNature4Choice_ Nature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyTradeNature4Choice_ Nature { get; init; } 
    #else
    public CounterpartyTradeNature4Choice_ Nature { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the trading capacity of the seller.
    /// </summary>
    [IsoId("_BY0kxZQKEeiILOjNP8ro1w")]
    [DisplayName("Trading Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgCpcty")]
    #endif
    [IsoXmlTag("TradgCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradingCapacity7Code TradingCapacity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradingCapacity7Code TradingCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingCapacity7Code TradingCapacity { get; init; } 
    #else
    public TradingCapacity7Code TradingCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the reporting counterparty is a buyer or a seller.
    /// </summary>
    [IsoId("_BY0kx5QKEeiILOjNP8ro1w")]
    [DisplayName("Counterparty Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySd")]
    #endif
    [IsoXmlTag("CtrPtySd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionParty1Code CounterpartySide { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionParty1Code CounterpartySide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionParty1Code CounterpartySide { get; init; } 
    #else
    public OptionParty1Code CounterpartySide { get; set; } 
    #endif
    
    
    #nullable disable
    
}
