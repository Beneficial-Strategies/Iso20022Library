// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of price value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UVsIweEJEd-udr336SN7mQ")]
[Description(@"Specifies a type of price value.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType8Code
{
    /// <summary>
    /// Price to be specified by account owner.
    /// Encoded/decoded by serializers as &quot;TBSP&quot;.
    /// </summary>
    [EnumMember(Value = "TBSP")]
    [IsoId("_q5RTNmtdEeCY4-KZ9JEyUQ_2120036301")]
    [Description(@"Price to be specified by account owner.")]
    ToBeSpecified = PriceValueTypeCode.ToBeSpecified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is not required to be specified by account owner.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_q5bEMGtdEeCY4-KZ9JEyUQ_945022265")]
    [Description(@"Price is not required to be specified by account owner.")]
    Unspecified = PriceValueTypeCode.Unspecified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_q5bEMWtdEeCY4-KZ9JEyUQ_-52050088")]
    [Description(@"Price is unknown by the sender or has not been established.")]
    Unknown = PriceValueTypeCode.Unknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price will not be paid.
    /// Encoded/decoded by serializers as &quot;NILP&quot;.
    /// </summary>
    [EnumMember(Value = "NILP")]
    [IsoId("_q5bEMmtdEeCY4-KZ9JEyUQ_1399109534")]
    [Description(@"Price will not be paid.")]
    NilPayment = PriceValueTypeCode.NilPayment, // same ordinal as derivation source for type conversions
}
