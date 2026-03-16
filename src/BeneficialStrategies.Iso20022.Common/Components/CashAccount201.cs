// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an account.
/// </summary>
[IsoId("_tkpXgYirEeefvMoXmllHqg")]
[DisplayName("Cash Account")]
public record CashAccount201
{
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_tzqq84irEeefvMoXmllHqg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentificationAndName5 Identification { get; init; }

    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("_tzqq9YirEeefvMoXmllHqg")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public FinancialInstitutionIdentification15? AccountServicer { get; init; }
}
