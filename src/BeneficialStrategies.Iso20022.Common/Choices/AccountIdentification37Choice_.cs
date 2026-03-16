// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification37Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification37Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(
        typeof(AccountIdentification37Choice.ForAllAccounts),
        nameof(AccountIdentification37Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification37Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification37Choice.AccountsListAndBalanceDetails)
    )]
    [IsoId("_c4bUAZKQEeWHWpTQn1FFVg")]
    [DisplayName("Account Identification 37 Choice")]
    public abstract record AccountIdentification37Choice_ { }
}
