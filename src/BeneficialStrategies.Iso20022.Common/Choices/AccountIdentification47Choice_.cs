// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification47Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification47Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(
        typeof(AccountIdentification47Choice.ForAllAccounts),
        nameof(AccountIdentification47Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification47Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification47Choice.AccountsListAndBalanceDetails)
    )]
    [IsoId("_9ju_YRukEeyhRdHRjakS2w")]
    [DisplayName("Account Identification 47 Choice")]
    public abstract record AccountIdentification47Choice_ { }
}
