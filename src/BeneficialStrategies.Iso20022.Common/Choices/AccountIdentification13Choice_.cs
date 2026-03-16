// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification13Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification13Choice.AccountsList))]
    [JsonDerivedType(
        typeof(AccountIdentification13Choice.ForAllAccounts),
        nameof(AccountIdentification13Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification13Choice.AccountsList),
        nameof(AccountIdentification13Choice.AccountsList)
    )]
    [IsoId("_qVGz5-aPEd-q8fx_Zl_34A")]
    [DisplayName("Account Identification 13 Choice")]
    public abstract record AccountIdentification13Choice_ { }
}
