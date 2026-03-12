// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification29Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification29Choice.AccountsList))]
    [JsonDerivedType(typeof(AccountIdentification29Choice.ForAllAccounts),nameof(AccountIdentification29Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification29Choice.AccountsList),nameof(AccountIdentification29Choice.AccountsList))]
    [IsoId("_xiegeTq3EeWQ1Y7f8kds2A")]
    [DisplayName("Account Identification 29 Choice")]
    public abstract partial record AccountIdentification29Choice_
    {
    }
}
