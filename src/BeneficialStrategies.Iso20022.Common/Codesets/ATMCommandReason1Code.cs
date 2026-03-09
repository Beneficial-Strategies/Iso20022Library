// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason for sending the command.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DJvmQItHEeSxlKlAGYErFg")]
[Description(@"Reason for sending the command.")]
[DerivedFrom(typeof(ATMCommandReasonCode))]
public enum ATMCommandReason1Code
{
    /// <summary>
    /// Request the status of or action from the ATM to perform a diagnostic.
    /// Encoded/decoded by serializers as &quot;DIAG&quot;.
    /// </summary>
    [EnumMember(Value = "DIAG")]
    [IsoId("_Z7ffwYtHEeSxlKlAGYErFg")]
    [Description(@"Request the status of or action from the ATM to perform a diagnostic.")]
    Diagnostic = ATMCommandReasonCode.Diagnostic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Supervise the ATM.
    /// Encoded/decoded by serializers as &quot;MONI&quot;.
    /// </summary>
    [EnumMember(Value = "MONI")]
    [IsoId("_aBKC4YtHEeSxlKlAGYErFg")]
    [Description(@"Supervise the ATM.")]
    Monitoring = ATMCommandReasonCode.Monitoring, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security error.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_aLIeQ4tHEeSxlKlAGYErFg")]
    [Description(@"Security error.")]
    SecurityError = ATMCommandReasonCode.SecurityError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Desynchronisation of dialogue between entities.
    /// Encoded/decoded by serializers as &quot;SYNC&quot;.
    /// </summary>
    [EnumMember(Value = "SYNC")]
    [IsoId("_aQWVc4tHEeSxlKlAGYErFg")]
    [Description(@"Desynchronisation of dialogue between entities.")]
    Synchronisation = ATMCommandReasonCode.Synchronisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update the ATM.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_aW6QcYtHEeSxlKlAGYErFg")]
    [Description(@"Update the ATM.")]
    Update = ATMCommandReasonCode.Update, // same ordinal as derivation source for type conversions
    
}
