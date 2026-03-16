// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification276.
/// </summary>
[IsoId("_xHwJLVx7Ee6fgZt44_IqFA")]
[DisplayName("Party Identification276")]
public record PartyIdentification276
{
    /// <summary>
    /// Legal Person.
    /// </summary>
    [DisplayName("Legal Person")]
    [IsoXmlTag("LglPrsn")]
    public ValueList<PartyIdentification275> LegalPerson { get; init; } = [];

    /// <summary>
    /// Natural Person.
    /// </summary>
    [DisplayName("Natural Person")]
    [IsoXmlTag("NtrlPrsn")]
    public ValueList<PartyIdentification217> NaturalPerson { get; init; } = [];
}
