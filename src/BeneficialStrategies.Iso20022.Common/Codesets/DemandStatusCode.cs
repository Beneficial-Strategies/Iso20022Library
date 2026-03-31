// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the demand for payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xyDjAHyYEeGWJuGCfvwOsQ")]
[Description(@"Specifies the status of the demand for payment.")]
[Derivations(typeof(DemandStatus1Code), typeof(DemandStatus2Code))]
public enum DemandStatusCode
{
    /// <summary>
    /// Demand refused.
    /// Encoded/decoded by serializers as &quot;REFD&quot;.
    /// </summary>
    [EnumMember(Value = "REFD")]
    [IsoId("_V0vHEHyZEeGWJuGCfvwOsQ")]
    [Description(@"Demand refused.")]
    Refused,

    /// <summary>
    /// Extend undertaking expiry date.
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_WJq0INryEeGuxusC7C-WeA")]
    [Description(@"Extend undertaking expiry date.")]
    Extend,

    /// <summary>
    /// Pay undertaking demand.
    /// Encoded/decoded by serializers as &quot;PAYD&quot;.
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_nrhhUNryEeGuxusC7C-WeA")]
    [Description(@"Pay undertaking demand.")]
    PAY,
}
