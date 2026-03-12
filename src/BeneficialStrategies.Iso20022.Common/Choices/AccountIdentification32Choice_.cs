// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification32Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification32Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(typeof(AccountIdentification32Choice.ForAllAccounts),nameof(AccountIdentification32Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification32Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification32Choice.AccountsListAndBalanceDetails))]
    [IsoId("_wLAW4Tq3EeWQ1Y7f8kds2A")]
    [DisplayName("Account Identification 32 Choice")]
    public abstract partial record AccountIdentification32Choice_
    {
    }
}
