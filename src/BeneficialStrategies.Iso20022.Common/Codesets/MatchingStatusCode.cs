// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the matching status of the instruction at the time the settlement instruction was sent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVDGRtp-Ed-ak6NoX_4Aeg_162716149")]
[Description(@"Provides the matching status of the instruction at the time the settlement instruction was sent.")]
[Derivations(typeof(MatchingStatus1Code))]
public enum MatchingStatusCode
{
    /// <summary>
    /// Instruction has been matched.
    /// Encoded/decoded by serializers as &quot;MACH&quot;.
    /// </summary>
    [EnumMember(Value = "MACH")]
    [IsoId("_aVDGR9p-Ed-ak6NoX_4Aeg_162716174")]
    [Description(@"Instruction has been matched.")]
    Matched,
    
    /// <summary>
    /// Instruction has not been matched.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_aVDGSNp-Ed-ak6NoX_4Aeg_162716175")]
    [Description(@"Instruction has not been matched.")]
    Unmatched,
    
    /// <summary>
    /// Instruction has been alleged matched.
    /// Encoded/decoded by serializers as &quot;ALGE&quot;.
    /// </summary>
    [EnumMember(Value = "ALGE")]
    [IsoId("_LpX2YdUbEeOpzo6bWCQeYA")]
    [Description(@"Instruction has been alleged matched.")]
    MatchingAlleged,
    
    /// <summary>
    /// Instruction has been mis-matched.
    /// Encoded/decoded by serializers as &quot;MMAT&quot;.
    /// </summary>
    [EnumMember(Value = "MMAT")]
    [IsoId("_OSFlEdUbEeOpzo6bWCQeYA")]
    [Description(@"Instruction has been mis-matched.")]
    MisMatched,
    
}
