// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the elements used to uniquely identify a standing order.
/// </summary>
[IsoId("_ex2NcdcZEeqRFcf2R4bPBw")]
[DisplayName("Standing Order Identification")]
public record StandingOrderIdentification7
{
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_ezPUkdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount40 Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_ezPUk9cZEeqRFcf2R4bPBw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; }
}
