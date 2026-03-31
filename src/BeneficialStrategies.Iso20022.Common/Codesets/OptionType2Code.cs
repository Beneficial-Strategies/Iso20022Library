// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset) or any other type of option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__qH_IwNzEeWksqGoe-EFrg")]
[Description(
    @"Specifies whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset) or any other type of option."
)]
[DerivedFrom(typeof(OptionDefinitionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OptionType2Code>))]
#endif
public enum OptionType2Code
{
    /// <summary>
    /// Right to buy a quantity of an asset for an agreed price at exercise date.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("__qRwIANzEeWksqGoe-EFrg")]
    [Description(@"Right to buy a quantity of an asset for an agreed price at exercise date.")]
    Call = OptionDefinitionTypeCode.Call, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Right to sell a quantity of an asset for an agreed price at exercise date.
    /// Encoded/decoded by serializers as &quot;PUTO&quot;.
    /// </summary>
    [EnumMember(Value = "PUTO")]
    [IsoId("__qRwIQNzEeWksqGoe-EFrg")]
    [Description(@"Right to sell a quantity of an asset for an agreed price at exercise date.")]
    Put = OptionDefinitionTypeCode.Put, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Right where the holder of the option decides whether the option is put or call.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_2SzHUQjtEeW36pGcc5RpFw")]
    [Description(
        @"Right where the holder of the option decides whether the option is put or call."
    )]
    Other = OptionDefinitionTypeCode.Other, // same ordinal as derivation source for type conversions
}
