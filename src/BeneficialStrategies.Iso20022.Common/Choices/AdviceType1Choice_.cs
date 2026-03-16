// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of advice requested for the transaction.
    /// </summary>
    [KnownType(typeof(AdviceType1Choice.Code))]
    [KnownType(typeof(AdviceType1Choice.Proprietary))]
    [JsonDerivedType(typeof(AdviceType1Choice.Code), nameof(AdviceType1Choice.Code))]
    [JsonDerivedType(typeof(AdviceType1Choice.Proprietary), nameof(AdviceType1Choice.Proprietary))]
    [IsoId("_u3TXw9omEembTrt_WixjyQ")]
    [DisplayName("Advice Type 1 Choice")]
    public abstract record AdviceType1Choice_ { }
}
