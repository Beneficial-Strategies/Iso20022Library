// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification of a person or an organisation.
/// </summary>
[IsoId("_6ClkRW48EeiU9cctagi5ow")]
[DisplayName("Party Identification")]
public record PartyIdentification135
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_6L-Jw248EeiU9cctagi5ow")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_6L-JxW48EeiU9cctagi5ow")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress24? PostalAddress { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a party.
    /// </summary>
    [IsoId("_6L-Jx248EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party38Choice_? Identification { get; init; }

    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_6L-JyW48EeiU9cctagi5ow")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }

    /// <summary>
    /// Set of elements used to indicate how to contact the party.
    /// </summary>
    [IsoId("_6L-Jy248EeiU9cctagi5ow")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public Contact4? ContactDetails { get; init; }
}
