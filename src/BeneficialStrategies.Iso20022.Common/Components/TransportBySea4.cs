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
[IsoId("_SuiA0tp-Ed-ak6NoX_4Aeg_-1269157967")]
[DisplayName("Transport By Sea")]
public partial record TransportBySea4
{
    #nullable enable
    
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    [IsoId("_SuiA09p-Ed-ak6NoX_4Aeg_-1269157628")]
    [DisplayName("Port Of Loading")]
    [IsoXmlTag("PortOfLoadng")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text PortOfLoading { get; init; } 
    
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    [IsoId("_SuiA1Np-Ed-ak6NoX_4Aeg_-1269157906")]
    [DisplayName("Port Of Discharge")]
    [IsoXmlTag("PortOfDschrge")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text PortOfDischarge { get; init; } 
    
    /// <summary>
    /// Name of a vessel.
    /// </summary>
    [IsoId("_SuiA1dp-Ed-ak6NoX_4Aeg_-1269157965")]
    [DisplayName("Vessel Name")]
    [IsoXmlTag("VsslNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? VesselName { get; init; } 
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_SuiA1tp-Ed-ak6NoX_4Aeg_-1764443526")]
    [DisplayName("Sea Carrier Name")]
    [IsoXmlTag("SeaCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SeaCarrierName { get; init; } 
    
    
    #nullable disable
    
}
