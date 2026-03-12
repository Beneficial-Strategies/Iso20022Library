// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the commercial contract type.
    /// </summary>
    [KnownType(typeof(UnderlyingTradeTransactionType1Choice.Code))]
    [KnownType(typeof(UnderlyingTradeTransactionType1Choice.Proprietary))]
    [JsonDerivedType(typeof(UnderlyingTradeTransactionType1Choice.Code),nameof(UnderlyingTradeTransactionType1Choice.Code))]
    [JsonDerivedType(typeof(UnderlyingTradeTransactionType1Choice.Proprietary),nameof(UnderlyingTradeTransactionType1Choice.Proprietary))]
    [IsoId("_93QOw3ltEeG7BsjMvd1mEw_-521905675")]
    [DisplayName("Underlying Trade Transaction Type 1 Choice")]
    public abstract partial record UnderlyingTradeTransactionType1Choice_
    {
    }
}
