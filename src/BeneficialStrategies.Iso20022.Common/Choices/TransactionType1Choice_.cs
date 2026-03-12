// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type or corporation action event type.
    /// </summary>
    [KnownType(typeof(TransactionType1Choice.TransactionType))]
    [KnownType(typeof(TransactionType1Choice.CorporateActionType))]
    [JsonDerivedType(typeof(TransactionType1Choice.TransactionType),nameof(TransactionType1Choice.TransactionType))]
    [JsonDerivedType(typeof(TransactionType1Choice.CorporateActionType),nameof(TransactionType1Choice.CorporateActionType))]
    [IsoId("_DDQMMAf_EeSaceXTzyiZRg")]
    [DisplayName("Transaction Type 1 Choice")]
    public abstract partial record TransactionType1Choice_
    {
    }
}
