// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification9Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification9Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(
        typeof(AccountIdentification9Choice.ForAllAccounts),
        nameof(AccountIdentification9Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification9Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification9Choice.AccountsListAndBalanceDetails)
    )]
    [IsoId("_QSNvZdp-Ed-ak6NoX_4Aeg_-1885189248")]
    [DisplayName("Account Identification 9 Choice")]
    public abstract record AccountIdentification9Choice_ { }
}
