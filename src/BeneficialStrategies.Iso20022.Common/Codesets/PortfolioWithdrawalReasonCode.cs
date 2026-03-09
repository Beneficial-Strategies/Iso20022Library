// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a reason for a withdrawal from the investment product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BNVEUE7bEeifNrXGwadPmg")]
[Description(@"Specifies a reason for a withdrawal from the investment product.")]
[Derivations(typeof(PortfolioWithdrawalReason1Code))]
public enum PortfolioWithdrawalReasonCode
{
    /// <summary>
    /// Withdrawal is for a first time residential property.
    /// Encoded/decoded by serializers as &quot;FTRS&quot;.
    /// </summary>
    [EnumMember(Value = "FTRS")]
    [IsoId("_aXNDQF23EeiFXdiLi_Nf4A")]
    [Description(@"Withdrawal is for a first time residential property.||")]
    FirstTimeResidentialProperty,
    
}
