// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
[IsoId("_G4Tlj4fuEeevKP8c-ilVhA")]
[DisplayName("Intermediary")]
public record Intermediary42
{
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_HKTUY4fuEeevKP8c-ilVhA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification113 Identification { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_HKTUZYfuEeevKP8c-ilVhA")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account25? Account { get; init; }

    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_HKTUZ4fuEeevKP8c-ilVhA")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public Role4Choice_? Role { get; init; }
}
