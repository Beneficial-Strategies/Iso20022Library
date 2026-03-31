// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a given account switch.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1fAkkBE2EeafpqhYGpTDnw")]
[Description(@"Specifies the status of a given account switch.")]
[Derivations(typeof(SwitchStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SwitchStatusCode>))]
#endif
public enum SwitchStatusCode
{
    /// <summary>
    /// Account switch is terminated.
    /// Usage: Terminated status should be used when the account switch service receives and validates a terminate switch request.
    /// Encoded/decoded by serializers as &quot;TMTN&quot;.
    /// </summary>
    [EnumMember(Value = "TMTN")]
    [IsoId("_A8UVYBE3EeafpqhYGpTDnw")]
    [Description(
        @"Account switch is terminated. ||Usage: Terminated status should be used when the account switch service receives and validates a terminate switch request."
    )]
    Termination,

    /// <summary>
    /// Information is requested for the account switch.
    /// Usage: Requested status should be used when the account switch service receives and validates an information request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_FQSE8BE3EeafpqhYGpTDnw")]
    [Description(
        @"Information is requested for the account switch. ||Usage: Requested status should be used when the account switch service receives and validates an information request."
    )]
    Requested,

    /// <summary>
    /// Account switch is rejected.
    /// Usage: Rejected status should be used when account switch service receives and validates an information response request rejecting the account switch.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_JyqrABE3EeafpqhYGpTDnw")]
    [Description(
        @"Account switch is rejected. ||Usage: Rejected status should be used when account switch service receives and validates an information response request rejecting the account switch."
    )]
    Rejected,

    /// <summary>
    /// Redirection ended at the end of the redirection period.
    /// Usage: Indicates the cessation of account redirection by a particular service.
    /// Encoded/decoded by serializers as &quot;REDE&quot;.
    /// </summary>
    [EnumMember(Value = "REDE")]
    [IsoId("_MpyCEBE3EeafpqhYGpTDnw")]
    [Description(
        @"Redirection ended at the end of the redirection period. ||Usage: Indicates the cessation of account redirection by a particular service."
    )]
    RedirectionEnded,

    /// <summary>
    /// Request for redirection.
    /// Usage: Redirection status should be used when the account switch service receives and validates the first redirection request.
    /// Encoded/decoded by serializers as &quot;REDT&quot;.
    /// </summary>
    [EnumMember(Value = "REDT")]
    [IsoId("_PpO1wBE3EeafpqhYGpTDnw")]
    [Description(
        @"Request for redirection. ||Usage: Redirection status should be used when the account switch service receives and validates the first redirection request."
    )]
    Redirection,

    /// <summary>
    /// Account switch is completed.
    /// Usage: Completed status should be used when account switch service receives and validates a notify account switch complete request.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_R2gloBE3EeafpqhYGpTDnw")]
    [Description(
        @"Account switch is completed.||Usage: Completed status should be used when account switch service receives and validates a notify account switch complete request."
    )]
    Completed,

    /// <summary>
    /// Balance transfer responded.
    /// Usage: Balance transfer responded staus should be used when the account switch service receives and validates an acknowledge balance transfer request.
    /// Encoded/decoded by serializers as &quot;BTRS&quot;.
    /// </summary>
    [EnumMember(Value = "BTRS")]
    [IsoId("_Ybv0QBE3EeafpqhYGpTDnw")]
    [Description(
        @"Balance transfer responded.||Usage: Balance transfer responded staus should be used when the account switch service receives and validates an acknowledge balance transfer request."
    )]
    BalanceTransferResponse,

    /// <summary>
    /// Account balance transfer is requested.
    /// Usage: Balance transfer requested status should be used when account switch service receives and validates a request balance transfer request.
    /// Encoded/decoded by serializers as &quot;BTRQ&quot;.
    /// </summary>
    [EnumMember(Value = "BTRQ")]
    [IsoId("_cTBn0BE3EeafpqhYGpTDnw")]
    [Description(
        @"Account balance transfer is requested.||Usage: Balance transfer requested status should be used when account switch service receives and validates a request balance transfer request."
    )]
    BalanceTransferRequested,

    /// <summary>
    /// Account switch is accepted.
    /// Usage: Accepted status should be used when account switch service receives and validates an information response request accepting the switch.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_kXGL8BE3EeafpqhYGpTDnw")]
    [Description(
        @"Account switch is accepted.||Usage: Accepted status should be used when account switch service receives and validates an information response request accepting the switch."
    )]
    Accepted,
}
