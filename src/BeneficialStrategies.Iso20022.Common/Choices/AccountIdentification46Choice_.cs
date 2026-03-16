// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification46Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification46Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(
        typeof(AccountIdentification46Choice.ForAllAccounts),
        nameof(AccountIdentification46Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification46Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification46Choice.AccountsListAndBalanceDetails)
    )]
    [IsoId("_0_amgffSEeiNZp_PtLohLw")]
    [DisplayName("Account Identification 46 Choice")]
    public abstract record AccountIdentification46Choice_ { }
}
