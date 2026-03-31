// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used for identifying an account.
/// </summary>
[IsoId("_HvbJUSYFEeWJkOUkQWu90g")]
[DisplayName("Cash Account")]
public record CashAccount34
{
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_ILGYsyYFEeWJkOUkQWu90g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentificationAndName5 Identification { get; init; }

    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("_ILGYtSYFEeWJkOUkQWu90g")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public FinancialInstitutionIdentification7Choice_? AccountServicer { get; init; }
}
