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
[IsoId("_-2COlK-jEemJ1NnLPsTFaw")]
[DisplayName("Party Identification")]
public record PartyIdentification224
{
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_-2COla-jEemJ1NnLPsTFaw")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required PersonName2 NameAndAddress { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_-2COlq-jEemJ1NnLPsTFaw")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_-2COl6-jEemJ1NnLPsTFaw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification198Choice_? Identification { get; init; }
}
