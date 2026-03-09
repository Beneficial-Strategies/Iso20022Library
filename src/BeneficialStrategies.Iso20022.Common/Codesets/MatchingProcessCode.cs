// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the action to be performed on the matching process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVDGQNp-Ed-ak6NoX_4Aeg_-850156011")]
[Description(@"Specifies the action to be performed on the matching process.")]
[Derivations(typeof(MatchingProcess1Code))]
public enum MatchingProcessCode
{
    /// <summary>
    /// The referenced transaction is requested to be unmatched.
    /// Encoded/decoded by serializers as &quot;UNMT&quot;.
    /// </summary>
    [EnumMember(Value = "UNMT")]
    [IsoId("_aVDGQdp-Ed-ak6NoX_4Aeg_-796590257")]
    [Description(@"The referenced transaction is requested to be unmatched.")]
    Unmatch,
    
    /// <summary>
    /// Matching process is to be resumed for the referenced transaction.
    /// Encoded/decoded by serializers as &quot;MTRE&quot;.
    /// </summary>
    [EnumMember(Value = "MTRE")]
    [IsoId("_aVDGQtp-Ed-ak6NoX_4Aeg_-704236763")]
    [Description(@"Matching process is to be resumed for the referenced transaction.")]
    ResumeMatching,
    
}
