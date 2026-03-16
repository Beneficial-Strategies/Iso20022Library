// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a given account switch.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QKe20H6rEeePx-IqKegQ8Q")]
[Description(@"Specifies the status of a given account switch.")]
[DerivedFrom(typeof(SwitchStatusCode))]
public enum SwitchStatus1Code
{
    /// <summary>
    /// Account switch is accepted.
    /// Usage: Accepted status should be used when account switch service receives and validates an information response request accepting the switch.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_RnBGQX6rEeePx-IqKegQ8Q")]
    [Description(
        @"Account switch is accepted.||Usage: Accepted status should be used when account switch service receives and validates an information response request accepting the switch."
    )]
    Accepted = SwitchStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account balance transfer is requested.
    /// Usage: Balance transfer requested status should be used when account switch service receives and validates a request balance transfer request.
    /// Encoded/decoded by serializers as &quot;BTRQ&quot;.
    /// </summary>
    [EnumMember(Value = "BTRQ")]
    [IsoId("_RshRUX6rEeePx-IqKegQ8Q")]
    [Description(
        @"Account balance transfer is requested.||Usage: Balance transfer requested status should be used when account switch service receives and validates a request balance transfer request."
    )]
    BalanceTransferRequested = SwitchStatusCode.BalanceTransferRequested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance transfer responded.
    /// Usage: Balance transfer responded staus should be used when the account switch service receives and validates an acknowledge balance transfer request.
    /// Encoded/decoded by serializers as &quot;BTRS&quot;.
    /// </summary>
    [EnumMember(Value = "BTRS")]
    [IsoId("_RyUXUX6rEeePx-IqKegQ8Q")]
    [Description(
        @"Balance transfer responded.||Usage: Balance transfer responded staus should be used when the account switch service receives and validates an acknowledge balance transfer request."
    )]
    BalanceTransferResponse = SwitchStatusCode.BalanceTransferResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account switch is completed.
    /// Usage: Completed status should be used when account switch service receives and validates a notify account switch complete request.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_R3FikX6rEeePx-IqKegQ8Q")]
    [Description(
        @"Account switch is completed.||Usage: Completed status should be used when account switch service receives and validates a notify account switch complete request."
    )]
    Completed = SwitchStatusCode.Completed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for redirection.
    /// Usage: Redirection status should be used when the account switch service receives and validates the first redirection request.
    /// Encoded/decoded by serializers as &quot;REDT&quot;.
    /// </summary>
    [EnumMember(Value = "REDT")]
    [IsoId("_SAmq8X6rEeePx-IqKegQ8Q")]
    [Description(
        @"Request for redirection. ||Usage: Redirection status should be used when the account switch service receives and validates the first redirection request."
    )]
    Redirection = SwitchStatusCode.Redirection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Redirection ended at the end of the redirection period.
    /// Usage: Indicates the cessation of account redirection by a particular service.
    /// Encoded/decoded by serializers as &quot;REDE&quot;.
    /// </summary>
    [EnumMember(Value = "REDE")]
    [IsoId("_SGtS8X6rEeePx-IqKegQ8Q")]
    [Description(
        @"Redirection ended at the end of the redirection period. ||Usage: Indicates the cessation of account redirection by a particular service."
    )]
    RedirectionEnded = SwitchStatusCode.RedirectionEnded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account switch is rejected.
    /// Usage: Rejected status should be used when account switch service receives and validates an information response request rejecting the account switch.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_SMWn8X6rEeePx-IqKegQ8Q")]
    [Description(
        @"Account switch is rejected. ||Usage: Rejected status should be used when account switch service receives and validates an information response request rejecting the account switch."
    )]
    Rejected = SwitchStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information is requested for the account switch.
    /// Usage: Requested status should be used when the account switch service receives and validates an information request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_SVbrcX6rEeePx-IqKegQ8Q")]
    [Description(
        @"Information is requested for the account switch. ||Usage: Requested status should be used when the account switch service receives and validates an information request."
    )]
    Requested = SwitchStatusCode.Requested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account switch is terminated.
    /// Usage: Terminated status should be used when the account switch service receives and validates a terminate switch request.
    /// Encoded/decoded by serializers as &quot;TMTN&quot;.
    /// </summary>
    [EnumMember(Value = "TMTN")]
    [IsoId("_SayskX6rEeePx-IqKegQ8Q")]
    [Description(
        @"Account switch is terminated. ||Usage: Terminated status should be used when the account switch service receives and validates a terminate switch request."
    )]
    Termination = SwitchStatusCode.Termination, // same ordinal as derivation source for type conversions
}
