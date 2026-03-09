// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies that there is no criteria.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aNcpctp-Ed-ak6NoX_4Aeg_-849280423")]
[Description(@"Specifies that there is no criteria.")]
[DerivedFrom(typeof(NoCriteriaCode))]
public enum NoCriteria1Code
{
    /// <summary>
    /// No criteria.
    /// Encoded/decoded by serializers as &quot;NOCR&quot;.
    /// </summary>
    [EnumMember(Value = "NOCR")]
    [IsoId("_aNcpc9p-Ed-ak6NoX_4Aeg_-678428636")]
    [Description(@"No criteria.")]
    NoCriteria = NoCriteriaCode.NoCriteria, // same ordinal as derivation source for type conversions
    
}
