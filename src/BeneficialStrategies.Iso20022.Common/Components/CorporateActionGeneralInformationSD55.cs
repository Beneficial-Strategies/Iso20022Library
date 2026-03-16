// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action General Information SD55.
/// </summary>
[IsoId("_whRewaMvEe-4O7NbwmwJkQ")]
[DisplayName("Corporate Action General Information SD55")]
public partial record CorporateActionGeneralInformationSD55
{
    #nullable enable

    /// <summary>
    /// Asset Servicer Processing Flag.
    /// </summary>
    [DisplayName("Asset Servicer Processing Flag")]
    [IsoXmlTag("AsstSvcrPrcgFlg")]
    public IsoYesNoIndicator? AssetServicerProcessingFlag { get; init; } 

    /// <summary>
    /// DTCFCP Election Flag.
    /// </summary>
    [DisplayName("DTCFCP Election Flag")]
    [IsoXmlTag("DTCFCPElctnFlg")]
    public IsoYesNoIndicator? DTCFCPElectionFlag { get; init; } 

    /// <summary>
    /// Event Group.
    /// </summary>
    [DisplayName("Event Group")]
    [IsoXmlTag("EvtGrp")]
    public EventGroup1Code? EventGroup { get; init; } 

    /// <summary>
    /// Event Type.
    /// </summary>
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public ExtendedEventType6Code? EventType { get; init; } 

    /// <summary>
    /// Instruction Messaging Eligibility Flag.
    /// </summary>
    [DisplayName("Instruction Messaging Eligibility Flag")]
    [IsoXmlTag("InstrMsggElgbltyFlg")]
    public IsoYesNoIndicator? InstructionMessagingEligibilityFlag { get; init; } 

    /// <summary>
    /// Place And Name.
    /// </summary>
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    public IsoMax350Text? PlaceAndName { get; init; } 

    /// <summary>
    /// Redemption Identification.
    /// </summary>
    [DisplayName("Redemption Identification")]
    [IsoXmlTag("RedId")]
    public IsoMax10NumericText? RedemptionIdentification { get; init; } 

    /// <summary>
    /// Sub Event Type.
    /// </summary>
    [DisplayName("Sub Event Type")]
    [IsoXmlTag("SubEvtTp")]
    public DTCCSubEventType11Code? SubEventType { get; init; } 

    
    #nullable disable
    
}
