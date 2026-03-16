// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the value of a price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yb9UkeEQEd-1Ktb5rVaajw")]
[Description(@"Specifies the value of a price.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType10Code
{
    /// <summary>
    /// Price is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_q5RTNWtdEeCY4-KZ9JEyUQ_1587696077")]
    [Description(@"Price is unknown by the sender or has not been established.")]
    Unknown = PriceValueTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
