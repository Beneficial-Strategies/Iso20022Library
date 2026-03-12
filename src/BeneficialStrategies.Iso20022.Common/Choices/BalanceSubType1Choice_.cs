// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the balance subtype.
    /// </summary>
    [KnownType(typeof(BalanceSubType1Choice.Code))]
    [KnownType(typeof(BalanceSubType1Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceSubType1Choice.Code),nameof(BalanceSubType1Choice.Code))]
    [JsonDerivedType(typeof(BalanceSubType1Choice.Proprietary),nameof(BalanceSubType1Choice.Proprietary))]
    [IsoId("_SYoCQ9p-Ed-ak6NoX_4Aeg_771530920")]
    [DisplayName("Balance Sub Type 1 Choice")]
    public abstract partial record BalanceSubType1Choice_
    {
    }
}
