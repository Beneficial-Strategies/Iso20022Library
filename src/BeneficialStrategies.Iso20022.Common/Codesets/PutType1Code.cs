// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of execution of the put feature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha1jumliEeGaMcKyqKNRfQ_251569036")]
[Description(@"Defines the type of execution of the put feature.")]
[DerivedFrom(typeof(PutTypeCode))]
public enum PutType1Code
{
    /// <summary>
    /// Type of execution of the put feature is mandatory.
    /// Encoded/decoded by serializers as &quot;MAND&quot;.
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_ha1ju2liEeGaMcKyqKNRfQ_126631193")]
    [Description(@"Type of execution of the put feature is mandatory.")]
    Mandatory = PutTypeCode.Mandatory, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of execution of the put feature is optional.
    /// Encoded/decoded by serializers as &quot;OPTI&quot;.
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("_ha1jvGliEeGaMcKyqKNRfQ_-1580269150")]
    [Description(@"Type of execution of the put feature is optional.")]
    Optional = PutTypeCode.Optional, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of execution of the put feature could be optional or mandatory.
    /// Encoded/decoded by serializers as &quot;TWOS&quot;.
    /// </summary>
    [EnumMember(Value = "TWOS")]
    [IsoId("_ha1jvWliEeGaMcKyqKNRfQ_-113120387")]
    [Description(@"Type of execution of the put feature could be optional or mandatory.")]
    Both = PutTypeCode.Both, // same ordinal as derivation source for type conversions
}
