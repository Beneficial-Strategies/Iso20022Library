// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts and one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification45Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification45Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(typeof(AccountIdentification45Choice.ForAllAccounts),nameof(AccountIdentification45Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification45Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification45Choice.AccountsListAndBalanceDetails))]
    [IsoId("_csxih_fSEeiNZp_PtLohLw")]
    [DisplayName("Account Identification 45 Choice")]
    public abstract partial record AccountIdentification45Choice_
    {
    }
}
