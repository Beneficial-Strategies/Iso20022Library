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
[IsoId("_U8Fdjtp-Ed-ak6NoX_4Aeg_-34963760")]
[DisplayName("Transport By Sea")]
public partial record TransportBySea2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    [IsoId("_U8POgNp-Ed-ak6NoX_4Aeg_1368791264")]
    [DisplayName("Port Of Loading")]
    [IsoXmlTag("PortOfLoadng")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text PortOfLoading { get; init; } 
    
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    [IsoId("_U8POgdp-Ed-ak6NoX_4Aeg_1368791246")]
    [DisplayName("Port Of Discharge")]
    [IsoXmlTag("PortOfDschrge")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text PortOfDischarge { get; init; } 
    
    /// <summary>
    /// Name of a vessel.
    /// </summary>
    [IsoId("_U8POgtp-Ed-ak6NoX_4Aeg_436035004")]
    [DisplayName("Vessel Name")]
    [IsoXmlTag("VsslNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? VesselName { get; init; } 
    
    
    #nullable disable
    
}
