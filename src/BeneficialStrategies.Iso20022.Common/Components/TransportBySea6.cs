// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related for the transportation of goods by sea.
/// </summary>
[IsoId("_WhO5YRriEeOVR9VN6fAMUg")]
[DisplayName("Transport By Sea")]
public partial record TransportBySea6
{
    #nullable enable
    
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    [IsoId("_W4LZwRriEeOVR9VN6fAMUg")]
    [DisplayName("Port Of Loading")]
    [IsoXmlTag("PortOfLoadng")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PortOfLoading { get; init; } 
    
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    [IsoId("_W4LZwxriEeOVR9VN6fAMUg")]
    [DisplayName("Port Of Discharge")]
    [IsoXmlTag("PortOfDschrge")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    public SimpleValueList<System.String> PortOfDischarge { get; init; } = [];
    // ID for the above is _W4LZwxriEeOVR9VN6fAMUg
    
    /// <summary>
    /// Name of a vessel.
    /// </summary>
    [IsoId("_zkY0kEUpEeOdq_w94HL6tQ")]
    [DisplayName("Vessel Name")]
    [IsoXmlTag("VsslNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? VesselName { get; init; } 
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_W4LZxxriEeOVR9VN6fAMUg")]
    [DisplayName("Sea Carrier Name")]
    [IsoXmlTag("SeaCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? SeaCarrierName { get; init; } 
    
    /// <summary>
    /// Country in which the carrier of the goods, for example, shipping company, is located or registered.
    /// </summary>
    [IsoId("_W4LZyRriEeOVR9VN6fAMUg")]
    [DisplayName("Sea Carrier Country")]
    [IsoXmlTag("SeaCrrierCtry")]
    public CountryCode? SeaCarrierCountry { get; init; } 
    
    /// <summary>
    /// Name of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_W4LZyxriEeOVR9VN6fAMUg")]
    [DisplayName("Carrier Agent Name")]
    [IsoXmlTag("CrrierAgtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? CarrierAgentName { get; init; } 
    
    /// <summary>
    /// Country of registration of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_W4LZzRriEeOVR9VN6fAMUg")]
    [DisplayName("Carrier Agent Country")]
    [IsoXmlTag("CrrierAgtCtry")]
    public CountryCode? CarrierAgentCountry { get; init; } 
    
    
    #nullable disable
    
}
