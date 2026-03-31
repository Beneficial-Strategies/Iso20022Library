// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the details of the underlying transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction1Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction1Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction1Choice.StatementEntry))]
    [JsonDerivedType(
        typeof(UnderlyingTransaction1Choice.Initiation),
        nameof(UnderlyingTransaction1Choice.Initiation)
    )]
    [JsonDerivedType(
        typeof(UnderlyingTransaction1Choice.Interbank),
        nameof(UnderlyingTransaction1Choice.Interbank)
    )]
    [JsonDerivedType(
        typeof(UnderlyingTransaction1Choice.StatementEntry),
        nameof(UnderlyingTransaction1Choice.StatementEntry)
    )]
    [IsoId("_P9DXuNp-Ed-ak6NoX_4Aeg_-2030379979")]
    [DisplayName("Underlying Transaction 1 Choice")]
    public abstract record UnderlyingTransaction1Choice_ { }
}
