// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the novation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QF-sEMETEea7jLfvGi1PDw")]
[Description(@"Specifies the status of the novation.")]
[Derivations(typeof(NovationStatus1Code))]
public enum NovationStatusCode
{
    /// <summary>
    /// Transaction is a novation.
    /// Encoded/decoded by serializers as &quot;NOVA&quot;.
    /// </summary>
    [EnumMember(Value = "NOVA")]
    [IsoId("_Zd1zUMETEea7jLfvGi1PDw")]
    [Description(@"Transaction is a novation.")]
    Novation,
    
    /// <summary>
    /// Transaction is not a novation.
    /// Encoded/decoded by serializers as &quot;NONO&quot;.
    /// </summary>
    [EnumMember(Value = "NONO")]
    [IsoId("_Z1DZcMETEea7jLfvGi1PDw")]
    [Description(@"Transaction is not a novation.")]
    NoNovation,
    
}
