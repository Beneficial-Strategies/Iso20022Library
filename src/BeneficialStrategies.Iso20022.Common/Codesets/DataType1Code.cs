// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of data to indicate whether a trade is an option or resulted by an option exercise.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_X5YEEIAwEeSUJZYcWGKkkw")]
[Description(@"Type of data to indicate whether a trade is an option or resulted by an option exercise.")]
[DerivedFrom(typeof(DataTypeCode))]
public enum DataType1Code
{
    /// <summary>
    /// Specified type of data is exercise data.
    /// Encoded/decoded by serializers as &quot;EXDA&quot;.
    /// </summary>
    [EnumMember(Value = "EXDA")]
    [IsoId("_cftWAYAwEeSUJZYcWGKkkw")]
    [Description(@"Specified type of data is exercise data.")]
    ExerciseData = DataTypeCode.ExerciseData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specified type of data is trading data.
    /// Encoded/decoded by serializers as &quot;TRDA&quot;.
    /// </summary>
    [EnumMember(Value = "TRDA")]
    [IsoId("_clTnsYAwEeSUJZYcWGKkkw")]
    [Description(@"Specified type of data is trading data.")]
    TradingData = DataTypeCode.TradingData, // same ordinal as derivation source for type conversions
    
}
