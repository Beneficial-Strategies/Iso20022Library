// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a known exercise date and a pending date.
    /// </summary>
    [KnownType(typeof(ExerciseDate1Choice.FirstExerciseDate))]
    [KnownType(typeof(ExerciseDate1Choice.PendingDateApplicable))]
    [JsonDerivedType(
        typeof(ExerciseDate1Choice.FirstExerciseDate),
        nameof(ExerciseDate1Choice.FirstExerciseDate)
    )]
    [JsonDerivedType(
        typeof(ExerciseDate1Choice.PendingDateApplicable),
        nameof(ExerciseDate1Choice.PendingDateApplicable)
    )]
    [IsoId("_UR6owAbBEeqrW7Meu5r3kQ")]
    [DisplayName("Exercise Date 1 Choice")]
    public abstract record ExerciseDate1Choice_ { }
}
