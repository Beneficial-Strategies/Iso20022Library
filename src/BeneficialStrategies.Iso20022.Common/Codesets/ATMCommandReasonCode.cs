// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason for sending or requesting a maintenance command.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_s2j4EItGEeSxlKlAGYErFg")]
[Description(@"Reason for sending or requesting a maintenance command.")]
[Derivations(typeof(ATMCommandReason1Code))]
public enum ATMCommandReasonCode
{
    /// <summary>
    /// Request the status of or action from the ATM to perform a diagnostic.
    /// Encoded/decoded by serializers as &quot;DIAG&quot;.
    /// </summary>
    [EnumMember(Value = "DIAG")]
    [IsoId("_vsp7cItGEeSxlKlAGYErFg")]
    [Description(@"Request the status of or action from the ATM to perform a diagnostic.")]
    Diagnostic,

    /// <summary>
    /// Supervise the ATM.
    /// Encoded/decoded by serializers as &quot;MONI&quot;.
    /// </summary>
    [EnumMember(Value = "MONI")]
    [IsoId("_yRyxsItGEeSxlKlAGYErFg")]
    [Description(@"Supervise the ATM.")]
    Monitoring,

    /// <summary>
    /// Security error.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_02Aa4ItGEeSxlKlAGYErFg")]
    [Description(@"Security error.")]
    SecurityError,

    /// <summary>
    /// Desynchronisation of dialogue between entities.
    /// Encoded/decoded by serializers as &quot;SYNC&quot;.
    /// </summary>
    [EnumMember(Value = "SYNC")]
    [IsoId("_3S6iMItGEeSxlKlAGYErFg")]
    [Description(@"Desynchronisation of dialogue between entities.")]
    Synchronisation,

    /// <summary>
    /// Update the ATM.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_5ZxhAItGEeSxlKlAGYErFg")]
    [Description(@"Update the ATM.")]
    Update,
}
