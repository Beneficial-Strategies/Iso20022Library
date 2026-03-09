// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of dividend rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axET5tp-Ed-ak6NoX_4Aeg_-411764395")]
[Description(@"Specifies the type of dividend rate.")]
[Derivations(typeof(NetDividendRateType2Code),typeof(GrossDividendRateType4Code),typeof(GrossDividendRateType5Code),typeof(NetDividendRateType4Code),typeof(NetDividendRateType3Code),typeof(NetDividendRateType5Code),typeof(GrossDividendRateType3Code),typeof(NetDividendRateType1Code),typeof(DividendRateType1Code),typeof(GrossDividendRateType2Code),typeof(GrossDividendRateType1Code))]
public enum DividendRateTypeCode
{
    /// <summary>
    /// Rate relating to the underlying security for which capital is distributed.
    /// Encoded/decoded by serializers as &quot;CAPO&quot;.
    /// </summary>
    [EnumMember(Value = "CAPO")]
    [IsoId("_axET59p-Ed-ak6NoX_4Aeg_-94999049")]
    [Description(@"Rate relating to the underlying security for which capital is distributed.")]
    CapitalPortion,
    
    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// Encoded/decoded by serializers as &quot;FLFR&quot;.
    /// </summary>
    [EnumMember(Value = "FLFR")]
    [IsoId("_axET6Np-Ed-ak6NoX_4Aeg_-94999018")]
    [Description(@"Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period.")]
    FullyFranked,
    
    /// <summary>
    /// Rate relating to the underlying security for which income is distributed.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_axNd0Np-Ed-ak6NoX_4Aeg_-94999017")]
    [Description(@"Rate relating to the underlying security for which income is distributed.")]
    IncomePortion,
    
    /// <summary>
    /// Rate relating to the underlying security for which interest is paid.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_axNd0dp-Ed-ak6NoX_4Aeg_-94998988")]
    [Description(@"Rate relating to the underlying security for which interest is paid.")]
    Interest,
    
    /// <summary>
    /// Rate relating to the underlying security for which other income is paid.
    /// Encoded/decoded by serializers as &quot;SOIC&quot;.
    /// </summary>
    [EnumMember(Value = "SOIC")]
    [IsoId("_axNd0tp-Ed-ak6NoX_4Aeg_-94998957")]
    [Description(@"Rate relating to the underlying security for which other income is paid.")]
    SundryOrOtherIncome,
    
    /// <summary>
    /// Rate relating to the underlying security for which tax is charged.
    /// Encoded/decoded by serializers as &quot;TXBL&quot;.
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("_axNd09p-Ed-ak6NoX_4Aeg_-94998710")]
    [Description(@"Rate relating to the underlying security for which tax is charged.")]
    TaxablePortion,
    
    /// <summary>
    /// Rate relating to the underlying security for which tax is deferred.
    /// Encoded/decoded by serializers as &quot;TXDF&quot;.
    /// </summary>
    [EnumMember(Value = "TXDF")]
    [IsoId("_axNd1Np-Ed-ak6NoX_4Aeg_-94998679")]
    [Description(@"Rate relating to the underlying security for which tax is deferred.")]
    TaxDeferred,
    
    /// <summary>
    /// Rate relating to the underlying security which is not taxable.
    /// Encoded/decoded by serializers as &quot;TXFR&quot;.
    /// </summary>
    [EnumMember(Value = "TXFR")]
    [IsoId("_axNd1dp-Ed-ak6NoX_4Aeg_-94998648")]
    [Description(@"Rate relating to the underlying security which is not taxable.")]
    TaxFree,
    
    /// <summary>
    /// Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax.
    /// Encoded/decoded by serializers as &quot;UNFR&quot;.
    /// </summary>
    [EnumMember(Value = "UNFR")]
    [IsoId("_axNd1tp-Ed-ak6NoX_4Aeg_-94998618")]
    [Description(@"Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax.")]
    Unfranked,
    
    /// <summary>
    /// Long term capital gain.
    /// Encoded/decoded by serializers as &quot;LTCG&quot;.
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_axNd19p-Ed-ak6NoX_4Aeg_-94998587")]
    [Description(@"Long term capital gain.")]
    LongTermCapitalGain,
    
    /// <summary>
    /// Short term capital gain.
    /// Encoded/decoded by serializers as &quot;STCG&quot;.
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_axNd2Np-Ed-ak6NoX_4Aeg_-94998556")]
    [Description(@"Short term capital gain.")]
    ShortTermCapitalGain,
    
    /// <summary>
    /// Distribution rate relating to the full period units, for example Group I units in UK.
    /// Encoded/decoded by serializers as &quot;FUPU&quot;.
    /// </summary>
    [EnumMember(Value = "FUPU")]
    [IsoId("_KiETEDrSEeKNP9OxU1sgfw_-487019510")]
    [Description(@"Distribution rate relating to the full period units, for example Group I units in UK.")]
    FullPeriodUnitsIncomePortion,
    
    /// <summary>
    /// Distribution rate relating to the part way period units, for example Group II units in UK.
    /// Encoded/decoded by serializers as &quot;PAPU&quot;.
    /// </summary>
    [EnumMember(Value = "PAPU")]
    [IsoId("_KiETETrSEeKNP9OxU1sgfw_-2094234412")]
    [Description(@"Distribution rate relating to the part way period units, for example Group II units in UK.")]
    PartWayPeriodUnitsIncomePortion,
    
    /// <summary>
    /// Rate of income distribution originated by real estate investment.
    /// Encoded/decoded by serializers as &quot;REES&quot;.
    /// </summary>
    [EnumMember(Value = "REES")]
    [IsoId("_KiNdADrSEeKNP9OxU1sgfw_1791653802")]
    [Description(@"Rate of income distribution originated by real estate investment.")]
    RealEstatePropertyIncomePortion,
    
    /// <summary>
    /// Rate relating to a conduit foreign income type.
    /// Encoded/decoded by serializers as &quot;CDFI&quot;.
    /// </summary>
    [EnumMember(Value = "CDFI")]
    [IsoId("_Z1eUQJb7Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to a conduit foreign income type.")]
    ConduitForeignIncome,
    
}
