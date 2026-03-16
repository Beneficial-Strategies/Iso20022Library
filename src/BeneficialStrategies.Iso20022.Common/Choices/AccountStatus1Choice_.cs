// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the status of an account.
    /// </summary>
    [KnownType(typeof(AccountStatus1Choice.Code))]
    [KnownType(typeof(AccountStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(AccountStatus1Choice.Code), nameof(AccountStatus1Choice.Code))]
    [JsonDerivedType(
        typeof(AccountStatus1Choice.Proprietary),
        nameof(AccountStatus1Choice.Proprietary)
    )]
    [IsoId("_6eMqkCF0EeW9XJWqfgXIIA")]
    [DisplayName("Account Status 1 Choice")]
    public abstract record AccountStatus1Choice_ { }
}
