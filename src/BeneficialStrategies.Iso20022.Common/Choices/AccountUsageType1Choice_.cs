// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the type of account usage.
    /// </summary>
    [KnownType(typeof(AccountUsageType1Choice.Code))]
    [KnownType(typeof(AccountUsageType1Choice.Proprietary))]
    [JsonDerivedType(typeof(AccountUsageType1Choice.Code),nameof(AccountUsageType1Choice.Code))]
    [JsonDerivedType(typeof(AccountUsageType1Choice.Proprietary),nameof(AccountUsageType1Choice.Proprietary))]
    [IsoId("_xerkExKCEeKj15WxqwlXPw")]
    [DisplayName("Account Usage Type 1 Choice")]
    public abstract partial record AccountUsageType1Choice_
    {
    }
}
