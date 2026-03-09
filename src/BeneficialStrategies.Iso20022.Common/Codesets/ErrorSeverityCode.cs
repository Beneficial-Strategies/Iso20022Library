// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the severity of the related error code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Hz75QQ3EEeWH49U6bkyMaA")]
[Description(@"Indicates the severity of the related error code.")]
[Derivations(typeof(ErrorSeverity1Code))]
public enum ErrorSeverityCode
{
    /// <summary>
    /// The error is considered transient.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_YJX2oA3EEeWH49U6bkyMaA")]
    [Description(@"The error is considered transient.")]
    Transient,
    
    /// <summary>
    /// The error is considered fatal.
    /// Encoded/decoded by serializers as &quot;FATL&quot;.
    /// </summary>
    [EnumMember(Value = "FATL")]
    [IsoId("_h5VU0A3EEeWH49U6bkyMaA")]
    [Description(@"The error is considered fatal.")]
    Fatal,
    
}
