// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transaction Amendment1Choice.
    /// </summary>
    [KnownType(typeof(TransactionAmendment1Choice.Agent))]
    [KnownType(typeof(TransactionAmendment1Choice.Amount))]
    [KnownType(typeof(TransactionAmendment1Choice.AnyBIC))]
    [KnownType(typeof(TransactionAmendment1Choice.BICFI))]
    [KnownType(typeof(TransactionAmendment1Choice.CashAccount))]
    [KnownType(typeof(TransactionAmendment1Choice.Code))]
    [KnownType(typeof(TransactionAmendment1Choice.Date))]
    [KnownType(typeof(TransactionAmendment1Choice.DateTime))]
    [KnownType(typeof(TransactionAmendment1Choice.Other))]
    [KnownType(typeof(TransactionAmendment1Choice.Party))]
    [KnownType(typeof(TransactionAmendment1Choice.Remittance))]
    [JsonDerivedType(typeof(TransactionAmendment1Choice.Agent),nameof(TransactionAmendment1Choice.Agent))]
    [JsonDerivedType(typeof(TransactionAmendment1Choice.Amount),nameof(TransactionAmendment1Choice.Amount))]
    [JsonDerivedType(typeof(TransactionAmendment1Choice.AnyBIC),nameof(TransactionAmendment1Choice.AnyBIC))]
    [JsonDerivedType(typeof(TransactionAmendment1Choice.BICFI),nameof(TransactionAmendment1Choice.BICFI))]
    [JsonDerivedType(typeof(TransactionAmendment1Choice.CashAccount),nameof(TransactionAmendment1Choice.CashAccount))]
    [JsonDerivedType(typeof(TransactionAmendment1Choice.Code),nameof(TransactionAmendment1Choice.Code))]
    [JsonDerivedType(typeof(TransactionAmendment1Choice.Date),nameof(TransactionAmendment1Choice.Date))]
    [JsonDerivedType(typeof(TransactionAmendment1Choice.DateTime),nameof(TransactionAmendment1Choice.DateTime))]
    [JsonDerivedType(typeof(TransactionAmendment1Choice.Other),nameof(TransactionAmendment1Choice.Other))]
    [JsonDerivedType(typeof(TransactionAmendment1Choice.Party),nameof(TransactionAmendment1Choice.Party))]
    [JsonDerivedType(typeof(TransactionAmendment1Choice.Remittance),nameof(TransactionAmendment1Choice.Remittance))]
    [IsoId("_CsX6bJrOEeyo0KtkyUQoRg")]
    [DisplayName("Transaction Amendment1Choice")]
    public abstract partial record TransactionAmendment1Choice_
    {
    }
}
