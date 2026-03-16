// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code containing the operator used to indicate the relationship between a variable and a fixed value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aPFoM9p-Ed-ak6NoX_4Aeg_1632624571")]
[Description(
    @"Code containing the operator used to indicate the relationship between a variable and a fixed value."
)]
[DerivedFrom(typeof(OperatorCode))]
public enum Operator1Code
{
    /// <summary>
    /// Smaller than.
    /// Encoded/decoded by serializers as &quot;SMAL&quot;.
    /// </summary>
    [EnumMember(Value = "SMAL")]
    [IsoId("_aPFoNNp-Ed-ak6NoX_4Aeg_1687113130")]
    [Description(@"Smaller than.")]
    SmallerThan = OperatorCode.SmallerThan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Smaller or equal to.
    /// Encoded/decoded by serializers as &quot;SMEQ&quot;.
    /// </summary>
    [EnumMember(Value = "SMEQ")]
    [IsoId("_aPFoNdp-Ed-ak6NoX_4Aeg_1687113165")]
    [Description(@"Smaller or equal to.")]
    SmallerOrEqualTo = OperatorCode.SmallerOrEqualTo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Greater than.
    /// Encoded/decoded by serializers as &quot;GREA&quot;.
    /// </summary>
    [EnumMember(Value = "GREA")]
    [IsoId("_aPFoNtp-Ed-ak6NoX_4Aeg_1687113207")]
    [Description(@"Greater than.")]
    GreaterThan = OperatorCode.GreaterThan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Greater or equal to.
    /// Encoded/decoded by serializers as &quot;GREQ&quot;.
    /// </summary>
    [EnumMember(Value = "GREQ")]
    [IsoId("_aPFoN9p-Ed-ak6NoX_4Aeg_1687113250")]
    [Description(@"Greater or equal to.")]
    GreaterOrEqualTo = OperatorCode.GreaterOrEqualTo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equal to.
    /// Encoded/decoded by serializers as &quot;EQAL&quot;.
    /// </summary>
    [EnumMember(Value = "EQAL")]
    [IsoId("_aPFoONp-Ed-ak6NoX_4Aeg_1687113519")]
    [Description(@"Equal to.")]
    EqualTo = OperatorCode.EqualTo, // same ordinal as derivation source for type conversions
}
