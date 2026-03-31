// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the financial instrument is to be physically delivered or is a dematerialised transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XGHPAPrqEeCJc7cZxzE2fg")]
[Description(
    @"Specifies whether the financial instrument is to be physically delivered or is a dematerialised transfer."
)]
[Derivations(typeof(PhysicalTransferType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PhysicalTransferTypeCode>))]
#endif
public enum PhysicalTransferTypeCode
{
    /// <summary>
    /// Physical transfer.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_Xi4DgfrqEeCJc7cZxzE2fg")]
    [Description(@"Physical transfer.")]
    Physical,

    /// <summary>
    /// Dematerialised transfer.
    /// Encoded/decoded by serializers as &quot;DEMT&quot;.
    /// </summary>
    [EnumMember(Value = "DEMT")]
    [IsoId("_mSc2V_rqEeCJc7cZxzE2fg")]
    [Description(@"Dematerialised transfer.")]
    Dematerialised,

    /// <summary>
    /// Cash transfer.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_L5wXwM5NEeSc85GUbgBycw")]
    [Description(@"Cash transfer.")]
    Cash,

    /// <summary>
    /// Determined by a third party or optional for counterparty.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_OPQ2kM5NEeSc85GUbgBycw")]
    [Description(@"Determined by a third party or optional for counterparty.")]
    Optional,
}
