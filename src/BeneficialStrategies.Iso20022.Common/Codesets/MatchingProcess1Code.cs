// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the action to be performed on the matching process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aU58Vtp-Ed-ak6NoX_4Aeg_36425374")]
[Description(@"Specifies the action to be performed on the matching process.")]
[DerivedFrom(typeof(MatchingProcessCode))]
public enum MatchingProcess1Code
{
    /// <summary>
    /// The referenced transaction is requested to be unmatched.
    /// Encoded/decoded by serializers as &quot;UNMT&quot;.
    /// </summary>
    [EnumMember(Value = "UNMT")]
    [IsoId("_aU58V9p-Ed-ak6NoX_4Aeg_65054355")]
    [Description(@"The referenced transaction is requested to be unmatched.")]
    Unmatch = MatchingProcessCode.Unmatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Matching process is to be resumed for the referenced transaction.
    /// Encoded/decoded by serializers as &quot;MTRE&quot;.
    /// </summary>
    [EnumMember(Value = "MTRE")]
    [IsoId("_aU58WNp-Ed-ak6NoX_4Aeg_65054356")]
    [Description(@"Matching process is to be resumed for the referenced transaction.")]
    ResumeMatching = MatchingProcessCode.ResumeMatching, // same ordinal as derivation source for type conversions
}
