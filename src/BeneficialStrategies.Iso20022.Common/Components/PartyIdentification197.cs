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
[IsoId("_JA4MkEXkEeegp_DADCe7HQ")]
[DisplayName("Party Identification")]
public record PartyIdentification197
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_Ykg5kEXkEeegp_DADCe7HQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Entity in charge of assigning an identification to a party.
    /// </summary>
    [IsoId("_jFiBQEXkEeegp_DADCe7HQ")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Country of the party.
    /// </summary>
    [IsoId("_sfFxoEXkEeegp_DADCe7HQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Short name of the party.
    /// </summary>
    [IsoId("_J03_4EXlEeegp_DADCe7HQ")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Additional identification of the party.
    /// </summary>
    [IsoId("_zyHOkBqVEeqH1IQNpbVpEw")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; }
}
