// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the new account.
/// </summary>
[IsoId("_D6dWYA2kEeSNWNtJlXOAhg")]
[DisplayName("New Account")]
public record NewAccount1
{
    /// <summary>
    /// Details of the new account.
    /// </summary>
    [IsoId("_KBJAwA2kEeSNWNtJlXOAhg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount36 Account { get; init; }

    /// <summary>
    /// Party or parties to be identified in the context of account operations.
    /// </summary>
    [IsoId("_UbCz0A2kEeSNWNtJlXOAhg")]
    [DisplayName("Account Party")]
    [IsoXmlTag("AcctPty")]
    public ValueList<IndividualPerson19> AccountParty { get; init; } = [];

    // ID for the above is _UbCz0A2kEeSNWNtJlXOAhg

    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_Xw-N0A2kEeSNWNtJlXOAhg")]
    [DisplayName("Organisation")]
    [IsoXmlTag("Org")]
    public Organisation20? Organisation { get; init; }
}
