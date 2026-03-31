// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// New Account4.
/// </summary>
[IsoId("_3WTKQTEyEe6g-ffJsqGiSA")]
[DisplayName("New Account4")]
public record NewAccount4
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount43 Account { get; init; }

    /// <summary>
    /// Account Party.
    /// </summary>
    [DisplayName("Account Party")]
    [IsoXmlTag("AcctPty")]
    public ValueList<IndividualPerson44> AccountParty { get; init; } = [];

    /// <summary>
    /// Organisation.
    /// </summary>
    [DisplayName("Organisation")]
    [IsoXmlTag("Org")]
    public Organisation43? Organisation { get; init; }
}
