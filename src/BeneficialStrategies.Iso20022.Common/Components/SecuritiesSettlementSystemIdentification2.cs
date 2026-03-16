// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the securities settlement system used in a settlement process.
/// </summary>
[IsoId("_h-yqwR2yEeqF2P5v-Rtejg")]
[DisplayName("Securities Settlement System Identification")]
public record SecuritiesSettlementSystemIdentification2
{
    /// <summary>
    /// Identification of the securities settlement system.
    /// </summary>
    [IsoId("_iAmBkR2yEeqF2P5v-Rtejg")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SystemIdentification { get; init; }

    /// <summary>
    /// Name of the securities settlement system.
    /// </summary>
    [IsoId("_iAmBkx2yEeqF2P5v-Rtejg")]
    [DisplayName("System Name")]
    [IsoXmlTag("SysNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SystemName { get; init; }

    /// <summary>
    /// Country code for the jurisdiction in which the CSD is established.
    /// </summary>
    [IsoId("_iAmBlR2yEeqF2P5v-Rtejg")]
    [DisplayName("Country Of Jurisdiction")]
    [IsoXmlTag("CtryOfJursdctn")]
    public CountryCode? CountryOfJurisdiction { get; init; }

    /// <summary>
    /// Corporate name of the CSD.
    /// </summary>
    [IsoId("_iAmBlx2yEeqF2P5v-Rtejg")]
    [DisplayName("CSD Legal Name")]
    [IsoXmlTag("CSDLglNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? CSDLegalName { get; init; }

    /// <summary>
    /// Legal entity identification of the CSD operating the securities settlement system.
    /// </summary>
    [IsoId("_iAmBmR2yEeqF2P5v-Rtejg")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Party (such as a person or a team) responsible for the report sent by the CSD.
    /// </summary>
    [IsoId("_iAmBmx2yEeqF2P5v-Rtejg")]
    [DisplayName("Responsible Party")]
    [IsoXmlTag("RspnsblPty")]
    public ValueList<Contact9> ResponsibleParty { get; init; } = [];
}
