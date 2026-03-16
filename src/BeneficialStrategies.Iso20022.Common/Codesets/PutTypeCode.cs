// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of execution of the put feature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha1js2liEeGaMcKyqKNRfQ_477387752")]
[Description(@"Defines the type of execution of the put feature.")]
[Derivations(typeof(PutType1Code))]
public enum PutTypeCode
{
    /// <summary>
    /// Type of execution of the put feature is mandatory.
    /// Encoded/decoded by serializers as &quot;MAND&quot;.
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_ha1jtGliEeGaMcKyqKNRfQ_-304925813")]
    [Description(@"Type of execution of the put feature is mandatory.")]
    Mandatory,

    /// <summary>
    /// Type of execution of the put feature is optional.
    /// Encoded/decoded by serializers as &quot;OPTI&quot;.
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("_ha1jtWliEeGaMcKyqKNRfQ_-1889555559")]
    [Description(@"Type of execution of the put feature is optional.")]
    Optional,

    /// <summary>
    /// Type of execution of the put feature could be optional or mandatory.
    /// Encoded/decoded by serializers as &quot;TWOS&quot;.
    /// </summary>
    [EnumMember(Value = "TWOS")]
    [IsoId("_ha1jtmliEeGaMcKyqKNRfQ_-1569124192")]
    [Description(@"Type of execution of the put feature could be optional or mandatory.")]
    Both,
}
