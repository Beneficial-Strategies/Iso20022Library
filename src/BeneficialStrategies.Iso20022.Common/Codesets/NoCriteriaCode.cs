// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies that there is no criteria.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aNcpdNp-Ed-ak6NoX_4Aeg_-452167930")]
[Description(@"Specifies that there is no criteria.")]
[Derivations(typeof(NoCriteria1Code))]
public enum NoCriteriaCode
{
    /// <summary>
    /// No criteria.
    /// Encoded/decoded by serializers as &quot;NOCR&quot;.
    /// </summary>
    [EnumMember(Value = "NOCR")]
    [IsoId("_aNcpddp-Ed-ak6NoX_4Aeg_-365356859")]
    [Description(@"No criteria.")]
    NoCriteria,
}
