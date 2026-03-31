// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of dividend rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ghpRXZb7Eee8S7xwGG7Veg")]
[Description(@"Specifies the type of dividend rate.")]
[DerivedFrom(typeof(DividendRateTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<GrossDividendRateType4Code>))]
#endif
public enum GrossDividendRateType4Code
{
    /// <summary>
    /// Rate relating to the underlying security for which capital is distributed.
    /// Encoded/decoded by serializers as &quot;CAPO&quot;.
    /// </summary>
    [EnumMember(Value = "CAPO")]
    [IsoId("_ghpRZpb7Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which capital is distributed.")]
    CapitalPortion = DividendRateTypeCode.CapitalPortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// Encoded/decoded by serializers as &quot;FLFR&quot;.
    /// </summary>
    [EnumMember(Value = "FLFR")]
    [IsoId("_ghpRZZb7Eee8S7xwGG7Veg")]
    [Description(
        @"Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period."
    )]
    FullyFranked = DividendRateTypeCode.FullyFranked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which income is distributed.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_ghpRZ5b7Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which income is distributed.")]
    IncomePortion = DividendRateTypeCode.IncomePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which interest is paid.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_ghpRX5b7Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which interest is paid.")]
    Interest = DividendRateTypeCode.Interest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Long term capital gain.
    /// Encoded/decoded by serializers as &quot;LTCG&quot;.
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_ghpRXpb7Eee8S7xwGG7Veg")]
    [Description(@"Long term capital gain.")]
    LongTermCapitalGain = DividendRateTypeCode.LongTermCapitalGain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate of income distribution originated by real estate investment.
    /// Encoded/decoded by serializers as &quot;REES&quot;.
    /// </summary>
    [EnumMember(Value = "REES")]
    [IsoId("_ghpRYZb7Eee8S7xwGG7Veg")]
    [Description(@"Rate of income distribution originated by real estate investment.")]
    RealEstatePropertyIncomePortion = DividendRateTypeCode.RealEstatePropertyIncomePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Short term capital gain.
    /// Encoded/decoded by serializers as &quot;STCG&quot;.
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_ghpRY5b7Eee8S7xwGG7Veg")]
    [Description(@"Short term capital gain.")]
    ShortTermCapitalGain = DividendRateTypeCode.ShortTermCapitalGain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which other income is paid.
    /// Encoded/decoded by serializers as &quot;SOIC&quot;.
    /// </summary>
    [EnumMember(Value = "SOIC")]
    [IsoId("_ghpRaZb7Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which other income is paid.")]
    SundryOrOtherIncome = DividendRateTypeCode.SundryOrOtherIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which tax is charged.
    /// Encoded/decoded by serializers as &quot;TXBL&quot;.
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("_ghpRZJb7Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which tax is charged.")]
    TaxablePortion = DividendRateTypeCode.TaxablePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which tax is deferred.
    /// Encoded/decoded by serializers as &quot;TXDF&quot;.
    /// </summary>
    [EnumMember(Value = "TXDF")]
    [IsoId("_ghpRYJb7Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which tax is deferred.")]
    TaxDeferred = DividendRateTypeCode.TaxDeferred, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security which is not taxable.
    /// Encoded/decoded by serializers as &quot;TXFR&quot;.
    /// </summary>
    [EnumMember(Value = "TXFR")]
    [IsoId("_ghpRaJb7Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security which is not taxable.")]
    TaxFree = DividendRateTypeCode.TaxFree, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax.
    /// Encoded/decoded by serializers as &quot;UNFR&quot;.
    /// </summary>
    [EnumMember(Value = "UNFR")]
    [IsoId("_ghpRYpb7Eee8S7xwGG7Veg")]
    [Description(
        @"Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax."
    )]
    Unfranked = DividendRateTypeCode.Unfranked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to a conduit foreign income type.
    /// Encoded/decoded by serializers as &quot;CDFI&quot;.
    /// </summary>
    [EnumMember(Value = "CDFI")]
    [IsoId("_luUKgZb7Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to a conduit foreign income type.")]
    ConduitForeignIncome = DividendRateTypeCode.ConduitForeignIncome, // same ordinal as derivation source for type conversions
}
