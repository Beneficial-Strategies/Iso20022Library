// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification49Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification49Choice.AccountsList))]
    [JsonDerivedType(
        typeof(AccountIdentification49Choice.ForAllAccounts),
        nameof(AccountIdentification49Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification49Choice.AccountsList),
        nameof(AccountIdentification49Choice.AccountsList)
    )]
    [IsoId("_Uz7o4SLLEeyNSNrMl2zWxg")]
    [DisplayName("Account Identification 49 Choice")]
    public abstract record AccountIdentification49Choice_ { }
}
