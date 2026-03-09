// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of protect instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ARYN4LpREeilsanBGAzy4A")]
[Description(@"Specifies the type of protect instruction.")]
[DerivedFrom(typeof(ReorganisationTransactionTypeCode))]
public enum ProtectTransactionType2Code
{
    /// <summary>
    /// Reorganisation is a protect transaction type.
    /// Encoded/decoded by serializers as &quot;PROT&quot;.
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_KQ81YbpREeilsanBGAzy4A")]
    [Description(@"Reorganisation is a protect transaction type.")]
    ProtectTransaction = ReorganisationTransactionTypeCode.ProtectTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reorganisation is a cover on behalf of another participant transaction type.
    /// Encoded/decoded by serializers as &quot;COVP&quot;.
    /// </summary>
    [EnumMember(Value = "COVP")]
    [IsoId("_OAUqIrpREeilsanBGAzy4A")]
    [Description(@"Reorganisation is a cover on behalf of another participant transaction type.")]
    CoverOnBehalfOfAnotherParticipantTransaction = ReorganisationTransactionTypeCode.CoverOnBehalfOfAnotherParticipantTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reorganisation is a cover protect transaction type.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_ZfkUobpREeilsanBGAzy4A")]
    [Description(@"Reorganisation is a cover protect transaction type.")]
    CoverProtectTransaction = ReorganisationTransactionTypeCode.CoverProtectTransaction, // same ordinal as derivation source for type conversions
    
}
