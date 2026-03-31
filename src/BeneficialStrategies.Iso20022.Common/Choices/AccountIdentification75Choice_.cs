// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Identification75Choice.
    /// </summary>
    [KnownType(typeof(AccountIdentification75Choice.AccountsList))]
    [KnownType(typeof(AccountIdentification75Choice.ForAllAccounts))]
    [JsonDerivedType(
        typeof(AccountIdentification75Choice.AccountsList),
        nameof(AccountIdentification75Choice.AccountsList)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification75Choice.ForAllAccounts),
        nameof(AccountIdentification75Choice.ForAllAccounts)
    )]
    [IsoId("_lxWMtZt3Ee-wQIOX0djF2w")]
    [DisplayName("Account Identification75Choice")]
    public abstract record AccountIdentification75Choice_ { }
}
