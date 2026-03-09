// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Unit of the memory size.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CoXPEAxzEeKa_56Jbsi1RQ")]
[Description(@"Unit of the memory size.")]
[Derivations(typeof(MemoryUnit1Code))]
public enum MemoryUnitCode
{
    /// <summary>
    /// Exa byte.
    /// Encoded/decoded by serializers as &quot;EXAB&quot;.
    /// </summary>
    [EnumMember(Value = "EXAB")]
    [IsoId("_Hr9EwAxzEeKa_56Jbsi1RQ")]
    [Description(@"Exa byte.")]
    ExaByte,
    
    /// <summary>
    /// Peta byte.
    /// Encoded/decoded by serializers as &quot;PETA&quot;.
    /// </summary>
    [EnumMember(Value = "PETA")]
    [IsoId("_R05qsAxzEeKa_56Jbsi1RQ")]
    [Description(@"Peta byte.")]
    PetaByte,
    
    /// <summary>
    /// Tera byte.
    /// Encoded/decoded by serializers as &quot;TERA&quot;.
    /// </summary>
    [EnumMember(Value = "TERA")]
    [IsoId("_cCdq4AxzEeKa_56Jbsi1RQ")]
    [Description(@"Tera byte.")]
    TeraByte,
    
    /// <summary>
    /// Giga byte.
    /// Encoded/decoded by serializers as &quot;GIGA&quot;.
    /// </summary>
    [EnumMember(Value = "GIGA")]
    [IsoId("_hkizYAxzEeKa_56Jbsi1RQ")]
    [Description(@"Giga byte.")]
    GigaByte,
    
    /// <summary>
    /// Mega byte.
    /// Encoded/decoded by serializers as &quot;MEGA&quot;.
    /// </summary>
    [EnumMember(Value = "MEGA")]
    [IsoId("_lTyFQAxzEeKa_56Jbsi1RQ")]
    [Description(@"Mega byte.")]
    MegaByte,
    
    /// <summary>
    /// Kilo byte.
    /// Encoded/decoded by serializers as &quot;KILO&quot;.
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_qWw28AxzEeKa_56Jbsi1RQ")]
    [Description(@"Kilo byte.")]
    KiloByte,
    
    /// <summary>
    /// Byte.
    /// Encoded/decoded by serializers as &quot;BYTE&quot;.
    /// </summary>
    [EnumMember(Value = "BYTE")]
    [IsoId("_up_msAxzEeKa_56Jbsi1RQ")]
    [Description(@"Byte.")]
    Byte,
    
}
