// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if income is to be paid out (distributed) or retained (accumulated).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awwx5dp-Ed-ak6NoX_4Aeg_-1525096597")]
[Description(@"Specifies if income is to be paid out (distributed) or retained (accumulated).")]
[Derivations(typeof(DistributionPolicy1Code))]
public enum DistributionPolicyCode
{
    /// <summary>
    /// Income is distributed to the investors in the fund.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_awwx5tp-Ed-ak6NoX_4Aeg_1041617774")]
    [Description(@"Income is distributed to the investors in the fund.")]
    Distribution,
    
    /// <summary>
    /// Income is added to the capital of the fund.
    /// Encoded/decoded by serializers as &quot;ACCU&quot;.
    /// </summary>
    [EnumMember(Value = "ACCU")]
    [IsoId("_aw6i4Np-Ed-ak6NoX_4Aeg_1041617805")]
    [Description(@"Income is added to the capital of the fund.")]
    Accumulation,
    
}
