// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification12Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification12Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(
        typeof(AccountIdentification12Choice.ForAllAccounts),
        nameof(AccountIdentification12Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification12Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification12Choice.AccountsListAndBalanceDetails)
    )]
    [IsoId("_jINvYeaPEd-q8fx_Zl_34A")]
    [DisplayName("Account Identification 12 Choice")]
    public abstract record AccountIdentification12Choice_ { }
}
