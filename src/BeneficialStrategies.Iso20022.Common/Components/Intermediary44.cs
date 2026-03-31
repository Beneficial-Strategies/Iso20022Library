// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products (Investment Funds).
/// </summary>
[IsoId("_AXBpQdLDEeiN28wlpBQScw")]
[DisplayName("Intermediary")]
public record Intermediary44
{
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_AoInY9LDEeiN28wlpBQScw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification136 Identification { get; init; }

    /// <summary>
    /// Function performed by the intermediary (investment funds).
    /// </summary>
    [IsoId("_AoInZdLDEeiN28wlpBQScw")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public Role6Choice_? Role { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_AoInZ9LDEeiN28wlpBQScw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account29? Account { get; init; }
}
