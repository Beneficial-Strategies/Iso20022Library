// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for system inactivity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZRQG-Np-Ed-ak6NoX_4Aeg_2007403378")]
[Description(@"Specifies the reason for system inactivity.")]
[Derivations(typeof(SystemClosureReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SystemClosureReasonCode>))]
#endif
public enum SystemClosureReasonCode
{
    /// <summary>
    /// System is closed due to a bank holiday.
    /// Encoded/decoded by serializers as &quot;BHOL&quot;.
    /// </summary>
    [EnumMember(Value = "BHOL")]
    [IsoId("_ZRZQ4Np-Ed-ak6NoX_4Aeg_2007403379")]
    [Description(@"System is closed due to a bank holiday.")]
    BankingHoliday,

    /// <summary>
    /// System is closed for maintenance reasons.
    /// Encoded/decoded by serializers as &quot;SMTN&quot;.
    /// </summary>
    [EnumMember(Value = "SMTN")]
    [IsoId("_ZRZQ4dp-Ed-ak6NoX_4Aeg_2007403380")]
    [Description(@"System is closed for maintenance reasons.")]
    SystemMaintenance,

    /// <summary>
    /// System is not processing any operation.
    /// Encoded/decoded by serializers as &quot;NOOP&quot;.
    /// </summary>
    [EnumMember(Value = "NOOP")]
    [IsoId("_ZRZQ4tp-Ed-ak6NoX_4Aeg_2007403389")]
    [Description(@"System is not processing any operation.")]
    NoOperation,

    /// <summary>
    /// System is not operational during recovery operations.
    /// Encoded/decoded by serializers as &quot;RCVR&quot;.
    /// </summary>
    [EnumMember(Value = "RCVR")]
    [IsoId("_ZRZQ49p-Ed-ak6NoX_4Aeg_2007403390")]
    [Description(@"System is not operational during recovery operations.")]
    Recovery,

    /// <summary>
    /// System is not operational during allowed downtime windows.
    /// Encoded/decoded by serializers as &quot;ADTW&quot;.
    /// </summary>
    [EnumMember(Value = "ADTW")]
    [IsoId("_ZRZQ5Np-Ed-ak6NoX_4Aeg_2007403391")]
    [Description(@"System is not operational during allowed downtime windows.")]
    AllowedDowntimeWindow,
}
