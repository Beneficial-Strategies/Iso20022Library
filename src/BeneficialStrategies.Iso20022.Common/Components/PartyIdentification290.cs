// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification290.
/// </summary>
[IsoId("_iDYCVwF_Ee-nrucbNEkskA")]
[DisplayName("Party Identification290")]
public record PartyIdentification290
{
    /// <summary>
    /// Contact Details.
    /// </summary>
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public Contact4? ContactDetails { get; init; }

    /// <summary>
    /// Country Of Residence.
    /// </summary>
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party58Choice_? Identification { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Postal Address.
    /// </summary>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress24? PostalAddress { get; init; }
}
