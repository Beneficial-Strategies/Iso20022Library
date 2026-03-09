// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of demand for payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XvpRYHyVEeGWJuGCfvwOsQ")]
[Description(@"Specifies the type of demand for payment.")]
[Derivations(typeof(DemandType1Code))]
public enum DemandTypeCode
{
    /// <summary>
    /// Pay only.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_vHYM0HyVEeGWJuGCfvwOsQ")]
    [Description(@"Pay only.")]
    PayOnly,
    
    /// <summary>
    /// Pay or extend.
    /// Encoded/decoded by serializers as &quot;PAEX&quot;.
    /// </summary>
    [EnumMember(Value = "PAEX")]
    [IsoId("_qaP54HyWEeGWJuGCfvwOsQ")]
    [Description(@"Pay or extend.")]
    PayOrExtend,
    
}
