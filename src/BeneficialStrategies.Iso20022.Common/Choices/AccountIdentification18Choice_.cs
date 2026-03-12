// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification18Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification18Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(typeof(AccountIdentification18Choice.ForAllAccounts),nameof(AccountIdentification18Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification18Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification18Choice.AccountsListAndBalanceDetails))]
    [IsoId("_JgvFEfpTEeCLrd06h-p51g")]
    [DisplayName("Account Identification 18 Choice")]
    public abstract partial record AccountIdentification18Choice_
    {
    }
}
