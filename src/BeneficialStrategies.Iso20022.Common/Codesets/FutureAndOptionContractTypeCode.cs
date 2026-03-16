// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Future And Option Contract Type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__2sIc9ojEeC60axPepSq7g_-1368478268")]
[Description(@"Future And Option Contract Type.")]
[Derivations(typeof(FutureAndOptionContractType1Code))]
public enum FutureAndOptionContractTypeCode
{
    /// <summary>
    /// Ordinary future and option contract.
    /// Encoded/decoded by serializers as &quot;ORDY&quot;.
    /// </summary>
    [EnumMember(Value = "ORDY")]
    [IsoId("__2sIdNojEeC60axPepSq7g_-1350560951")]
    [Description(@"Ordinary future and option contract.")]
    Ordinary,

    /// <summary>
    /// Future and option contract on an index as opposed to an underlying equity.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("__2sIddojEeC60axPepSq7g_381029970")]
    [Description(@"Future and option contract on an index as opposed to an underlying equity.")]
    Index,

    /// <summary>
    /// Receipt of future contract when an option on a future is exercised.
    /// Encoded/decoded by serializers as &quot;EXFU&quot;.
    /// </summary>
    [EnumMember(Value = "EXFU")]
    [IsoId("__2sIdtojEeC60axPepSq7g_257916990")]
    [Description(@"Receipt of future contract when an option on a future is exercised.")]
    ExercisedFuture,
}
