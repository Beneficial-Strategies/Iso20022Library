// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts and one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification41Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification41Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(
        typeof(AccountIdentification41Choice.ForAllAccounts),
        nameof(AccountIdentification41Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification41Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification41Choice.AccountsListAndBalanceDetails)
    )]
    [IsoId("_bK1YdbXDEeiTob_PrFFUxA")]
    [DisplayName("Account Identification 41 Choice")]
    public abstract record AccountIdentification41Choice_ { }
}
