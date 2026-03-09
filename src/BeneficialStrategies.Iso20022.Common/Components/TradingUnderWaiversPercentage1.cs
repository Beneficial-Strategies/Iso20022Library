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
/// Specifies the details for the trading under waiver of the instrument.
/// </summary>
[IsoId("__YT0wJuKEeaPcol5ibnfBQ")]
[DisplayName("Trading Under Waivers Percentage")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradingUnderWaiversPercentage1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradingUnderWaiversPercentage1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradingUnderWaiversPercentage1( System.Decimal reqTradingUnderWaiverPercentage,System.String reqTradingVenue )
    {
        TradingUnderWaiverPercentage = reqTradingUnderWaiverPercentage;
        TradingVenue = reqTradingVenue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total percentage of trading under waiver of the instrument in this specific reporting period on this trading venue.
    /// </summary>
    [IsoId("_V9BX0JuLEeaPcol5ibnfBQ")]
    [DisplayName("Trading Under Waiver Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgUdrWvrPctg")]
    #endif
    [IsoXmlTag("TradgUdrWvrPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate TradingUnderWaiverPercentage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal TradingUnderWaiverPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal TradingUnderWaiverPercentage { get; init; } 
    #else
    public System.Decimal TradingUnderWaiverPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// The venue this trading under waiver percentage is in relation to.
    /// </summary>
    [IsoId("_ri_asJuLEeaPcol5ibnfBQ")]
    [DisplayName("Trading Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgVn")]
    #endif
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMICIdentifier TradingVenue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradingVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradingVenue { get; init; } 
    #else
    public System.String TradingVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Information for interpreting the result.
    /// </summary>
    [IsoId("_wreiAJuMEeaPcol5ibnfBQ")]
    [DisplayName("Disclaimer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsclmr")]
    #endif
    [IsoXmlTag("Dsclmr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Disclaimer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Disclaimer { get; init; } 
    #else
    public System.String? Disclaimer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
