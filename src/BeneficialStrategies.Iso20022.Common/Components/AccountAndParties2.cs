// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the account and the role of the party.
/// </summary>
[IsoId("_ApDrEC_9EeOKib24wnHaFg")]
[DisplayName("Account And Parties")]
public record AccountAndParties2
{
    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("_IIeC8C_9EeOKib24wnHaFg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CustomerAccount1 Account { get; init; }

    /// <summary>
    /// Specifies the role related to the account.
    /// </summary>
    [IsoId("_clKesC__EeOKib24wnHaFg")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public ValueList<AccountRole1> Role { get; init; } = [];

    // ID for the above is _clKesC__EeOKib24wnHaFg

    /// <summary>
    /// Additional information.
    /// </summary>
    [IsoId("_dQJnUC_9EeOKib24wnHaFg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax256Text> AdditionalInformation { get; init; } = [];
}
