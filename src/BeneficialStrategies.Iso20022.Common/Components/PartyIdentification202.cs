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
[IsoId("_Zfz85D6CEemPvNTzinB5Vw")]
[DisplayName("Party Identification")]
public record PartyIdentification202
{
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_Zfz85T6CEemPvNTzinB5Vw")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required PersonName1 NameAndAddress { get; init; }

    /// <summary>
    /// CONCAT
    /// </summary>
    [IsoId("_Zfz85j6CEemPvNTzinB5Vw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required NaturalPersonIdentification1 Identification { get; init; }
}
