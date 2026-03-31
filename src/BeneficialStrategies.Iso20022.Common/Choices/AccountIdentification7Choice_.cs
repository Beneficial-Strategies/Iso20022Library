// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification7Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification7Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(
        typeof(AccountIdentification7Choice.ForAllAccounts),
        nameof(AccountIdentification7Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification7Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification7Choice.AccountsListAndBalanceDetails)
    )]
    [IsoId("_QSXgYtp-Ed-ak6NoX_4Aeg_-1261780269")]
    [DisplayName("Account Identification 7 Choice")]
    public abstract record AccountIdentification7Choice_ { }
}
