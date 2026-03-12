// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides transaction type and identification information.
    /// </summary>
    [KnownType(typeof(TransactionIdentification1Choice.Transaction))]
    [KnownType(typeof(TransactionIdentification1Choice.MarginReporting))]
    [KnownType(typeof(TransactionIdentification1Choice.CollateralReuse))]
    [JsonDerivedType(typeof(TransactionIdentification1Choice.Transaction),nameof(TransactionIdentification1Choice.Transaction))]
    [JsonDerivedType(typeof(TransactionIdentification1Choice.MarginReporting),nameof(TransactionIdentification1Choice.MarginReporting))]
    [JsonDerivedType(typeof(TransactionIdentification1Choice.CollateralReuse),nameof(TransactionIdentification1Choice.CollateralReuse))]
    [IsoId("_DD0DMK7LEemZxoEFHjN-AQ")]
    [DisplayName("Transaction Identification 1 Choice")]
    public abstract partial record TransactionIdentification1Choice_
    {
    }
}
