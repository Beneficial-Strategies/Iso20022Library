// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a fixed amount and an unlimited amount.
    /// </summary>
    [KnownType(typeof(FixedAmountOrUnlimited1Choice.Amount))]
    [KnownType(typeof(FixedAmountOrUnlimited1Choice.NotLimited))]
    [JsonDerivedType(
        typeof(FixedAmountOrUnlimited1Choice.Amount),
        nameof(FixedAmountOrUnlimited1Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(FixedAmountOrUnlimited1Choice.NotLimited),
        nameof(FixedAmountOrUnlimited1Choice.NotLimited)
    )]
    [IsoId("_9m4ooEqAEeKw5sECfP82rg")]
    [DisplayName("Fixed Amount Or Unlimited 1 Choice")]
    public abstract record FixedAmountOrUnlimited1Choice_ { }
}
