// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the exercise date or notice period for a call/put option.
    /// </summary>
    [KnownType(typeof(OptionDateOrPeriod1Choice.EarliestExerciseDate))]
    [KnownType(typeof(OptionDateOrPeriod1Choice.NoticePeriod))]
    [JsonDerivedType(typeof(OptionDateOrPeriod1Choice.EarliestExerciseDate),nameof(OptionDateOrPeriod1Choice.EarliestExerciseDate))]
    [JsonDerivedType(typeof(OptionDateOrPeriod1Choice.NoticePeriod),nameof(OptionDateOrPeriod1Choice.NoticePeriod))]
    [IsoId("_FBT61jU7EeWITbq5W8H-2w")]
    [DisplayName("Option Date Or Period 1 Choice")]
    public abstract partial record OptionDateOrPeriod1Choice_
    {
    }
}
