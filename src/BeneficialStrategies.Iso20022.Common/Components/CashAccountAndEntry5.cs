// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Account And Entry5.
/// </summary>
[IsoId("_18F2KzEyEe6g-ffJsqGiSA")]
[DisplayName("Cash Account And Entry5")]
public record CashAccountAndEntry5
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount43 Account { get; init; }

    /// <summary>
    /// Entry.
    /// </summary>
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public CashEntry2? Entry { get; init; }
}
