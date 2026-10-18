// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPartyIdentification32"/>
[IsoId("_PaxxFdp-Ed-ak6NoX_4Aeg_-1092208077")]
[DisplayName("Party Identification")]
public partial record PartyIdentification32
{
    /// <inheritdoc cref="IPartyIdentification32.Name"/>
    [IsoId("_PaxxFtp-Ed-ak6NoX_4Aeg_-1092208075")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IPartyIdentification32.PostalAddress"/>
    [IsoId("_PaxxF9p-Ed-ak6NoX_4Aeg_-1092207954")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; }

    /// <inheritdoc cref="IPartyIdentification32.Identification"/>
    [IsoId("_PaxxGNp-Ed-ak6NoX_4Aeg_-1092207900")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party6Choice_? Identification { get; init; }

    /// <inheritdoc cref="IPartyIdentification32.CountryOfResidence"/>
    [IsoId("_PaxxGdp-Ed-ak6NoX_4Aeg_-1092208016")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }

    /// <inheritdoc cref="IPartyIdentification32.ContactDetails"/>
    [IsoId("_Pa7iENp-Ed-ak6NoX_4Aeg_935029789")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public ContactDetails2? ContactDetails { get; init; }
}
