// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Identification77Choice.
    /// </summary>
    [KnownType(typeof(AccountIdentification77Choice.AccountsListAndBalanceDetails))]
    [KnownType(typeof(AccountIdentification77Choice.ForAllAccounts))]
    [JsonDerivedType(
        typeof(AccountIdentification77Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification77Choice.AccountsListAndBalanceDetails)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification77Choice.ForAllAccounts),
        nameof(AccountIdentification77Choice.ForAllAccounts)
    )]
    [IsoId("_nF16E5t3Ee-wQIOX0djF2w")]
    [DisplayName("Account Identification77Choice")]
    public abstract record AccountIdentification77Choice_ { }
}
