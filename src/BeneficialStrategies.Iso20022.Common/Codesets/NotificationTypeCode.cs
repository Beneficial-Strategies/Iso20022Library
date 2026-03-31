// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which type of action a user must take or is prevented to take.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aOMQUNp-Ed-ak6NoX_4Aeg_479751558")]
[Description(@"Specifies which type of action a user must take or is prevented to take.")]
[Derivations(typeof(NotificationType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NotificationTypeCode>))]
#endif
public enum NotificationTypeCode
{
    /// <summary>
    /// User must withdraw from transaction because of Force Majeure.
    /// Encoded/decoded by serializers as &quot;MWFT&quot;.
    /// </summary>
    [EnumMember(Value = "MWFT")]
    [IsoId("_aOMQUdp-Ed-ak6NoX_4Aeg_537011134")]
    [Description(@"User must withdraw from transaction because of Force Majeure.")]
    MustWithdrawFromTransaction,

    /// <summary>
    /// User is unable to submit data set(s).
    /// Encoded/decoded by serializers as &quot;CSDS&quot;.
    /// </summary>
    [EnumMember(Value = "CSDS")]
    [IsoId("_aOMQUtp-Ed-ak6NoX_4Aeg_578569210")]
    [Description(@"User is unable to submit data set(s).")]
    CannotSubmitDataSet,
}
