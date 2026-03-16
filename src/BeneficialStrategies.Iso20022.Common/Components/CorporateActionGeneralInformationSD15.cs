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
[IsoId("_rxB64WJSEeOfOt7Y7nAPUA")]
[DisplayName("Corporate Action General Information SD")]
public record CorporateActionGeneralInformationSD15
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_sKUkoWJSEeOfOt7Y7nAPUA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action event type name. Used in place for the events that cannot be classified by ISO Code and are marked as OTHR. Can be used in combination with DTCC sub event type (when provided) to identify the event. For an example: a distribution based on recapitalisation event will be presented as event type: OTHR in standard message. DTCC native event type would be Distribution (DIST) and DTCC sub event type would be Recapitalisation.
    /// </summary>
    [IsoId("_sKUko2JSEeOfOt7Y7nAPUA")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public ExtendedEventType2Code? EventType { get; init; }

    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) corporate action sub event type name further defines the event type. For an example: a cash dividend event eligible for dividend reinvestment at DTC election will be noted as event type: Cash Dividend (DVCA) and DTCC sub event type: DRIP( DTC only).
    /// </summary>
    [IsoId("_sKUkq2JSEeOfOt7Y7nAPUA")]
    [DisplayName("Sub Event Type")]
    [IsoXmlTag("SubEvtTp")]
    public DTCCSubEventType3Code? SubEventType { get; init; }
}
