// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security.
/// </summary>
[IsoId("4a677242-b4c0-4397-bce8-ca3243c74171")]
[DisplayName("Security Identification50")]
public record SecurityIdentification50
{
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the UN's International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("e2e9b966-a089-4f72-9f81-9e973c36e53d")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public IsoISINOct2015Identifier? ISIN { get; init; }

    /// <summary>
    /// Identification of a security by proprietary or domestic identification scheme.
    /// </summary>
    [IsoId("420496fa-2fd1-43fd-8ad3-cf8dedc0ea70")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public ValueList<OtherIdentification8> OtherIdentification { get; init; } = [];

    /// <summary>
    /// Textual description of a security instrument.
    /// </summary>
    [IsoId("9268ef9b-1cc0-4187-955c-36f76e5bcd19")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax140Text? Description { get; init; }
}
