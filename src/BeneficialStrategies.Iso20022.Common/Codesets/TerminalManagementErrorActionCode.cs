// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Action to perform in case of error during the action in progress.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUq-gH1DEeCF8NjrBemJWQ_-187828262")]
[Description(@"Action to perform in case of error during the action in progress.")]
[Derivations(
    typeof(TerminalManagementErrorAction1Code),
    typeof(TerminalManagementErrorAction2Code)
)]
public enum TerminalManagementErrorActionCode
{
    /// <summary>
    /// Ignore the error.
    /// Encoded/decoded by serializers as &quot;IGNR&quot;.
    /// </summary>
    [EnumMember(Value = "IGNR")]
    [IsoId("_KUq-gX1DEeCF8NjrBemJWQ_-2103855543")]
    [Description(@"Ignore the error.")]
    IgnoreError,

    /// <summary>
    /// Send a status report immediately.
    /// Encoded/decoded by serializers as &quot;SDSR&quot;.
    /// </summary>
    [EnumMember(Value = "SDSR")]
    [IsoId("_KUq-gn1DEeCF8NjrBemJWQ_-1811897805")]
    [Description(@"Send a status report immediately.")]
    SendStatusReport,

    /// <summary>
    /// Stop the current sequence of terminal management actions without any action, and do not notice the error with a status report.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_sO83IL4pEeKkGaJ0UrThyA_-2021748576")]
    [Description(
        @"Stop the current sequence of terminal management actions without any action, and do not notice the error with a status report."
    )]
    StopSequence,
}
