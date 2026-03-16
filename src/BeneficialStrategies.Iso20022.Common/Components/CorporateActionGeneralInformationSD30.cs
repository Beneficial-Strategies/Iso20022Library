// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action general information details.
/// </summary>
[IsoId("_0iDaEb5XEeexmbB7KsjCwA")]
[DisplayName("Corporate Action General Information SD")]
public record CorporateActionGeneralInformationSD30
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_0znEIb5XEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// DTC processing domain/ category for event types.
    /// </summary>
    [IsoId("_0znEI75XEeexmbB7KsjCwA")]
    [DisplayName("Event Group")]
    [IsoXmlTag("EvtGrp")]
    public EventGroup1Code? EventGroup { get; init; }

    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action event type name. Used in place for the events that cannot be classified by ISO code and mapped to OTHR or when two or more distinct events (in DTCC model) use same ISO code and there are no additional data elements that distinguish those two or more events.
    /// </summary>
    [IsoId("_0znEK75XEeexmbB7KsjCwA")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public ExtendedEventType6Code? EventType { get; init; }

    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action sub event type name further defines the event type.
    /// </summary>
    [IsoId("_0znEM75XEeexmbB7KsjCwA")]
    [DisplayName("Sub Event Type")]
    [IsoXmlTag("SubEvtTp")]
    public DTCCSubEventType6Code? SubEventType { get; init; }

    /// <summary>
    /// Unique number systemically assigned to all lottery and non-lottery events announced in DTC redemptions (REDS) participant terminal system (PTS)/ participant browser system(PBS) function.
    /// </summary>
    [IsoId("_0znEO75XEeexmbB7KsjCwA")]
    [DisplayName("Redemption Identification")]
    [IsoXmlTag("RedId")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? RedemptionIdentification { get; init; }
}
