// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the details of an organisation.
/// </summary>
[IsoId("_BVSV3W49EeiU9cctagi5ow")]
[DisplayName("Party Identification")]
public record PartyIdentification138
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_BgdrEW49EeiU9cctagi5ow")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_BgdrE249EeiU9cctagi5ow")]
    [DisplayName("Legal Name")]
    [IsoXmlTag("LglNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? LegalName { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_BgdrFW49EeiU9cctagi5ow")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress24? PostalAddress { get; init; }

    /// <summary>
    /// Unique and unambiguous way to identify the party.
    /// </summary>
    [IsoId("_BgdrF249EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required Party43Choice_ Identification { get; init; }

    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_BgdrGW49EeiU9cctagi5ow")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }

    /// <summary>
    /// Indicates how to contact the party.
    /// </summary>
    [IsoId("_BgdrG249EeiU9cctagi5ow")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public Contact4? ContactDetails { get; init; }
}
