// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the transaction activity identification.
    /// </summary>
    [KnownType(typeof(TransactionActivity1Choice.Code))]
    [KnownType(typeof(TransactionActivity1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TransactionActivity1Choice.Code),
        nameof(TransactionActivity1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TransactionActivity1Choice.Proprietary),
        nameof(TransactionActivity1Choice.Proprietary)
    )]
    [IsoId("_QwUAqNp-Ed-ak6NoX_4Aeg_537035239")]
    [DisplayName("Transaction Activity 1 Choice")]
    public abstract record TransactionActivity1Choice_ { }
}
