// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Identification73Choice.
    /// </summary>
    [KnownType(typeof(AccountIdentification73Choice.AccountsList))]
    [KnownType(typeof(AccountIdentification73Choice.ForAllAccounts))]
    [JsonDerivedType(
        typeof(AccountIdentification73Choice.AccountsList),
        nameof(AccountIdentification73Choice.AccountsList)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification73Choice.ForAllAccounts),
        nameof(AccountIdentification73Choice.ForAllAccounts)
    )]
    [IsoId("_6Uki-4-9Ee-COKgew96POA")]
    [DisplayName("Account Identification73Choice")]
    public abstract record AccountIdentification73Choice_ { }
}
