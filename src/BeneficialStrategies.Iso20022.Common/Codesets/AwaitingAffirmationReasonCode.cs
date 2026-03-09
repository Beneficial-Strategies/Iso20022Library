// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has an awaiting affirmation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0Jx1dojEeC60axPepSq7g_-795321397")]
[Description(@"Specifies the reason why the instruction has an awaiting affirmation status.")]
[Derivations(typeof(AwaitingAffirmationReason1Code))]
public enum AwaitingAffirmationReasonCode
{
    /// <summary>
    /// Affirmation has not been received yet.
    /// Encoded/decoded by serializers as &quot;WAFF&quot;.
    /// </summary>
    [EnumMember(Value = "WAFF")]
    [IsoId("__0Ti0NojEeC60axPepSq7g_-909160463")]
    [Description(@"Affirmation has not been received yet.")]
    AwaitingAffirmation,
    
}
