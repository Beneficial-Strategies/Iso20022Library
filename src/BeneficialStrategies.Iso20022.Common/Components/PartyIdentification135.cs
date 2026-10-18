// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPartyIdentification135"/>
[IsoId("_6ClkRW48EeiU9cctagi5ow")]
[DisplayName("Party Identification")]
public partial record PartyIdentification135
{
    /// <inheritdoc cref="IPartyIdentification135.Name"/>
    [IsoId("_6L-Jw248EeiU9cctagi5ow")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IPartyIdentification135.PostalAddress"/>
    [IsoId("_6L-JxW48EeiU9cctagi5ow")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress24? PostalAddress { get; init; }

    /// <inheritdoc cref="IPartyIdentification135.Identification"/>
    [IsoId("_6L-Jx248EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party38Choice_? Identification { get; init; }

    /// <inheritdoc cref="IPartyIdentification135.CountryOfResidence"/>
    [IsoId("_6L-JyW48EeiU9cctagi5ow")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }

    /// <inheritdoc cref="IPartyIdentification135.ContactDetails"/>
    [IsoId("_6L-Jy248EeiU9cctagi5ow")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public Contact4? ContactDetails { get; init; }
}
