// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Party7.
/// </summary>
[IsoId("_5Ta70OtOEe6GDu6DljhDaQ")]
[DisplayName("Trade Party7")]
public record TradeParty7
{
    /// <summary>
    /// Party Identification.
    /// </summary>
    [DisplayName("Party Identification")]
    [IsoXmlTag("")]
    public required PartyIdentification290 PartyIdentification { get; init; }

    /// <summary>
    /// Party Role.
    /// </summary>
    [DisplayName("Party Role")]
    [IsoXmlTag("")]
    public required PartyRole4Code PartyRole { get; init; }
}
