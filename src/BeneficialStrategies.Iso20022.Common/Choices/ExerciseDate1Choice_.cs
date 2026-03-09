// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a known exercise date and a pending date.
    /// </summary>
    [KnownType(typeof(ExerciseDate1Choice.FirstExerciseDate))]
    [KnownType(typeof(ExerciseDate1Choice.PendingDateApplicable))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ExerciseDate1Choice.FirstExerciseDate),nameof(ExerciseDate1Choice.FirstExerciseDate))]
    [JsonDerivedType(typeof(ExerciseDate1Choice.PendingDateApplicable),nameof(ExerciseDate1Choice.PendingDateApplicable))]
    #endif
    [IsoId("_UR6owAbBEeqrW7Meu5r3kQ")]
    [DisplayName("Exercise Date 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExerciseDate1Choice_
    #else
    public abstract partial class ExerciseDate1Choice_
    #endif
    {
    }
}
