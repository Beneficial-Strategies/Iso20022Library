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
[IsoId("_k1ehMagWEee4dcI_a2P2CQ")]
[DisplayName("Party Identification")]
public record PartyIdentification204
{
    /// <summary>
    /// Identification of the acceptor.
    /// ISO 8583 bit 42
    /// </summary>
    [IsoId("_lDBN8agWEee4dcI_a2P2CQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Entity in charge of assigning an identification to a party.
    /// </summary>
    [IsoId("_lDBN86gWEee4dcI_a2P2CQ")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Country of the party.
    /// </summary>
    [IsoId("_lDBN9agWEee4dcI_a2P2CQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Short name of the party.
    /// </summary>
    [IsoId("_lDBN96gWEee4dcI_a2P2CQ")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Additional identification assigned to the party.
    /// </summary>
    [IsoId("_82m-8KgWEee4dcI_a2P2CQ")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalIdentification { get; init; }

    /// <summary>
    /// Name and location of the card acceptor as appearing on the receipt or the statement of account of the cardholder. May contain location information relevant to the cardholder.
    /// ISO 8583 bit 43.
    /// </summary>
    [IsoId("_SMdRoaZAEeiva6IOmhpVHw")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public required IsoMax99Text NameAndLocation { get; init; }
}
