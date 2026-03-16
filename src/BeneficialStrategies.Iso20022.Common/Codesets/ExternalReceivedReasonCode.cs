// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a received status.|
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_n0f5oVjrEeOnqqBHs8Gasw")]
[Description(
    @"Specifies the reason for a received status.||The list of valid codes is an external code list published separately. |External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalReceivedReason1Code))]
public enum ExternalReceivedReasonCode
{
    /// <summary>
    /// Instruction was not straight through processing and had to be processed manually
    /// Encoded/decoded by serializers as &quot;NSTP&quot;.
    /// </summary>
    [EnumMember(Value = "NSTP")]
    [IsoId("_uVGJRvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Instruction was not straight through processing and had to be processed manually"
    )]
    NotStraightThroughProcessing,
}
