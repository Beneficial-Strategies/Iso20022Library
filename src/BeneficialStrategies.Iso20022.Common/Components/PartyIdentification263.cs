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
[IsoId("_6LPHUSbNEeyhZIgCcGlTyA")]
[DisplayName("Party Identification")]
public record PartyIdentification263
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_6RtiwSbNEeyhZIgCcGlTyA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max11NumericText)]
    public required IsoMax11NumericText Identification { get; init; }

    /// <summary>
    /// Entity in charge of assigning an identification to a party.
    /// </summary>
    [IsoId("_6RtiwybNEeyhZIgCcGlTyA")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Country of the party.
    /// </summary>
    [IsoId("_6RtixSbNEeyhZIgCcGlTyA")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Short name of the party.
    /// </summary>
    [IsoId("_6RtixybNEeyhZIgCcGlTyA")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the party
    /// </summary>
    [IsoId("_6RtiySbNEeyhZIgCcGlTyA")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Additional identification of the party.
    /// </summary>
    [IsoId("_6RtiyybNEeyhZIgCcGlTyA")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public AdditionalData1? AdditionalIdentification { get; init; }

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_6RtizSbNEeyhZIgCcGlTyA")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData1? LocalData { get; init; }
}
