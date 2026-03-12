// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification56Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification56Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(typeof(AccountIdentification56Choice.ForAllAccounts),nameof(AccountIdentification56Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification56Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification56Choice.AccountsListAndBalanceDetails))]
    [IsoId("_QhKpUTgDEe23pOhj-2WbKw")]
    [DisplayName("Account Identification 56 Choice")]
    public abstract partial record AccountIdentification56Choice_
    {
    }
}
