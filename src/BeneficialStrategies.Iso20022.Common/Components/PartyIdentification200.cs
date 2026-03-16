// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_xKGb8VHcEeeRzt0J6TBeaA")]
[DisplayName("Party Identification")]
public record PartyIdentification200
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_xVtPAVHcEeeRzt0J6TBeaA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Type of entity.
    /// </summary>
    [IsoId("_SWcFAFHdEeeRzt0J6TBeaA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PartyType28Code? Type { get; init; }

    /// <summary>
    /// Other party type defined at national or private level.
    /// </summary>
    [IsoId("_GXZ6MPPnEeihCvvpsmGI2w")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Entity in charge of assigning an identification to a party.
    /// </summary>
    [IsoId("_xVtPA1HcEeeRzt0J6TBeaA")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public PartyType18Code? Assigner { get; init; }

    /// <summary>
    /// Country of the party.
    /// </summary>
    [IsoId("_xVtPBVHcEeeRzt0J6TBeaA")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Short name of the party.
    /// </summary>
    [IsoId("_xVtPB1HcEeeRzt0J6TBeaA")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }
}
