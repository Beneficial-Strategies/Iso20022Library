// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of price is unspecified.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_K3qasA-zEeuE0Pnt-OcNOA")]
[Description(@"Type of price is unspecified.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType13Code
{
    /// <summary>
    /// Price is not required to be specified by account owner.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_M2HEYQ-zEeuE0Pnt-OcNOA")]
    [Description(@"Price is not required to be specified by account owner.")]
    Unspecified = PriceValueTypeCode.Unspecified, // same ordinal as derivation source for type conversions
}
