// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the detailed sub products types allowed for commodity derivative.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_O1x5odDiEeSv_Pll20DdbA")]
[Description(@"Specifies the detailed sub products types allowed for commodity derivative.")]
[Derivations(typeof(AssetClassDetailedSubProductType29Code),typeof(AssetClassDetailedSubProductType31Code),typeof(AssetClassDetailedSubProductType34Code),typeof(AssetClassDetailedSubProductType7Code),typeof(AssetClassDetailedSubProductType4Code),typeof(AssetClassDetailedSubProductType12Code),typeof(AssetClassDetailedSubProductType16Code),typeof(AssetClassDetailedSubProductType8Code),typeof(AssetClassDetailedSubProductType11Code),typeof(AssetFXSubProductType1Code),typeof(EmissionAllowanceProductType1Code),typeof(AssetClassDetailedSubProductType10Code),typeof(AssetClassDetailedSubProductType30Code),typeof(AssetClassDetailedSubProductType14Code),typeof(AssetClassDetailedSubProductType2Code),typeof(AssetClassDetailedSubProductType32Code),typeof(EmissionAllowanceProductType2Code),typeof(AssetClassDetailedSubProductType33Code),typeof(AssetClassDetailedSubProductType5Code),typeof(AssetClassDetailedSubProductType6Code),typeof(AssetClassDetailedSubProductType15Code),typeof(AssetClassDetailedSubProductType1Code))]
public enum AssetClassDetailedSubProductTypeCode
{
    /// <summary>
    /// Commodity attribute of type foreign exchange cross rate.
    /// Encoded/decoded by serializers as &quot;FXCR&quot;.
    /// </summary>
    [EnumMember(Value = "FXCR")]
    [IsoId("_f0RbENDiEeSv_Pll20DdbA")]
    [Description(@"Commodity attribute of type foreign exchange cross rate.")]
    ForeignExchangeCrossRate,
    
    /// <summary>
    /// Commodity attribute of type foreign exchange emerging markets.
    /// Encoded/decoded by serializers as &quot;FXEM&quot;.
    /// </summary>
    [EnumMember(Value = "FXEM")]
    [IsoId("_lsz7wNDiEeSv_Pll20DdbA")]
    [Description(@"Commodity attribute of type foreign exchange emerging markets.")]
    ForeignExchangeEmergingMarket,
    
    /// <summary>
    /// Commodity attribute of type foreign exchange majors.
    /// Encoded/decoded by serializers as &quot;FXMJ&quot;.
    /// </summary>
    [EnumMember(Value = "FXMJ")]
    [IsoId("_pcfSgNDiEeSv_Pll20DdbA")]
    [Description(@"Commodity attribute of type foreign exchange majors.")]
    ForeignExchangeMajor,
    
    /// <summary>
    /// Commodity attribute of type feed wheat.
    /// Encoded/decoded by serializers as &quot;FWHT&quot;.
    /// </summary>
    [EnumMember(Value = "FWHT")]
    [IsoId("_fIzKQNDkEeSv_Pll20DdbA")]
    [Description(@"Commodity attribute of type feed wheat.")]
    FeedWheat,
    
    /// <summary>
    /// Commodity attribute of type base load.
    /// Encoded/decoded by serializers as &quot;BSLD&quot;.
    /// </summary>
    [EnumMember(Value = "BSLD")]
    [IsoId("_b9-ssNDnEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type base load.")]
    BaseLoad,
    
    /// <summary>
    /// Commodity attribute of type financial transmission rights.
    /// Encoded/decoded by serializers as &quot;FITR&quot;.
    /// </summary>
    [EnumMember(Value = "FITR")]
    [IsoId("_cBQDINDnEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type financial transmission rights.")]
    FinancialTransmissionRights,
    
    /// <summary>
    /// Commodity attribute of type peak load.
    /// Encoded/decoded by serializers as &quot;PKLD&quot;.
    /// </summary>
    [EnumMember(Value = "PKLD")]
    [IsoId("_cE0UgNDnEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type peak load.")]
    PeakLoad,
    
    /// <summary>
    /// Commodity attribute of type zinc.
    /// Encoded/decoded by serializers as &quot;ZINC&quot;.
    /// </summary>
    [EnumMember(Value = "ZINC")]
    [IsoId("_te2F8NDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type zinc.")]
    Zinc,
    
    /// <summary>
    /// Commodity attribute of type tin.
    /// Encoded/decoded by serializers as &quot;TINN&quot;.
    /// </summary>
    [EnumMember(Value = "TINN")]
    [IsoId("_tky88NDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type tin.")]
    Tin,
    
    /// <summary>
    /// Commodity attribute of type steel.
    /// Encoded/decoded by serializers as &quot;STEL&quot;.
    /// </summary>
    [EnumMember(Value = "STEL")]
    [IsoId("_tpG1MNDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type steel.")]
    Steel,
    
    /// <summary>
    /// Commodity attribute of type nickel.
    /// Encoded/decoded by serializers as &quot;NICK&quot;.
    /// </summary>
    [EnumMember(Value = "NICK")]
    [IsoId("_trCu4NDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type nickel.")]
    Nickel,
    
    /// <summary>
    /// Commodity attribute of type emissions allowance CER (Certified Emission Reduction).
    /// Encoded/decoded by serializers as &quot;CERE&quot;.
    /// </summary>
    [EnumMember(Value = "CERE")]
    [IsoId("_ts03kNDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type emissions allowance CER (Certified Emission Reduction).")]
    CER,
    
    /// <summary>
    /// Commodity attribute of type emissions allowance EUAA (European Union Aviation Allowance).
    /// Encoded/decoded by serializers as &quot;EUAA&quot;.
    /// </summary>
    [EnumMember(Value = "EUAA")]
    [IsoId("_tud2UNDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type emissions allowance EUAA (European Union Aviation Allowance).")]
    EUAA,
    
    /// <summary>
    /// Commodity attribute of type emissions allowance EUA (European Union Allowance).
    /// Encoded/decoded by serializers as &quot;EUAE&quot;.
    /// </summary>
    [EnumMember(Value = "EUAE")]
    [IsoId("_twP_ANDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type emissions allowance EUA (European Union Allowance).")]
    EUA,
    
    /// <summary>
    /// Commodity attribute of type emissions allowance ERU (European Reduction Unit).
    /// Encoded/decoded by serializers as &quot;ERUE&quot;.
    /// </summary>
    [EnumMember(Value = "ERUE")]
    [IsoId("_tyL4sNDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type emissions allowance ERU (European Reduction Unit).")]
    ERU,
    
    /// <summary>
    /// Commodity attribute of type GASPOOL.
    /// Encoded/decoded by serializers as &quot;GASP&quot;.
    /// </summary>
    [EnumMember(Value = "GASP")]
    [IsoId("_tz-BYNDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type GASPOOL.")]
    GasPool,
    
    /// <summary>
    /// Commodity attribute of type liquid natural gas.
    /// Encoded/decoded by serializers as &quot;LNGG&quot;.
    /// </summary>
    [EnumMember(Value = "LNGG")]
    [IsoId("_tz-BYdDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type liquid natural gas.")]
    LNG,
    
    /// <summary>
    /// Commodity attribute of type NBP (National Balancing Point).
    /// Encoded/decoded by serializers as &quot;NBPG&quot;.
    /// </summary>
    [EnumMember(Value = "NBPG")]
    [IsoId("_t1wKENDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type NBP (National Balancing Point).")]
    NBP,
    
    /// <summary>
    /// Commodity attribute of type NCG (NetConnect Germany).
    /// Encoded/decoded by serializers as &quot;NCGG&quot;.
    /// </summary>
    [EnumMember(Value = "NCGG")]
    [IsoId("_t3ZI0NDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type NCG (NetConnect Germany).")]
    NCG,
    
    /// <summary>
    /// Commodity attribute of type TTF (Dutch Title Transfer Facility).
    /// Encoded/decoded by serializers as &quot;TTFG&quot;.
    /// </summary>
    [EnumMember(Value = "TTFG")]
    [IsoId("_t5LRgNDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type TTF (Dutch Title Transfer Facility).")]
    TTF,
    
    /// <summary>
    /// Commodity attribute of type lampante.
    /// Encoded/decoded by serializers as &quot;LAMP&quot;.
    /// </summary>
    [EnumMember(Value = "LAMP")]
    [IsoId("_t6zpMNDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type lampante.")]
    Lampante,
    
    /// <summary>
    /// Commodity attribute of type NASAAC (North American Special Aluminum Alloy Contract).
    /// Encoded/decoded by serializers as &quot;NASC&quot;.
    /// </summary>
    [EnumMember(Value = "NASC")]
    [IsoId("_t8mY8NDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type NASAAC (North American Special Aluminum Alloy Contract).")]
    NASAAC,
    
    /// <summary>
    /// Commodity attribute of type molybdenum.
    /// Encoded/decoded by serializers as &quot;MOLY&quot;.
    /// </summary>
    [EnumMember(Value = "MOLY")]
    [IsoId("_t-YhoNDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type molybdenum.")]
    Molybdenum,
    
    /// <summary>
    /// Commodity attribute of type WTI (West Texas Intermediate).
    /// Encoded/decoded by serializers as &quot;WTIO&quot;.
    /// </summary>
    [EnumMember(Value = "WTIO")]
    [IsoId("_uAKqUNDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type WTI (West Texas Intermediate).")]
    WTI,
    
    /// <summary>
    /// Commodity attribute of type gold.
    /// Encoded/decoded by serializers as &quot;GOLD&quot;.
    /// </summary>
    [EnumMember(Value = "GOLD")]
    [IsoId("_uF0mYNDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type gold.")]
    Gold,
    
    /// <summary>
    /// Commodity attribute of type silver.
    /// Encoded/decoded by serializers as &quot;SLVR&quot;.
    /// </summary>
    [EnumMember(Value = "SLVR")]
    [IsoId("_uIgG8NDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type silver.")]
    Silver,
    
    /// <summary>
    /// Commodity attribute of type cocoa.
    /// Encoded/decoded by serializers as &quot;CCOA&quot;.
    /// </summary>
    [EnumMember(Value = "CCOA")]
    [IsoId("_uMXTQNDoEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type cocoa.")]
    Cocoa,
    
    /// <summary>
    /// Commodity attribute of type robusta coffee.
    /// Encoded/decoded by serializers as &quot;ROBU&quot;.
    /// </summary>
    [EnumMember(Value = "ROBU")]
    [IsoId("_PEK2wNDpEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type robusta coffee.")]
    RobustaCoffee,
    
    /// <summary>
    /// Commodity attribute of type white sugar.
    /// Encoded/decoded by serializers as &quot;WHSG&quot;.
    /// </summary>
    [EnumMember(Value = "WHSG")]
    [IsoId("_POlXANDpEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type white sugar.")]
    WhiteSugar,
    
    /// <summary>
    /// Commodity attribute of type lead.
    /// Encoded/decoded by serializers as &quot;LEAD&quot;.
    /// </summary>
    [EnumMember(Value = "LEAD")]
    [IsoId("_BpujgNDsEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type lead.")]
    Lead,
    
    /// <summary>
    ///  Commodity attribute of type iron ore.
    /// Encoded/decoded by serializers as &quot;IRON&quot;.
    /// </summary>
    [EnumMember(Value = "IRON")]
    [IsoId("_BuyCoNDsEeS8V88MH4oPOQ")]
    [Description(@" Commodity attribute of type iron ore.")]
    IronOre,
    
    /// <summary>
    /// Commodity attribute of type copper.
    /// Encoded/decoded by serializers as &quot;COPR&quot;.
    /// </summary>
    [EnumMember(Value = "COPR")]
    [IsoId("_BxKoQNDsEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type copper.")]
    Copper,
    
    /// <summary>
    /// Commodity attribute of type cobalt.
    /// Encoded/decoded by serializers as &quot;CBLT&quot;.
    /// </summary>
    [EnumMember(Value = "CBLT")]
    [IsoId("_By8w8NDsEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type cobalt.")]
    Cobalt,
    
    /// <summary>
    /// Commodity attribute of type aluminium alloy.
    /// Encoded/decoded by serializers as &quot;ALUA&quot;.
    /// </summary>
    [EnumMember(Value = "ALUA")]
    [IsoId("_B0u5oNDsEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type aluminium alloy.")]
    AluminiumAlloy,
    
    /// <summary>
    /// Commodity attribute of type aluminium.
    /// Encoded/decoded by serializers as &quot;ALUM&quot;.
    /// </summary>
    [EnumMember(Value = "ALUM")]
    [IsoId("_B2qzUNDsEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type aluminium.")]
    Aluminium,
    
    /// <summary>
    /// Commodity attribute of type bakken.
    /// Encoded/decoded by serializers as &quot;BAKK&quot;.
    /// </summary>
    [EnumMember(Value = "BAKK")]
    [IsoId("_B4mtANDsEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type bakken.")]
    Bakken,
    
    /// <summary>
    /// Commodity attribute of type biodiesel.
    /// Encoded/decoded by serializers as &quot;BDSL&quot;.
    /// </summary>
    [EnumMember(Value = "BDSL")]
    [IsoId("_B6Y1sNDsEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type biodiesel.")]
    Biodiesel,
    
    /// <summary>
    /// Commodity attribute of type Brent.
    /// Encoded/decoded by serializers as &quot;BRNT&quot;.
    /// </summary>
    [EnumMember(Value = "BRNT")]
    [IsoId("_B6Y1sdDsEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type Brent.")]
    Brent,
    
    /// <summary>
    /// Commodity attribute of type Brent NX (New Expiry).
    /// Encoded/decoded by serializers as &quot;BRNX&quot;.
    /// </summary>
    [EnumMember(Value = "BRNX")]
    [IsoId("_B8K-YNDsEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type Brent NX (New Expiry).")]
    BrentNX,
    
    /// <summary>
    /// Commodity attribute of type canadian.
    /// Encoded/decoded by serializers as &quot;CNDA&quot;.
    /// </summary>
    [EnumMember(Value = "CNDA")]
    [IsoId("_B99HENDsEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type canadian.")]
    Canadian,
    
    /// <summary>
    /// Commodity attribute of type condensate.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_X_dZ8NDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type condensate.")]
    Condensate,
    
    /// <summary>
    /// Commodity attribute of type diesel.
    /// Encoded/decoded by serializers as &quot;DSEL&quot;.
    /// </summary>
    [EnumMember(Value = "DSEL")]
    [IsoId("_YGTBwNDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type diesel.")]
    Diesel,
    
    /// <summary>
    /// Commodity attribute of type Dubai.
    /// Encoded/decoded by serializers as &quot;DUBA&quot;.
    /// </summary>
    [EnumMember(Value = "DUBA")]
    [IsoId("_YLXH8NDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type Dubai.")]
    Dubai,
    
    /// <summary>
    /// Commodity attribute of type ESPO (Eastern Siberia Pacific Ocean).
    /// Encoded/decoded by serializers as &quot;ESPO&quot;.
    /// </summary>
    [EnumMember(Value = "ESPO")]
    [IsoId("_YNTBoNDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type ESPO (Eastern Siberia Pacific Ocean).")]
    ESPO,
    
    /// <summary>
    /// Commodity attribute of type ethanol.
    /// Encoded/decoded by serializers as &quot;ETHA&quot;.
    /// </summary>
    [EnumMember(Value = "ETHA")]
    [IsoId("_YPOUQNDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type ethanol.")]
    Ethanol,
    
    /// <summary>
    /// Commodity attribute of type fuel oil.
    /// Encoded/decoded by serializers as &quot;FOIL&quot;.
    /// </summary>
    [EnumMember(Value = "FOIL")]
    [IsoId("_YRKN8NDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type fuel oil.")]
    FuelOil,
    
    /// <summary>
    /// Commodity attribute of type gasoil.
    /// Encoded/decoded by serializers as &quot;GOIL&quot;.
    /// </summary>
    [EnumMember(Value = "GOIL")]
    [IsoId("_YTGHoNDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type gasoil.")]
    Gasoil,
    
    /// <summary>
    /// Commodity attribute of type gasoline.
    /// Encoded/decoded by serializers as &quot;GSLN&quot;.
    /// </summary>
    [EnumMember(Value = "GSLN")]
    [IsoId("_YTZCkNDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type gasoline.")]
    Gasoline,
    
    /// <summary>
    /// Commodity attribute of type heating oil.
    /// Encoded/decoded by serializers as &quot;HEAT&quot;.
    /// </summary>
    [EnumMember(Value = "HEAT")]
    [IsoId("_YVCBUNDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type heating oil.")]
    HeatingOil,
    
    /// <summary>
    /// Commodity attribute of type jet fuel.
    /// Encoded/decoded by serializers as &quot;JTFL&quot;.
    /// </summary>
    [EnumMember(Value = "JTFL")]
    [IsoId("_YW97ANDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type jet fuel.")]
    JetFuel,
    
    /// <summary>
    /// Commodity attribute of type light Louisiana sweet (LLS).
    /// Encoded/decoded by serializers as &quot;LLSO&quot;.
    /// </summary>
    [EnumMember(Value = "LLSO")]
    [IsoId("_YYmSsNDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type light Louisiana sweet (LLS).")]
    LightLouisianaSweet,
    
    /// <summary>
    /// Commodity attribute of type mars.
    /// Encoded/decoded by serializers as &quot;MARS&quot;.
    /// </summary>
    [EnumMember(Value = "MARS")]
    [IsoId("_xt7jQNDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type mars.")]
    Mars,
    
    /// <summary>
    /// Commodity attribute of type naptha.
    /// Encoded/decoded by serializers as &quot;NAPH&quot;.
    /// </summary>
    [EnumMember(Value = "NAPH")]
    [IsoId("_x2tEwNDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type naptha.")]
    Naphta,
    
    /// <summary>
    /// Commodity attribute of type NGL (Natural Gas Liquids).
    /// Encoded/decoded by serializers as &quot;NGLO&quot;.
    /// </summary>
    [EnumMember(Value = "NGLO")]
    [IsoId("_x9tEoNDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type NGL (Natural Gas Liquids).")]
    NGL,
    
    /// <summary>
    /// Commodity attribute of type urals.
    /// Encoded/decoded by serializers as &quot;URAL&quot;.
    /// </summary>
    [EnumMember(Value = "URAL")]
    [IsoId("_yE1nYNDtEeS8V88MH4oPOQ")]
    [Description(@"Commodity attribute of type urals.")]
    Urals,
    
    /// <summary>
    /// Commodity attribute of type soybeans.
    /// Encoded/decoded by serializers as &quot;SOYB&quot;.
    /// </summary>
    [EnumMember(Value = "SOYB")]
    [IsoId("_2sJpUAnbEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type soybeans.")]
    Soybeans,
    
    /// <summary>
    /// Commodity attribute of type maize.
    /// Encoded/decoded by serializers as &quot;CORN&quot;.
    /// </summary>
    [EnumMember(Value = "CORN")]
    [IsoId("_8ZwsYAnbEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type maize.")]
    Maize,
    
    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_86y84AnbEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of other type.")]
    Other,
    
    /// <summary>
    /// Commodity attribute of type rapeseed.
    /// Encoded/decoded by serializers as &quot;RPSD&quot;.
    /// </summary>
    [EnumMember(Value = "RPSD")]
    [IsoId("_9C03gAnbEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type rapeseed.")]
    Rapeseed,
    
    /// <summary>
    /// Commodity attribute of type raw sugar.
    /// Encoded/decoded by serializers as &quot;BRWN&quot;.
    /// </summary>
    [EnumMember(Value = "BRWN")]
    [IsoId("_9JhVYAnbEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type raw sugar.")]
    RawSugar,
    
    /// <summary>
    /// Commodity attribute of type potatoes.
    /// Encoded/decoded by serializers as &quot;POTA&quot;.
    /// </summary>
    [EnumMember(Value = "POTA")]
    [IsoId("_HprhcAncEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type potatoes.")]
    Potatoes,
    
    /// <summary>
    /// Commodity attribute of type rice.
    /// Encoded/decoded by serializers as &quot;RICE&quot;.
    /// </summary>
    [EnumMember(Value = "RICE")]
    [IsoId("_Ln7fsAncEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type rice.")]
    Rice,
    
    /// <summary>
    /// Commodity attribute of type milled wheat.
    /// Encoded/decoded by serializers as &quot;MWHT&quot;.
    /// </summary>
    [EnumMember(Value = "MWHT")]
    [IsoId("_T8PfQAncEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type milled wheat.")]
    MillingWheat,
    
    /// <summary>
    /// Commodity attribute of type fuel.
    /// Encoded/decoded by serializers as &quot;FUEL&quot;.
    /// </summary>
    [EnumMember(Value = "FUEL")]
    [IsoId("_gUdZIAncEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type fuel.")]
    Fuel,
    
    /// <summary>
    /// Commodity attribute of type kerosene.
    /// Encoded/decoded by serializers as &quot;KERO&quot;.
    /// </summary>
    [EnumMember(Value = "KERO")]
    [IsoId("_maimkAncEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type kerosene.")]
    Kerosene,
    
    /// <summary>
    /// Commodity attribute of type tapis.
    /// Encoded/decoded by serializers as &quot;TAPI&quot;.
    /// </summary>
    [EnumMember(Value = "TAPI")]
    [IsoId("_sneC4AncEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type tapis.")]
    Tapis,
    
    /// <summary>
    /// Commodity attribute of type platinum.
    /// Encoded/decoded by serializers as &quot;PTNM&quot;.
    /// </summary>
    [EnumMember(Value = "PTNM")]
    [IsoId("_KXLNAAndEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type platinum.")]
    Platinum,
    
    /// <summary>
    /// Commodity attribute of type palladium.
    /// Encoded/decoded by serializers as &quot;PLDM&quot;.
    /// </summary>
    [EnumMember(Value = "PLDM")]
    [IsoId("_K8NzwAndEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type palladium.")]
    Palladium,
    
    /// <summary>
    /// Commodity attribute of type dry bulk carrier.
    /// Encoded/decoded by serializers as &quot;DBCR&quot;.
    /// </summary>
    [EnumMember(Value = "DBCR")]
    [IsoId("_kWfJAA2eEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type dry bulk carrier.")]
    DryBulkCarrier,
    
    /// <summary>
    /// Commodity attribute of type tanker.
    /// Encoded/decoded by serializers as &quot;TNKR&quot;.
    /// </summary>
    [EnumMember(Value = "TNKR")]
    [IsoId("_oVCpQA2eEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type tanker.")]
    Tanker,
    
    /// <summary>
    /// Commodity attribute of type containership.
    /// Encoded/decoded by serializers as &quot;CSHP&quot;.
    /// </summary>
    [EnumMember(Value = "CSHP")]
    [IsoId("_o_JWMA2eEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type containership.")]
    Containership,
    
    /// <summary>
    /// Commodity attribute of type off-peak.
    /// Encoded/decoded by serializers as &quot;OFFP&quot;.
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_MwDFUGs3EeW9oI9ZdgWHPQ")]
    [Description(@"Commodity attribute of type off-peak.")]
    OffPeak,
    
}
