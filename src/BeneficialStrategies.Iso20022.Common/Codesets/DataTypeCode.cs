// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9dkccEeAEeSzluxs8tdrVw")]
[Description(@"Specifies the type of data.")]
[Derivations(typeof(DataType1Code))]
public enum DataTypeCode
{
    /// <summary>
    /// Specified type of data is trading data.
    /// Encoded/decoded by serializers as &quot;TRDA&quot;.
    /// </summary>
    [EnumMember(Value = "TRDA")]
    [IsoId("_I7regEeBEeSzluxs8tdrVw")]
    [Description(@"Specified type of data is trading data.")]
    TradingData,
    
    /// <summary>
    /// Specified type of data is exercise data.
    /// Encoded/decoded by serializers as &quot;EXDA&quot;.
    /// </summary>
    [EnumMember(Value = "EXDA")]
    [IsoId("_NweDMEeBEeSzluxs8tdrVw")]
    [Description(@"Specified type of data is exercise data.")]
    ExerciseData,
    
}
