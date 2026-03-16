// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification42Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification42Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(
        typeof(AccountIdentification42Choice.ForAllAccounts),
        nameof(AccountIdentification42Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification42Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification42Choice.AccountsListAndBalanceDetails)
    )]
    [IsoId("_btgAxbXDEeiTob_PrFFUxA")]
    [DisplayName("Account Identification 42 Choice")]
    public abstract record AccountIdentification42Choice_ { }
}
