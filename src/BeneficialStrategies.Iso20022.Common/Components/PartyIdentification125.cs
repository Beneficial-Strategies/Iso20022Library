// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPartyIdentification125"/>
[IsoId("_jpFzL69UEeeJJK1oRb-jTw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification125
{
    /// <inheritdoc cref="IPartyIdentification125.Name"/>
    [IsoId("_jzRC069UEeeJJK1oRb-jTw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IPartyIdentification125.PostalAddress"/>
    [IsoId("_jzRp4a9UEeeJJK1oRb-jTw")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; }

    /// <inheritdoc cref="IPartyIdentification125.Identification"/>
    [IsoId("_jzRp469UEeeJJK1oRb-jTw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party34Choice_? Identification { get; init; }

    /// <inheritdoc cref="IPartyIdentification125.CountryOfResidence"/>
    [IsoId("_jzRp5a9UEeeJJK1oRb-jTw")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }

    /// <inheritdoc cref="IPartyIdentification125.ContactDetails"/>
    [IsoId("_jzRp569UEeeJJK1oRb-jTw")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public ContactDetails2? ContactDetails { get; init; }
}
