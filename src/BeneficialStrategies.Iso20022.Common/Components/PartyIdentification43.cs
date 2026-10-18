// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPartyIdentification43"/>
[IsoId("_PWnCxdp-Ed-ak6NoX_4Aeg_-1518984548")]
[DisplayName("Party Identification")]
public partial record PartyIdentification43
{
    /// <inheritdoc cref="IPartyIdentification43.Name"/>
    [IsoId("_PWnCxtp-Ed-ak6NoX_4Aeg_-153832746")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IPartyIdentification43.PostalAddress"/>
    [IsoId("_PWnCx9p-Ed-ak6NoX_4Aeg_1607281642")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; }

    /// <inheritdoc cref="IPartyIdentification43.Identification"/>
    [IsoId("_PWnCyNp-Ed-ak6NoX_4Aeg_-579433194")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party11Choice_? Identification { get; init; }

    /// <inheritdoc cref="IPartyIdentification43.CountryOfResidence"/>
    [IsoId("_PWwzwNp-Ed-ak6NoX_4Aeg_2043450764")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }

    /// <inheritdoc cref="IPartyIdentification43.ContactDetails"/>
    [IsoId("_PWwzwdp-Ed-ak6NoX_4Aeg_-92375963")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public ContactDetails2? ContactDetails { get; init; }
}
