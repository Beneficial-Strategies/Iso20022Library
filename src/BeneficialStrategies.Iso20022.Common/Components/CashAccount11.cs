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
[IsoId("_SPrhqtp-Ed-ak6NoX_4Aeg_-1195018247")]
[DisplayName("Cash Account")]
public record CashAccount11
{
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SPrhq9p-Ed-ak6NoX_4Aeg_-1195018014")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required CashAccountIdentification1Choice_ Identification { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_SP1SoNp-Ed-ak6NoX_4Aeg_2096495319")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public FinancialInstitutionIdentification3Choice_? AccountServicer { get; init; }
}
