// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the protect transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fzjwULpTEeilsanBGAzy4A")]
[Description(@"Specifies the status of the protect transaction.")]
[DerivedFrom(typeof(DTCInstructionStatusCode))]
public enum ProtectInstructionStatus3Code
{
    /// <summary>
    /// Protect instruction which has not been fully covered. Will include partial covers.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_riQzIbpTEeilsanBGAzy4A")]
    [Description(@"Protect instruction which has not been fully covered. Will include partial covers.")]
    Open = DTCInstructionStatusCode.Open, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect instruction has been fully covered.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_r-rpYrpTEeilsanBGAzy4A")]
    [Description(@"Protect instruction has been fully covered.")]
    FullyCovered = DTCInstructionStatusCode.FullyCovered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect instruction has expired.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_vrX9krpTEeilsanBGAzy4A")]
    [Description(@"Protect instruction has expired.")]
    Expired = DTCInstructionStatusCode.Expired, // same ordinal as derivation source for type conversions
    
}
