// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to provide information about the dates related to securities movement.
/// </summary>
[IsoId("_2uSBQzE9EeG99IlTgANSrw")]
[DisplayName("Security Date 8 SD")]
public partial record SecurityDate8SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_D38hYFPIEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Settlement date for the transaction where the new security is issued. 
    /// 発行日決済日程情報/決済日.
    /// </summary>
    [IsoId("_KSEkQDEuEeGHQep4LV7ygg")]
    [DisplayName("Settlement Date Of New Security")]
    [IsoXmlTag("SttlmDtOfNewScty")]
    public DateFormat22Choice_? SettlementDateOfNewSecurity { get; init; } 
    
    /// <summary>
    /// Date/time at which trading of a security is suspended as the result of an event.
    /// </summary>
    [IsoId("_Sd8_kJz-EeKJcPdKDye9aA")]
    [DisplayName("Trading Suspended Date")]
    [IsoXmlTag("TradgSspdDt")]
    public DateFormat22Choice_? TradingSuspendedDate { get; init; } 
    
    
    #nullable disable
    
}
