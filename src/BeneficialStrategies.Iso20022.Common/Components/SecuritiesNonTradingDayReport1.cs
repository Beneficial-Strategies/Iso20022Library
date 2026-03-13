// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details the non-working days of an entity.
/// </summary>
[IsoId("_zms14Gw0EeWD9e8QDBgUOw")]
[DisplayName("Securities Non Trading Day Report")]
public partial record SecuritiesNonTradingDayReport1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the specific venue this relates to - operating MIC, segment MIC, NCA
    /// </summary>
    [IsoId("_zmtc8Ww0EeWD9e8QDBgUOw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required TradingVenueIdentification1Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Provides the non working days of the identified venue. Details on why it is a non working day are also captured.
    /// </summary>
    [IsoId("_BieD0GxOEeWD9e8QDBgUOw")]
    [DisplayName("Non Working Day")]
    [IsoXmlTag("NonWorkgDay")]
    public ValueList<SecuritiesNonTradingDay1> NonWorkingDay { get; init; } = [];
    // ID for the above is _BieD0GxOEeWD9e8QDBgUOw
    
    
    #nullable disable
    
}
