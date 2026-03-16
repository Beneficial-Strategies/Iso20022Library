// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has a awaiting cancellation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0Ti09ojEeC60axPepSq7g_-1282873817")]
[Description(@"Specifies the reason why the instruction has a awaiting cancellation status.")]
[Derivations(typeof(AwaitingCancellationReason1Code))]
public enum AwaitingCancellationReasonCode
{
    /// <summary>
    /// Cancellation has not been received yet.
    /// Encoded/decoded by serializers as &quot;WCAN&quot;.
    /// </summary>
    [EnumMember(Value = "WCAN")]
    [IsoId("__0Ti1NojEeC60axPepSq7g_-1396712883")]
    [Description(@"Cancellation has not been received yet.")]
    AwaitingCancellation,
}
