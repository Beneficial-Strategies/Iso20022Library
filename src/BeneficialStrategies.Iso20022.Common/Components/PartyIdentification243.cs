// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_JmJYYygxEeuqgbMAZaNiGw")]
[DisplayName("Party Identification")]
public record PartyIdentification243
{
    /// <summary>
    /// Legal entity.
    /// </summary>
    [IsoId("_JmJYZCgxEeuqgbMAZaNiGw")]
    [DisplayName("Legal Person")]
    [IsoXmlTag("LglPrsn")]
    public PartyIdentification237? LegalPerson { get; init; }

    /// <summary>
    /// Private person.
    /// </summary>
    [IsoId("_JmJYZSgxEeuqgbMAZaNiGw")]
    [DisplayName("Natural Person")]
    [IsoXmlTag("NtrlPrsn")]
    public PartyIdentification217? NaturalPerson { get; init; }
}
