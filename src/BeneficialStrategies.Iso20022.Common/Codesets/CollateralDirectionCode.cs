// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Direction of the collateral being reported.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4om60AMxEeutW5-TpeYJhA")]
[Description(@"Direction of the collateral being reported.")]
[Derivations(typeof(CollateralDirection1Code))]
public enum CollateralDirectionCode
{
    /// <summary>
    /// Collateral is due to party A.
    /// Encoded/decoded by serializers as &quot;CDPA&quot;.
    /// </summary>
    [EnumMember(Value = "CDPA")]
    [IsoId("_9_rGIAMxEeutW5-TpeYJhA")]
    [Description(@"Collateral is due to party A.|")]
    CollateralDueToPartyA,

    /// <summary>
    /// Collateral is due to party B.
    /// Encoded/decoded by serializers as &quot;CDPB&quot;.
    /// </summary>
    [EnumMember(Value = "CDPB")]
    [IsoId("_Pfo88QMyEeutW5-TpeYJhA")]
    [Description(@"Collateral is due to party B.")]
    CollateralDueToPartyB,
}
