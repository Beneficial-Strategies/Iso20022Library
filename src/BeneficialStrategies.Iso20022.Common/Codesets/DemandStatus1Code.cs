// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the demand for payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FQp0QHyaEeGWJuGCfvwOsQ")]
[Description(@"Specifies the status of the demand for payment.")]
[DerivedFrom(typeof(DemandStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DemandStatus1Code>))]
#endif
public enum DemandStatus1Code
{
    /// <summary>
    /// Extend undertaking expiry date.
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_wyDoAdryEeGuxusC7C-WeA")]
    [Description(@"Extend undertaking expiry date.")]
    Extend = DemandStatusCode.Extend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pay undertaking demand.
    /// Encoded/decoded by serializers as &quot;PAYD&quot;.
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_w7l-gdryEeGuxusC7C-WeA")]
    [Description(@"Pay undertaking demand.")]
    PAY = DemandStatusCode.PAY, // same ordinal as derivation source for type conversions
}
