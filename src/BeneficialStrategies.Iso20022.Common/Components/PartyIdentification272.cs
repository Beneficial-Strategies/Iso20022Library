// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPartyIdentification272"/>
[IsoId("_vtFWJTEyEe6g-ffJsqGiSA")]
[DisplayName("Party Identification272")]
public partial record PartyIdentification272
{
    /// <inheritdoc cref="IPartyIdentification272.ContactDetails"/>
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public Contact13? ContactDetails { get; init; }

    /// <inheritdoc cref="IPartyIdentification272.CountryOfResidence"/>
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }

    /// <inheritdoc cref="IPartyIdentification272.Identification"/>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party52Choice_? Identification { get; init; }

    /// <inheritdoc cref="IPartyIdentification272.Name"/>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IPartyIdentification272.PostalAddress"/>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress27? PostalAddress { get; init; }
}
