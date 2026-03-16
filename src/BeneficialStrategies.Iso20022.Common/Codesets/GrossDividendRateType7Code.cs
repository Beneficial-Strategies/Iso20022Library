// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of dividend rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jy6uoOXqEemEj48jhmlA0Q")]
[Description(@"Specifies the type of dividend rate.")]
[DerivedFrom(typeof(DividendRateTypeV2Code))]
public enum GrossDividendRateType7Code
{
    /// <summary>
    /// Rate relating to the underlying security for which capital is distributed.
    /// Encoded/decoded by serializers as &quot;CAPO&quot;.
    /// </summary>
    [EnumMember(Value = "CAPO")]
    [IsoId("_ojdsgeXqEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security for which capital is distributed.")]
    CapitalPortion = DividendRateTypeV2Code.CapitalPortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to a foreign income type such as a conduit foreign income.
    /// Encoded/decoded by serializers as &quot;CDFI&quot;.
    /// </summary>
    [EnumMember(Value = "CDFI")]
    [IsoId("_oy7r4eXqEemEj48jhmlA0Q")]
    [Description(@"Rate relating to a foreign income type such as a conduit foreign income.")]
    ForeignIncome = DividendRateTypeV2Code.ForeignIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution rate relating to the full period units, for example Group I units in UK.
    /// Encoded/decoded by serializers as &quot;FUPU&quot;.
    /// </summary>
    [EnumMember(Value = "FUPU")]
    [IsoId("_pWfr8eXqEemEj48jhmlA0Q")]
    [Description(
        @"Distribution rate relating to the full period units, for example Group I units in UK."
    )]
    FullPeriodUnitsIncomePortion = DividendRateTypeV2Code.FullPeriodUnitsIncomePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// Encoded/decoded by serializers as &quot;FLFR&quot;.
    /// </summary>
    [EnumMember(Value = "FLFR")]
    [IsoId("_psz6MeXqEemEj48jhmlA0Q")]
    [Description(
        @"Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period."
    )]
    FullyFranked = DividendRateTypeV2Code.FullyFranked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which income is distributed.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_qGPt4eXqEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security for which income is distributed.")]
    IncomePortion = DividendRateTypeV2Code.IncomePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which interest is paid.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_qSv40eXqEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security for which interest is paid.")]
    Interest = DividendRateTypeV2Code.Interest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Long term capital gain.
    /// Encoded/decoded by serializers as &quot;LTCG&quot;.
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_qeDJ4eXqEemEj48jhmlA0Q")]
    [Description(@"Long term capital gain.")]
    LongTermCapitalGain = DividendRateTypeV2Code.LongTermCapitalGain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution rate relating to the part way period units, for example Group II units in UK.
    /// Encoded/decoded by serializers as &quot;PAPU&quot;.
    /// </summary>
    [EnumMember(Value = "PAPU")]
    [IsoId("_q4PLgeXqEemEj48jhmlA0Q")]
    [Description(
        @"Distribution rate relating to the part way period units, for example Group II units in UK."
    )]
    PartWayPeriodUnitsIncomePortion = DividendRateTypeV2Code.PartWayPeriodUnitsIncomePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate of income distribution originated by real estate investment.
    /// Encoded/decoded by serializers as &quot;REES&quot;.
    /// </summary>
    [EnumMember(Value = "REES")]
    [IsoId("_sZh_IeXqEemEj48jhmlA0Q")]
    [Description(@"Rate of income distribution originated by real estate investment.")]
    RealEstatePropertyIncomePortion = DividendRateTypeV2Code.RealEstatePropertyIncomePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Short term capital gain.
    /// Encoded/decoded by serializers as &quot;STCG&quot;.
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_skQBYeXqEemEj48jhmlA0Q")]
    [Description(@"Short term capital gain.")]
    ShortTermCapitalGain = DividendRateTypeV2Code.ShortTermCapitalGain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which other income is paid.
    /// Encoded/decoded by serializers as &quot;SOIC&quot;.
    /// </summary>
    [EnumMember(Value = "SOIC")]
    [IsoId("_s4LqAeXqEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security for which other income is paid.")]
    SundryOrOtherIncome = DividendRateTypeV2Code.SundryOrOtherIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which tax is charged.
    /// Encoded/decoded by serializers as &quot;TXBL&quot;.
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("_tPZQIeXqEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security for which tax is charged.")]
    TaxablePortion = DividendRateTypeV2Code.TaxablePortion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security for which tax is deferred.
    /// Encoded/decoded by serializers as &quot;TXDF&quot;.
    /// </summary>
    [EnumMember(Value = "TXDF")]
    [IsoId("_taP1QeXqEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security for which tax is deferred.")]
    TaxDeferred = DividendRateTypeV2Code.TaxDeferred, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate relating to the underlying security which is not taxable.
    /// Encoded/decoded by serializers as &quot;TXFR&quot;.
    /// </summary>
    [EnumMember(Value = "TXFR")]
    [IsoId("_tvOmweXqEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security which is not taxable.")]
    TaxFree = DividendRateTypeV2Code.TaxFree, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax.
    /// Encoded/decoded by serializers as &quot;UNFR&quot;.
    /// </summary>
    [EnumMember(Value = "UNFR")]
    [IsoId("_uKKPQeXqEemEj48jhmlA0Q")]
    [Description(
        @"Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax."
    )]
    Unfranked = DividendRateTypeV2Code.Unfranked, // same ordinal as derivation source for type conversions
}
