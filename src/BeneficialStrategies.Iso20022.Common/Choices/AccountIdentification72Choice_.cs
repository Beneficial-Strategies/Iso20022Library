// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Identification72Choice.
    /// </summary>
    [KnownType(typeof(AccountIdentification72Choice.AccountsListAndBalanceDetails))]
    [KnownType(typeof(AccountIdentification72Choice.ForAllAccounts))]
    [JsonDerivedType(
        typeof(AccountIdentification72Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification72Choice.AccountsListAndBalanceDetails)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification72Choice.ForAllAccounts),
        nameof(AccountIdentification72Choice.ForAllAccounts)
    )]
    [IsoId("_6AKZF4-9Ee-COKgew96POA")]
    [DisplayName("Account Identification72Choice")]
    public abstract record AccountIdentification72Choice_ { }
}
