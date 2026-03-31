// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a securities settlement condition modification request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZK_t8Np-Ed-ak6NoX_4Aeg_502482396")]
[Description(@"Specifies the status of a securities settlement condition modification request.")]
[Derivations(typeof(SettlementConditionModificationStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementConditionModificationStatusStatusCode>))]
#endif
public enum SettlementConditionModificationStatusStatusCode
{
    /// <summary>
    /// Instruction has been acknowledged/accepted by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZK_t8dp-Ed-ak6NoX_4Aeg_-1855259727")]
    [Description(@"Instruction has been acknowledged/accepted by the account servicer.")]
    AcknowledgedAccepted,

    /// <summary>
    /// Instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZK_t8tp-Ed-ak6NoX_4Aeg_-316471285")]
    [Description(@"Instruction has been rejected for further processing.")]
    Rejected,

    /// <summary>
    /// Modification Request will not be executed.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_ZK_t89p-Ed-ak6NoX_4Aeg_-339767045")]
    [Description(@"Modification Request will not be executed.")]
    Denied,

    /// <summary>
    /// Modification has been completed.
    /// Encoded/decoded by serializers as &quot;MODC&quot;.
    /// </summary>
    [EnumMember(Value = "MODC")]
    [IsoId("_ZK_t9Np-Ed-ak6NoX_4Aeg_1475845866")]
    [Description(@"Modification has been completed.")]
    Completed,

    /// <summary>
    /// Modification is pending. At this time, it is unknown whether the modification can be affected.
    /// Encoded/decoded by serializers as &quot;MODP&quot;.
    /// </summary>
    [EnumMember(Value = "MODP")]
    [IsoId("_ZK_t9dp-Ed-ak6NoX_4Aeg_476350512")]
    [Description(
        @"Modification is pending. At this time, it is unknown whether the modification can be affected."
    )]
    Pending,
}
