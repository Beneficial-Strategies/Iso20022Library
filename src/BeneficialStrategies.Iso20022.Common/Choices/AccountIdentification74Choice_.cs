// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Identification74Choice.
    /// </summary>
    [KnownType(typeof(AccountIdentification74Choice.AccountsList))]
    [KnownType(typeof(AccountIdentification74Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification74Choice.AccountsList),nameof(AccountIdentification74Choice.AccountsList))]
    [JsonDerivedType(typeof(AccountIdentification74Choice.ForAllAccounts),nameof(AccountIdentification74Choice.ForAllAccounts))]
    [IsoId("_jKthh5t3Ee-wQIOX0djF2w")]
    [DisplayName("Account Identification74Choice")]
    public abstract partial record AccountIdentification74Choice_
    {
    }
}
