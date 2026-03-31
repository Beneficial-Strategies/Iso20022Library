// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification36Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification36Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(
        typeof(AccountIdentification36Choice.ForAllAccounts),
        nameof(AccountIdentification36Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification36Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification36Choice.AccountsListAndBalanceDetails)
    )]
    [IsoId("_ctP-z5KQEeWHWpTQn1FFVg")]
    [DisplayName("Account Identification 36 Choice")]
    public abstract record AccountIdentification36Choice_ { }
}
