// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action general information.
/// </summary>
[IsoId("_zzAnETDrEey2N-DB7H7A5A")]
[DisplayName("Corporate Action General Information SD")]
public record CorporateActionGeneralInformationSD53
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_0IK-wTDrEey2N-DB7H7A5A")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// DTC processing domain/ category for event types.
    /// </summary>
    [IsoId("_0IK-wzDrEey2N-DB7H7A5A")]
    [DisplayName("Event Group")]
    [IsoXmlTag("EvtGrp")]
    public EventGroup3Code? EventGroup { get; init; }

    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action sub event type name further defines the event type.
    /// </summary>
    [IsoId("_0IK-0zDrEey2N-DB7H7A5A")]
    [DisplayName("Sub Event Type")]
    [IsoXmlTag("SubEvtTp")]
    public DTCCSubEventType10Code? SubEventType { get; init; }
}
