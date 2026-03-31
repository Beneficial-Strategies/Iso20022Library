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
[IsoId("_TZpqoR6WEeOolf0-cMYhrw")]
[DisplayName("Intermediary")]
public record Intermediary25
{
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_Twak1R6WEeOolf0-cMYhrw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification2Choice_ Identification { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_Twak1x6WEeOolf0-cMYhrw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account14? Account { get; init; }

    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_ZURZgB6XEeOolf0-cMYhrw")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public Role4Choice_? Role { get; init; }
}
