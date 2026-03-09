// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NxoFMeEREd-1Ktb5rVaajw")]
[Description(@"Specifies the type of rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateType13Code
{
    /// <summary>
    /// Rate is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_q5kOIWtdEeCY4-KZ9JEyUQ_1754715972")]
    [Description(@"Rate is unknown by the sender or has not been established.")]
    Unknown = RateTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate will not be paid.
    /// Encoded/decoded by serializers as &quot;NILP&quot;.
    /// </summary>
    [EnumMember(Value = "NILP")]
    [IsoId("_q5kOImtdEeCY4-KZ9JEyUQ_-228191112")]
    [Description(@"Rate will not be paid.")]
    NilPayment = RateTypeCode.NilPayment, // same ordinal as derivation source for type conversions
    
}
