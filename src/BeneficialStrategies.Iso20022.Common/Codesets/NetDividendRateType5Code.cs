// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of net dividend rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_V46GLZb9Eee8S7xwGG7Veg")]
[Description(@"Specifies the type of net dividend rate.")]
[DerivedFrom(typeof(DividendRateTypeCode))]
public enum NetDividendRateType5Code
{
    /// <summary>
    /// Rate relating to the underlying security for which capital is distributed.
    /// Encoded/decoded by serializers as &quot;CAPO&quot;.
    /// </summary>
    [EnumMember(Value = "CAPO")]
    [IsoId("_V46GM5b9Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which capital is distributed.")]
    CapitalPortion = DividendRateTypeCode.CapitalPortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// Encoded/decoded by serializers as &quot;FLFR&quot;.
    /// </summary>
    [EnumMember(Value = "FLFR")]
    [IsoId("_V46GMJb9Eee8S7xwGG7Veg")]
    [Description(
        @"Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period."
    )]
    FullyFranked = DividendRateTypeCode.FullyFranked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which income is distributed.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_V46GNpb9Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which income is distributed.")]
    IncomePortion = DividendRateTypeCode.IncomePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which interest is paid.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_V46GL5b9Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which interest is paid.")]
    Interest = DividendRateTypeCode.Interest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which other income is paid.
    /// Encoded/decoded by serializers as &quot;SOIC&quot;.
    /// </summary>
    [EnumMember(Value = "SOIC")]
    [IsoId("_V46GOJb9Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which other income is paid.")]
    SundryOrOtherIncome = DividendRateTypeCode.SundryOrOtherIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which tax is charged.
    /// Encoded/decoded by serializers as &quot;TXBL&quot;.
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("_V46GOZb9Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which tax is charged.")]
    TaxablePortion = DividendRateTypeCode.TaxablePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which tax is deferred.
    /// Encoded/decoded by serializers as &quot;TXDF&quot;.
    /// </summary>
    [EnumMember(Value = "TXDF")]
    [IsoId("_V46GNZb9Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which tax is deferred.")]
    TaxDeferred = DividendRateTypeCode.TaxDeferred, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security which is not taxable.
    /// Encoded/decoded by serializers as &quot;TXFR&quot;.
    /// </summary>
    [EnumMember(Value = "TXFR")]
    [IsoId("_V46GMpb9Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security which is not taxable.")]
    TaxFree = DividendRateTypeCode.TaxFree, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax.
    /// Encoded/decoded by serializers as &quot;UNFR&quot;.
    /// </summary>
    [EnumMember(Value = "UNFR")]
    [IsoId("_V46GMZb9Eee8S7xwGG7Veg")]
    [Description(
        @"Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax."
    )]
    Unfranked = DividendRateTypeCode.Unfranked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution rate relating to the full period units, for example Group I units in UK.
    /// Encoded/decoded by serializers as &quot;FUPU&quot;.
    /// </summary>
    [EnumMember(Value = "FUPU")]
    [IsoId("_V46GLpb9Eee8S7xwGG7Veg")]
    [Description(
        @"Distribution rate relating to the full period units, for example Group I units in UK."
    )]
    FullPeriodUnitsIncomePortion = DividendRateTypeCode.FullPeriodUnitsIncomePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution rate relating to the part way period units, for example Group II units in UK.
    /// Encoded/decoded by serializers as &quot;PAPU&quot;.
    /// </summary>
    [EnumMember(Value = "PAPU")]
    [IsoId("_V46GN5b9Eee8S7xwGG7Veg")]
    [Description(
        @"Distribution rate relating to the part way period units, for example Group II units in UK."
    )]
    PartWayPeriodUnitsIncomePortion = DividendRateTypeCode.PartWayPeriodUnitsIncomePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate of income distribution originated by real estate investment.
    /// Encoded/decoded by serializers as &quot;REES&quot;.
    /// </summary>
    [EnumMember(Value = "REES")]
    [IsoId("_V46GNJb9Eee8S7xwGG7Veg")]
    [Description(@"Rate of income distribution originated by real estate investment.")]
    RealEstatePropertyIncomePortion = DividendRateTypeCode.RealEstatePropertyIncomePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to a conduit foreign income type.
    /// Encoded/decoded by serializers as &quot;CDFI&quot;.
    /// </summary>
    [EnumMember(Value = "CDFI")]
    [IsoId("_Z23JcZb9Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to a conduit foreign income type.")]
    ConduitForeignIncome = DividendRateTypeCode.ConduitForeignIncome, // same ordinal as derivation source for type conversions
}
