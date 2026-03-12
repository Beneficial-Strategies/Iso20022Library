// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format method applied to a lending transaction.
    /// </summary>
    [KnownType(typeof(LendingTransactionMethod1Choice.Code))]
    [KnownType(typeof(LendingTransactionMethod1Choice.Proprietary))]
    [JsonDerivedType(typeof(LendingTransactionMethod1Choice.Code),nameof(LendingTransactionMethod1Choice.Code))]
    [JsonDerivedType(typeof(LendingTransactionMethod1Choice.Proprietary),nameof(LendingTransactionMethod1Choice.Proprietary))]
    [IsoId("_AXB1YNokEeC60axPepSq7g_713665433")]
    [DisplayName("Lending Transaction Method 1 Choice")]
    public abstract partial record LendingTransactionMethod1Choice_
    {
    }
}
