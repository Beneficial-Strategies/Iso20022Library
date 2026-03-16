// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party type and party identification information.
/// </summary>
[IsoId("_-EhOsXltEeG7BsjMvd1mEw_-2096165478")]
[DisplayName("Party And Type")]
public record PartyAndType1
{
    /// <summary>
    /// Type of additional party.
    /// </summary>
    [IsoId("_-EhOsnltEeG7BsjMvd1mEw_75095689")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PartyType1Choice_ Type { get; init; }

    /// <summary>
    /// Details related to the additional party.
    /// </summary>
    [IsoId("_-EhOs3ltEeG7BsjMvd1mEw_2077804920")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public PartyIdentification43? Party { get; init; }
}
