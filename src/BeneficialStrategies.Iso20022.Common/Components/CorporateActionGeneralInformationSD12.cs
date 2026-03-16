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
[IsoId("_M1H-YV2nEeOb__BffbPEig")]
[DisplayName("Corporate Action General Information SD")]
public record CorporateActionGeneralInformationSD12
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_NOuKI12nEeOb__BffbPEig")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// DTC processing domain/ category for event types.
    /// </summary>
    [IsoId("_NOuKJV2nEeOb__BffbPEig")]
    [DisplayName("Event Group")]
    [IsoXmlTag("EvtGrp")]
    public EventGroup1Code? EventGroup { get; init; }

    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action event type name. Used in place for the events that cannot be classified by ISO code and mapped to OTHR or when two or more distinct events (in DTCC model) use same ISO code and there are no additional data elements that distinguish those two or more events.
    /// </summary>
    [IsoId("_NOuKLV2nEeOb__BffbPEig")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public ExtendedEventType2Code? EventType { get; init; }

    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action sub event type name further defines the event type.
    /// </summary>
    [IsoId("_NOuKNV2nEeOb__BffbPEig")]
    [DisplayName("Sub Event Type")]
    [IsoXmlTag("SubEvtTp")]
    public DTCCSubEventType3Code? SubEventType { get; init; }

    /// <summary>
    /// Indicates whether the event is eligible for EDS (Elective Dividend Services) ISO20022 messaging.
    /// </summary>
    [IsoId("_NOuKPV2nEeOb__BffbPEig")]
    [DisplayName("EDS Messaging Eligibility Flag")]
    [IsoXmlTag("EDSMsggElgbltyFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EDSMessagingEligibilityFlag { get; init; }

    /// <summary>
    /// Unique number systemically assigned to all Lottery and Non-Lottery events announced in DTC Redemptions (REDS) Participant Terminal System (PTS)/ Particinant Browser System(PBS) function.
    /// </summary>
    [IsoId("_jFqBMF2nEeOb__BffbPEig")]
    [DisplayName("Redemption Identification")]
    [IsoXmlTag("RedId")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? RedemptionIdentification { get; init; }

    /// <summary>
    /// Identifies events that offer instruction processing specific to foreign currency payment (FCP) elections.
    /// </summary>
    [IsoId("_5Uu2AF2oEeOb__BffbPEig")]
    [DisplayName("DTCFCP Election Flag")]
    [IsoXmlTag("DTCFCPElctnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCFCPElectionFlag { get; init; }

    /// <summary>
    /// Indicates whether the event is being processed by DTC.
    /// </summary>
    [IsoId("_IZPXAF2pEeOb__BffbPEig")]
    [DisplayName("Asset Servicer Processing Flag")]
    [IsoXmlTag("AsstSvcrPrcgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AssetServicerProcessingFlag { get; init; }
}
