// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification or qualification of the type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_or7VMPfKEei89sMSHxl1ew")]
[Description(@"Identification or qualification of the type of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount19Code
{
    /// <summary>
    /// Telephone connection-related charge
    /// Encoded/decoded by serializers as &quot;CONN&quot;.
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_d9j_0X0mEemfrNOe0zHQyg")]
    [Description(@"Telephone connection-related charge")]
    Connect = TypeOfAmountCode.Connect, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insurance charges
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_d9j_030mEemfrNOe0zHQyg")]
    [Description(@"Insurance charges ")]
    Insurance = TypeOfAmountCode.Insurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges related to a long distance call.
    /// Encoded/decoded by serializers as &quot;LNDS&quot;.
    /// </summary>
    [EnumMember(Value = "LNDS")]
    [IsoId("_d9j_1X0mEemfrNOe0zHQyg")]
    [Description(@"Charges related to a long distance call. ")]
    LongDistance = TypeOfAmountCode.LongDistance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Miscellaneous charges not elsewhere defined
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_d9j_130mEemfrNOe0zHQyg")]
    [Description(@"Miscellaneous charges not elsewhere defined")]
    Miscellaneous = TypeOfAmountCode.Miscellaneous, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of amount defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_d9j_2X0mEemfrNOe0zHQyg")]
    [Description(@"Other type of amount defined at national level.")]
    OtherNational = TypeOfAmountCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of amount defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_d9j_230mEemfrNOe0zHQyg")]
    [Description(@"Other type of amount defined at private level.")]
    OtherPrivate = TypeOfAmountCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Telephone usage-related charge
    /// Encoded/decoded by serializers as &quot;USGE&quot;.
    /// </summary>
    [EnumMember(Value = "USGE")]
    [IsoId("_d9j_3X0mEemfrNOe0zHQyg")]
    [Description(@"Telephone usage-related charge")]
    Usage = TypeOfAmountCode.Usage, // same ordinal as derivation source for type conversions
}
