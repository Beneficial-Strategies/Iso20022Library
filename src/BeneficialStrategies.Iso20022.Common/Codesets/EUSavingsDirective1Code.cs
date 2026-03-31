// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether or not the fund is subject to reporting under the EU Savings Directive. Enter &quot;Variable&quot; if the status of the fund is likely to change from time to time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aiUGM9p-Ed-ak6NoX_4Aeg_511985802")]
[Description(
    @"Indicates whether or not the fund is subject to reporting under the EU Savings Directive. Enter ""Variable"" if the status of the fund is likely to change from time to time."
)]
[DerivedFrom(typeof(EUSavingsDirectiveCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EUSavingsDirective1Code>))]
#endif
public enum EUSavingsDirective1Code
{
    /// <summary>
    /// Investment Fund is in the scope of the directive.
    /// Encoded/decoded by serializers as &quot;EUSI&quot;.
    /// </summary>
    [EnumMember(Value = "EUSI")]
    [IsoId("_aiUGNNp-Ed-ak6NoX_4Aeg_796430025")]
    [Description(@"Investment Fund is in the scope of the directive.")]
    EUSavingsInScope = EUSavingsDirectiveCode.EUSavingsInScope, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment Fund is out of the scope of the directive.
    /// Encoded/decoded by serializers as &quot;EUSO&quot;.
    /// </summary>
    [EnumMember(Value = "EUSO")]
    [IsoId("_aiUGNdp-Ed-ak6NoX_4Aeg_796430056")]
    [Description(@"Investment Fund is out of the scope of the directive.")]
    EUSavingsOutScope = EUSavingsDirectiveCode.EUSavingsOutScope, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment Fund may vary for inclusion in the scope of the directive.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_ai58ENp-Ed-ak6NoX_4Aeg_796430057")]
    [Description(@"Investment Fund may vary for inclusion in the scope of the directive.")]
    EUSavingsVariable = EUSavingsDirectiveCode.EUSavingsVariable, // same ordinal as derivation source for type conversions
}
