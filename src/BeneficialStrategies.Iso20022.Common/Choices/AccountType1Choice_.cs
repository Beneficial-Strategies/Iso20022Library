// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the type of account.
    /// </summary>
    [KnownType(typeof(AccountType1Choice.Code))]
    [KnownType(typeof(AccountType1Choice.Proprietary))]
    [JsonDerivedType(typeof(AccountType1Choice.Code),nameof(AccountType1Choice.Code))]
    [JsonDerivedType(typeof(AccountType1Choice.Proprietary),nameof(AccountType1Choice.Proprietary))]
    [IsoId("_aMZQgxc8EeK5g-3oYI0_9Q")]
    [DisplayName("Account Type 1 Choice")]
    public abstract partial record AccountType1Choice_
    {
    }
}
