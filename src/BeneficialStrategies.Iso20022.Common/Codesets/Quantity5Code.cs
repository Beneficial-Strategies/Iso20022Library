// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies quantity of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lYWb4QFIEeGhYJiRaPcH8g")]
[Description(@"Specifies quantity of a financial instrument.")]
[DerivedFrom(typeof(QuantityCode))]
public enum Quantity5Code
{
    /// <summary>
    /// Quantity is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_lYgM6QFIEeGhYJiRaPcH8g")]
    [Description(@"Quantity is unknown by the sender or has not been established.")]
    UnknownQuantity = QuantityCode.UnknownQuantity, // same ordinal as derivation source for type conversions
}
