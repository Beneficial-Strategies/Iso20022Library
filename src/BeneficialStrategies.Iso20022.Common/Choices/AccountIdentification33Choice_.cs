// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification33Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification33Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(
        typeof(AccountIdentification33Choice.ForAllAccounts),
        nameof(AccountIdentification33Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification33Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification33Choice.AccountsListAndBalanceDetails)
    )]
    [IsoId("_w9u0bTq3EeWQ1Y7f8kds2A")]
    [DisplayName("Account Identification 33 Choice")]
    public abstract record AccountIdentification33Choice_ { }
}
