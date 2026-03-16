// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the list of codes applicable to embedded option types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w783gIcPEeu4rpsqTt37Pg")]
[Description(@"Specifies the list of codes applicable to embedded option types.")]
[Derivations(typeof(EmbeddedType1Code))]
public enum EmbeddedTypeCode
{
    /// <summary>
    /// Option must be early terminated.
    /// Encoded/decoded by serializers as &quot;MDET&quot;.
    /// </summary>
    [EnumMember(Value = "MDET")]
    [IsoId("_2RrmEIcPEeu4rpsqTt37Pg")]
    [Description(@"Option must be early terminated.")]
    MandatoryEarlyTermination,

    /// <summary>
    /// Option can be early terminated.
    /// Encoded/decoded by serializers as &quot;OPET&quot;.
    /// </summary>
    [EnumMember(Value = "OPET")]
    [IsoId("_5nedMIcPEeu4rpsqTt37Pg")]
    [Description(@"Option can be early terminated.")]
    OptionalEarlyTermination,

    /// <summary>
    /// Option can be cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_9zaSIIcPEeu4rpsqTt37Pg")]
    [Description(@"Option can be cancelled.")]
    Cancellable,

    /// <summary>
    /// Option can be extended.
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_BeLTsIcQEeu4rpsqTt37Pg")]
    [Description(@"Option can be extended.")]
    Extendible,

    /// <summary>
    /// Option type is other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_DZqI8IcQEeu4rpsqTt37Pg")]
    [Description(@"Option type is other.")]
    Other,
}
