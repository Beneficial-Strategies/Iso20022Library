// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element is a choice between a standard identifier and a proprietary code.
    /// </summary>
    [KnownType(typeof(UniqueTransactionIdentifier1Choice.UniqueTransactionIdentifier))]
    [KnownType(typeof(UniqueTransactionIdentifier1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(UniqueTransactionIdentifier1Choice.UniqueTransactionIdentifier),
        nameof(UniqueTransactionIdentifier1Choice.UniqueTransactionIdentifier)
    )]
    [JsonDerivedType(
        typeof(UniqueTransactionIdentifier1Choice.Proprietary),
        nameof(UniqueTransactionIdentifier1Choice.Proprietary)
    )]
    [IsoId("_t08DgAxeEeuoAcnnpX2x_w")]
    [DisplayName("Unique Transaction Identifier 1 Choice")]
    public abstract record UniqueTransactionIdentifier1Choice_ { }
}
