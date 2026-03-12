// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification23Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification23Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(typeof(AccountIdentification23Choice.ForAllAccounts),nameof(AccountIdentification23Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification23Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification23Choice.AccountsListAndBalanceDetails))]
    [IsoId("_IU89ASqdEeObprHJy8Zrxg")]
    [DisplayName("Account Identification 23 Choice")]
    public abstract partial record AccountIdentification23Choice_
    {
    }
}
