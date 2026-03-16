// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transaction Status1Choice.
    /// </summary>
    [KnownType(typeof(TransactionStatus1Choice.Code))]
    [KnownType(typeof(TransactionStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(TransactionStatus1Choice.Code),nameof(TransactionStatus1Choice.Code))]
    [JsonDerivedType(typeof(TransactionStatus1Choice.Proprietary),nameof(TransactionStatus1Choice.Proprietary))]
    [IsoId("_rTkjwRZNEe6d6Ip1Ob2kaQ")]
    [DisplayName("Transaction Status1Choice")]
    public abstract partial record TransactionStatus1Choice_
    {
    }
}
