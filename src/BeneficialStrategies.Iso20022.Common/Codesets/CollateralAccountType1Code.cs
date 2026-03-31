// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the collateral account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_waeVkKMOEeCojJW5vEuTEQ_-1553937362")]
[Description(@"Specifies the collateral account type.")]
[DerivedFrom(typeof(CollateralAccountTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralAccountType1Code>))]
#endif
public enum CollateralAccountType1Code
{
    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries.
    /// Encoded/decoded by serializers as &quot;HOUS&quot;.
    /// </summary>
    [EnumMember(Value = "HOUS")]
    [IsoId("_waeVkaMOEeCojJW5vEuTEQ_-1208405254")]
    [Description(
        @"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries."
    )]
    House = CollateralAccountTypeCode.House, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for the clearing member&apos;s customers.
    /// Encoded/decoded by serializers as &quot;CLIE&quot;.
    /// </summary>
    [EnumMember(Value = "CLIE")]
    [IsoId("_waeVkqMOEeCojJW5vEuTEQ_-754317985")]
    [Description(
        @"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for the clearing member's customers."
    )]
    Client = CollateralAccountTypeCode.Client, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for liquidity providers (also known as market maker) activities.
    /// Encoded/decoded by serializers as &quot;LIPR&quot;.
    /// </summary>
    [EnumMember(Value = "LIPR")]
    [IsoId("_waeVk6MOEeCojJW5vEuTEQ_712830778")]
    [Description(
        @"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for liquidity providers (also known as market maker) activities."
    )]
    LiquidityProvider = CollateralAccountTypeCode.LiquidityProvider, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries, or for the clearing member&apos;s customers.
    /// Encoded/decoded by serializers as &quot;MGIN&quot;.
    /// </summary>
    [EnumMember(Value = "MGIN")]
    [IsoId("_waeVlKMOEeCojJW5vEuTEQ_-765416762")]
    [Description(
        @"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries, or for the clearing member's customers."
    )]
    Margin = CollateralAccountTypeCode.Margin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the account is used to post collateral that covers clearing member&apos;s default risk.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_waeVlaMOEeCojJW5vEuTEQ_701732001")]
    [Description(
        @"Specifies that the account is used to post collateral that covers clearing member's default risk."
    )]
    DefaultFund = CollateralAccountTypeCode.DefaultFund, // same ordinal as derivation source for type conversions
}
