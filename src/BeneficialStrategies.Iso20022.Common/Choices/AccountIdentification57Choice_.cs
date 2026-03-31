// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification57Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification57Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(
        typeof(AccountIdentification57Choice.ForAllAccounts),
        nameof(AccountIdentification57Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification57Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification57Choice.AccountsListAndBalanceDetails)
    )]
    [IsoId("_YXNPSl99Ee262vCSVgjImg")]
    [DisplayName("Account Identification 57 Choice")]
    public abstract record AccountIdentification57Choice_ { }
}
