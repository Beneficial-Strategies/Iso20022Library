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
/// Details the non-working days of an entity.
/// </summary>
[IsoId("_zms14Gw0EeWD9e8QDBgUOw")]
[DisplayName("Securities Non Trading Day Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesNonTradingDayReport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesNonTradingDayReport1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesNonTradingDayReport1( TradingVenueIdentification1Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the specific venue this relates to - operating MIC, segment MIC, NCA
    /// </summary>
    [IsoId("_zmtc8Ww0EeWD9e8QDBgUOw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradingVenueIdentification1Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradingVenueIdentification1Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingVenueIdentification1Choice_ Identification { get; init; } 
    #else
    public TradingVenueIdentification1Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the non working days of the identified venue. Details on why it is a non working day are also captured.
    /// </summary>
    [IsoId("_BieD0GxOEeWD9e8QDBgUOw")]
    [DisplayName("Non Working Day")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonWorkgDay")]
    #endif
    [IsoXmlTag("NonWorkgDay")]
    public ValueList<SecuritiesNonTradingDay1> NonWorkingDay { get; init; } = new ValueList<SecuritiesNonTradingDay1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _BieD0GxOEeWD9e8QDBgUOw
    
    
    #nullable disable
    
}
