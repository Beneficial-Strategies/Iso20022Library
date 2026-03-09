// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the severity of the related error.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_q_x78A3EEeWH49U6bkyMaA")]
[Description(@"Indicates the severity of the related error.")]
[DerivedFrom(typeof(ErrorSeverityCode))]
public enum ErrorSeverity1Code
{
    /// <summary>
    /// The error is considered fatal.
    /// Encoded/decoded by serializers as &quot;FATL&quot;.
    /// </summary>
    [EnumMember(Value = "FATL")]
    [IsoId("_sXHiUQ3EEeWH49U6bkyMaA")]
    [Description(@"The error is considered fatal.")]
    Fatal = ErrorSeverityCode.Fatal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The error is considered transient.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_sdgeMw3EEeWH49U6bkyMaA")]
    [Description(@"The error is considered transient.")]
    Transient = ErrorSeverityCode.Transient, // same ordinal as derivation source for type conversions
    
}
