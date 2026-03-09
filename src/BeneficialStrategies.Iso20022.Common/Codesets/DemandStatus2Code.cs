// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the demand for payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fB3IgHyaEeGWJuGCfvwOsQ")]
[Description(@"Specifies the status of the demand for payment.")]
[DerivedFrom(typeof(DemandStatusCode))]
public enum DemandStatus2Code
{
    /// <summary>
    /// Demand refused.
    /// Encoded/decoded by serializers as &quot;REFD&quot;.
    /// </summary>
    [EnumMember(Value = "REFD")]
    [IsoId("_kDeoRnyaEeGWJuGCfvwOsQ")]
    [Description(@"Demand refused.")]
    Refused = DemandStatusCode.Refused, // same ordinal as derivation source for type conversions
    
}
