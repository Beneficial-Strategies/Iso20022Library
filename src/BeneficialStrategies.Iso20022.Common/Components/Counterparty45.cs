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
[IsoId("_x_a7MQz1Ee2YoLD-1vFj0g")]
[DisplayName("Counterparty")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Counterparty45
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Counterparty45 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Counterparty45( PartyIdentification248Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the reporting counterparty of the contract.
    /// </summary>
    [IsoId("_yANlYQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification248Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification248Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification248Choice_ Identification { get; init; } 
    #else
    public PartyIdentification248Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the reporting counterparty is a central counterparty, a financial, non-financial counterparty or other type of counterparty in accordance with regulation.
    /// </summary>
    [IsoId("_yANlYwz1Ee2YoLD-1vFj0g")]
    [DisplayName("Nature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntr")]
    #endif
    [IsoXmlTag("Ntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CounterpartyTradeNature15Choice_? Nature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyTradeNature15Choice_? Nature { get; init; } 
    #else
    public CounterpartyTradeNature15Choice_? Nature { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the trading capacity of the seller.
    /// </summary>
    [IsoId("_yANlZQz1Ee2YoLD-1vFj0g")]
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
    /// Indicates the direction or side of the derivative transaction from the perspective of the reporting counterparty. 
    /// Usage:
    /// CounterpartySide should be used for the instruments such as most forwards and forward-like contracts (except for foreign exchange forwards and foreign exchange non-deliverable forwards); most options and option-like contracts including swaptions, caps and floors; credit default swaps; variance, volatility and correlation swaps; contracts for difference and spreadbets.
    /// </summary>
    [IsoId("_yANlZwz1Ee2YoLD-1vFj0g")]
    [DisplayName("Direction Or Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrctnOrSd")]
    #endif
    [IsoXmlTag("DrctnOrSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Direction4Choice_? DirectionOrSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Direction4Choice_? DirectionOrSide { get; init; } 
    #else
    public Direction4Choice_? DirectionOrSide { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the trading desk or trader responsible for the decision of entering into or execution of the transaction.
    /// </summary>
    [IsoId("_50_lYBZuEe27wrM4RUjLog")]
    [DisplayName("Trader Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradrLctn")]
    #endif
    [IsoXmlTag("TradrLctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? TraderLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TraderLocation { get; init; } 
    #else
    public string? TraderLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the trade party or the branch/office of the trade party to which the transaction is booked.
    /// </summary>
    [IsoId("_-kfaYBZuEe27wrM4RUjLog")]
    [DisplayName("Booking Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookgLctn")]
    #endif
    [IsoXmlTag("BookgLctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? BookingLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? BookingLocation { get; init; } 
    #else
    public string? BookingLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the reporting exemption of a counterparty.
    /// </summary>
    [IsoId("_EDG10BaIEe27wrM4RUjLog")]
    [DisplayName("Reporting Exemption")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgXmptn")]
    #endif
    [IsoXmlTag("RptgXmptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportingExemption1? ReportingExemption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingExemption1? ReportingExemption { get; init; } 
    #else
    public ReportingExemption1? ReportingExemption { get; set; } 
    #endif
    
    
    #nullable disable
    
}
