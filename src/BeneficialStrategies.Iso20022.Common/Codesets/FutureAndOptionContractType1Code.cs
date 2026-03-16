// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Future And Option Contract Type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__2iXddojEeC60axPepSq7g_-1182518017")]
[Description(@"Future And Option Contract Type.")]
[DerivedFrom(typeof(FutureAndOptionContractTypeCode))]
public enum FutureAndOptionContractType1Code
{
    /// <summary>
    /// Ordinary future and option contract.
    /// Encoded/decoded by serializers as &quot;ORDY&quot;.
    /// </summary>
    [EnumMember(Value = "ORDY")]
    [IsoId("__2sIcNojEeC60axPepSq7g_-842269814")]
    [Description(@"Ordinary future and option contract.")]
    Ordinary = FutureAndOptionContractTypeCode.Ordinary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Future and option contract on an index as opposed to an underlying equity.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("__2sIcdojEeC60axPepSq7g_-1031487263")]
    [Description(@"Future and option contract on an index as opposed to an underlying equity.")]
    Index = FutureAndOptionContractTypeCode.Index, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receipt of future contract when an option on a future is exercised.
    /// Encoded/decoded by serializers as &quot;EXFU&quot;.
    /// </summary>
    [EnumMember(Value = "EXFU")]
    [IsoId("__2sIctojEeC60axPepSq7g_19645809")]
    [Description(@"Receipt of future contract when an option on a future is exercised.")]
    ExercisedFuture = FutureAndOptionContractTypeCode.ExercisedFuture, // same ordinal as derivation source for type conversions
}
