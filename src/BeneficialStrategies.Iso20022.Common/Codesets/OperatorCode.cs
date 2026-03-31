// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code containing the operator used to indicate the relationship between a variable and a fixed value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aPPZMNp-Ed-ak6NoX_4Aeg_336257296")]
[Description(
    @"Code containing the operator used to indicate the relationship between a variable and a fixed value."
)]
[Derivations(typeof(Operator1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OperatorCode>))]
#endif
public enum OperatorCode
{
    /// <summary>
    /// Smaller than.
    /// Encoded/decoded by serializers as &quot;SMAL&quot;.
    /// </summary>
    [EnumMember(Value = "SMAL")]
    [IsoId("_aPPZMdp-Ed-ak6NoX_4Aeg_336257297")]
    [Description(@"Smaller than.")]
    SmallerThan,

    /// <summary>
    /// Smaller or equal to.
    /// Encoded/decoded by serializers as &quot;SMEQ&quot;.
    /// </summary>
    [EnumMember(Value = "SMEQ")]
    [IsoId("_aPPZMtp-Ed-ak6NoX_4Aeg_336257298")]
    [Description(@"Smaller or equal to.")]
    SmallerOrEqualTo,

    /// <summary>
    /// Greater than.
    /// Encoded/decoded by serializers as &quot;GREA&quot;.
    /// </summary>
    [EnumMember(Value = "GREA")]
    [IsoId("_aPPZM9p-Ed-ak6NoX_4Aeg_336257299")]
    [Description(@"Greater than.")]
    GreaterThan,

    /// <summary>
    /// Greater or equal to.
    /// Encoded/decoded by serializers as &quot;GREQ&quot;.
    /// </summary>
    [EnumMember(Value = "GREQ")]
    [IsoId("_aPPZNNp-Ed-ak6NoX_4Aeg_336257300")]
    [Description(@"Greater or equal to.")]
    GreaterOrEqualTo,

    /// <summary>
    /// Equal to.
    /// Encoded/decoded by serializers as &quot;EQAL&quot;.
    /// </summary>
    [EnumMember(Value = "EQAL")]
    [IsoId("_aPPZNdp-Ed-ak6NoX_4Aeg_336257301")]
    [Description(@"Equal to.")]
    EqualTo,
}
