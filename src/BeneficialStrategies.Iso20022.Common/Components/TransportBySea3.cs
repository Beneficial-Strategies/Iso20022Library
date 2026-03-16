// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related for the transportation of goods by sea.
/// </summary>
[IsoId("_SuYP39p-Ed-ak6NoX_4Aeg_-719790573")]
[DisplayName("Transport By Sea")]
public record TransportBySea3
{
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    [IsoId("_SuYP4Np-Ed-ak6NoX_4Aeg_-719790542")]
    [DisplayName("Port Of Loading")]
    [IsoXmlTag("PortOfLoadng")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PortOfLoading { get; init; }

    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    [IsoId("_SuiA0Np-Ed-ak6NoX_4Aeg_-719790520")]
    [DisplayName("Port Of Discharge")]
    [IsoXmlTag("PortOfDschrge")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    public SimpleValueList<System.String> PortOfDischarge { get; init; } = [];

    // ID for the above is _SuiA0Np-Ed-ak6NoX_4Aeg_-719790520

    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_SuiA0dp-Ed-ak6NoX_4Aeg_-719790397")]
    [DisplayName("Sea Carrier Name")]
    [IsoXmlTag("SeaCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SeaCarrierName { get; init; }
}
