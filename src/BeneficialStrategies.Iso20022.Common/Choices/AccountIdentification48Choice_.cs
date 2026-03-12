// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification48Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification48Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(typeof(AccountIdentification48Choice.ForAllAccounts),nameof(AccountIdentification48Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification48Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification48Choice.AccountsListAndBalanceDetails))]
    [IsoId("_SkaQ8RuyEeyhRdHRjakS2w")]
    [DisplayName("Account Identification 48 Choice")]
    public abstract partial record AccountIdentification48Choice_
    {
    }
}
