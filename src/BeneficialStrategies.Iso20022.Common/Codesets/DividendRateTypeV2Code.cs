// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of dividend rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rZdUMOXoEemEj48jhmlA0Q")]
[Description(@"Specifies the type of dividend rate.")]
[Derivations(
    typeof(NetDividendRateType7Code),
    typeof(NetDividendRateType6Code),
    typeof(GrossDividendRateType7Code),
    typeof(GrossDividendRateType6Code)
)]
public enum DividendRateTypeV2Code
{
    /// <summary>
    /// Rate relating to the underlying security for which capital is distributed.
    /// Encoded/decoded by serializers as &quot;CAPO&quot;.
    /// </summary>
    [EnumMember(Value = "CAPO")]
    [IsoId("_rZdUMuXoEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security for which capital is distributed.")]
    CapitalPortion,

    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// Encoded/decoded by serializers as &quot;FLFR&quot;.
    /// </summary>
    [EnumMember(Value = "FLFR")]
    [IsoId("_rZdUPOXoEemEj48jhmlA0Q")]
    [Description(
        @"Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period."
    )]
    FullyFranked,

    /// <summary>
    /// Rate relating to the underlying security for which income is distributed.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_rZdUNuXoEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security for which income is distributed.")]
    IncomePortion,

    /// <summary>
    /// Rate relating to the underlying security for which interest is paid.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_rZdUOeXoEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security for which interest is paid.")]
    Interest,

    /// <summary>
    /// Rate relating to the underlying security for which other income is paid.
    /// Encoded/decoded by serializers as &quot;SOIC&quot;.
    /// </summary>
    [EnumMember(Value = "SOIC")]
    [IsoId("_rZdUOuXoEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security for which other income is paid.")]
    SundryOrOtherIncome,

    /// <summary>
    /// Rate relating to the underlying security for which tax is charged.
    /// Encoded/decoded by serializers as &quot;TXBL&quot;.
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("_rZdUM-XoEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security for which tax is charged.")]
    TaxablePortion,

    /// <summary>
    /// Rate relating to the underlying security for which tax is deferred.
    /// Encoded/decoded by serializers as &quot;TXDF&quot;.
    /// </summary>
    [EnumMember(Value = "TXDF")]
    [IsoId("_rZdUMeXoEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security for which tax is deferred.")]
    TaxDeferred,

    /// <summary>
    /// Rate relating to the underlying security which is not taxable.
    /// Encoded/decoded by serializers as &quot;TXFR&quot;.
    /// </summary>
    [EnumMember(Value = "TXFR")]
    [IsoId("_rZdUNOXoEemEj48jhmlA0Q")]
    [Description(@"Rate relating to the underlying security which is not taxable.")]
    TaxFree,

    /// <summary>
    /// Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax.
    /// Encoded/decoded by serializers as &quot;UNFR&quot;.
    /// </summary>
    [EnumMember(Value = "UNFR")]
    [IsoId("_rZdUNeXoEemEj48jhmlA0Q")]
    [Description(
        @"Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax."
    )]
    Unfranked,

    /// <summary>
    /// Long term capital gain.
    /// Encoded/decoded by serializers as &quot;LTCG&quot;.
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_rZdUN-XoEemEj48jhmlA0Q")]
    [Description(@"Long term capital gain.")]
    LongTermCapitalGain,

    /// <summary>
    /// Short term capital gain.
    /// Encoded/decoded by serializers as &quot;STCG&quot;.
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_rZdUPuXoEemEj48jhmlA0Q")]
    [Description(@"Short term capital gain.")]
    ShortTermCapitalGain,

    /// <summary>
    /// Distribution rate relating to the full period units, for example Group I units in UK.
    /// Encoded/decoded by serializers as &quot;FUPU&quot;.
    /// </summary>
    [EnumMember(Value = "FUPU")]
    [IsoId("_rZdUPeXoEemEj48jhmlA0Q")]
    [Description(
        @"Distribution rate relating to the full period units, for example Group I units in UK."
    )]
    FullPeriodUnitsIncomePortion,

    /// <summary>
    /// Distribution rate relating to the part way period units, for example Group II units in UK.
    /// Encoded/decoded by serializers as &quot;PAPU&quot;.
    /// </summary>
    [EnumMember(Value = "PAPU")]
    [IsoId("_rZdUO-XoEemEj48jhmlA0Q")]
    [Description(
        @"Distribution rate relating to the part way period units, for example Group II units in UK."
    )]
    PartWayPeriodUnitsIncomePortion,

    /// <summary>
    /// Rate of income distribution originated by real estate investment.
    /// Encoded/decoded by serializers as &quot;REES&quot;.
    /// </summary>
    [EnumMember(Value = "REES")]
    [IsoId("_rZdUOOXoEemEj48jhmlA0Q")]
    [Description(@"Rate of income distribution originated by real estate investment.")]
    RealEstatePropertyIncomePortion,

    /// <summary>
    /// Rate relating to a foreign income type such as a conduit foreign income.
    /// Encoded/decoded by serializers as &quot;CDFI&quot;.
    /// </summary>
    [EnumMember(Value = "CDFI")]
    [IsoId("_rZdUP-XoEemEj48jhmlA0Q")]
    [Description(@"Rate relating to a foreign income type such as a conduit foreign income.")]
    ForeignIncome,
}
