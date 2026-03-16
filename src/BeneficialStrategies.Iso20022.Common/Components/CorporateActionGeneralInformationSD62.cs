// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action General Information SD62.
/// </summary>
[IsoId("_rSVfQaMwEe-4O7NbwmwJkQ")]
[DisplayName("Corporate Action General Information SD62")]
public record CorporateActionGeneralInformationSD62
{
    /// <summary>
    /// Event Group.
    /// </summary>
    [DisplayName("Event Group")]
    [IsoXmlTag("EvtGrp")]
    public EventGroup2Code? EventGroup { get; init; }

    /// <summary>
    /// Event Type.
    /// </summary>
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public ExtendedEventType6Code? EventType { get; init; }

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
    public DTCCSubEventType11Code? SubEventType { get; init; }
}
