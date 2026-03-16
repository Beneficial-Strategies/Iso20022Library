// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action General Information SD61.
/// </summary>
[IsoId("_jRvF4aMwEe-4O7NbwmwJkQ")]
[DisplayName("Corporate Action General Information SD61")]
public partial record CorporateActionGeneralInformationSD61
{
    #nullable enable

    /// <summary>
    /// Event Group.
    /// </summary>
    [DisplayName("Event Group")]
    [IsoXmlTag("EvtGrp")]
    public EventGroup3Code? EventGroup { get; init; } 

    /// <summary>
    /// Place And Name.
    /// </summary>
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    public IsoMax350Text? PlaceAndName { get; init; } 

    /// <summary>
    /// Sub Event Type.
    /// </summary>
    [DisplayName("Sub Event Type")]
    [IsoXmlTag("SubEvtTp")]
    public DTCCSubEventType12Code? SubEventType { get; init; } 

    
    #nullable disable
    
}
