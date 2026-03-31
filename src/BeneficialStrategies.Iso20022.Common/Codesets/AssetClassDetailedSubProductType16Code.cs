// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Sub product code list for commodity derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_StIuQBYHEeejf-cbr8l5qw")]
[Description(@"Sub product code list for commodity derivatives.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassDetailedSubProductType16Code>))]
#endif
public enum AssetClassDetailedSubProductType16Code
{
    /// <summary>
    /// Commodity attribute of type foreign exchange cross rate.
    /// Encoded/decoded by serializers as &quot;FXCR&quot;.
    /// </summary>
    [EnumMember(Value = "FXCR")]
    [IsoId("_VL4ooRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type foreign exchange cross rate.")]
    ForeignExchangeCrossRate = AssetClassDetailedSubProductTypeCode.ForeignExchangeCrossRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type foreign exchange emerging markets.
    /// Encoded/decoded by serializers as &quot;FXEM&quot;.
    /// </summary>
    [EnumMember(Value = "FXEM")]
    [IsoId("_VRF4wRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type foreign exchange emerging markets.")]
    ForeignExchangeEmergingMarket =
        AssetClassDetailedSubProductTypeCode.ForeignExchangeEmergingMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type foreign exchange majors.
    /// Encoded/decoded by serializers as &quot;FXMJ&quot;.
    /// </summary>
    [EnumMember(Value = "FXMJ")]
    [IsoId("_VWJX4RYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type foreign exchange majors.")]
    ForeignExchangeMajor = AssetClassDetailedSubProductTypeCode.ForeignExchangeMajor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type fuel.
    /// Encoded/decoded by serializers as &quot;FUEL&quot;.
    /// </summary>
    [EnumMember(Value = "FUEL")]
    [IsoId("_VfhWURYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type fuel.")]
    Fuel = AssetClassDetailedSubProductTypeCode.Fuel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type fuel oil.
    /// Encoded/decoded by serializers as &quot;FOIL&quot;.
    /// </summary>
    [EnumMember(Value = "FOIL")]
    [IsoId("_VlLSYRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type fuel oil.")]
    FuelOil = AssetClassDetailedSubProductTypeCode.FuelOil, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type gasoil.
    /// Encoded/decoded by serializers as &quot;GOIL&quot;.
    /// </summary>
    [EnumMember(Value = "GOIL")]
    [IsoId("_VujQ0RYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type gasoil.")]
    Gasoil = AssetClassDetailedSubProductTypeCode.Gasoil, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type gasoline.
    /// Encoded/decoded by serializers as &quot;GSLN&quot;.
    /// </summary>
    [EnumMember(Value = "GSLN")]
    [IsoId("_V1Y4oRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type gasoline.")]
    Gasoline = AssetClassDetailedSubProductTypeCode.Gasoline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type GASPOOL.
    /// Encoded/decoded by serializers as &quot;GASP&quot;.
    /// </summary>
    [EnumMember(Value = "GASP")]
    [IsoId("_V-BQMRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type GASPOOL.")]
    GasPool = AssetClassDetailedSubProductTypeCode.GasPool, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type heating oil.
    /// Encoded/decoded by serializers as &quot;HEAT&quot;.
    /// </summary>
    [EnumMember(Value = "HEAT")]
    [IsoId("_WKEvMRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type heating oil.")]
    HeatingOil = AssetClassDetailedSubProductTypeCode.HeatingOil, // same ordinal as derivation source for type conversions

    /// <summary>
    ///  Commodity attribute of type iron ore.
    /// Encoded/decoded by serializers as &quot;IRON&quot;.
    /// </summary>
    [EnumMember(Value = "IRON")]
    [IsoId("_WSGp0RYHEeejf-cbr8l5qw")]
    [Description(@" Commodity attribute of type iron ore.")]
    IronOre = AssetClassDetailedSubProductTypeCode.IronOre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type jet fuel.
    /// Encoded/decoded by serializers as &quot;JTFL&quot;.
    /// </summary>
    [EnumMember(Value = "JTFL")]
    [IsoId("_WYNR0RYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type jet fuel.")]
    JetFuel = AssetClassDetailedSubProductTypeCode.JetFuel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type kerosene.
    /// Encoded/decoded by serializers as &quot;KERO&quot;.
    /// </summary>
    [EnumMember(Value = "KERO")]
    [IsoId("_WlcckRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type kerosene.")]
    Kerosene = AssetClassDetailedSubProductTypeCode.Kerosene, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type lampante.
    /// Encoded/decoded by serializers as &quot;LAMP&quot;.
    /// </summary>
    [EnumMember(Value = "LAMP")]
    [IsoId("_WrsOgRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type lampante.")]
    Lampante = AssetClassDetailedSubProductTypeCode.Lampante, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type lead.
    /// Encoded/decoded by serializers as &quot;LEAD&quot;.
    /// </summary>
    [EnumMember(Value = "LEAD")]
    [IsoId("_WzITQRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type lead.")]
    Lead = AssetClassDetailedSubProductTypeCode.Lead, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type light Louisiana sweet (LLS).
    /// Encoded/decoded by serializers as &quot;LLSO&quot;.
    /// </summary>
    [EnumMember(Value = "LLSO")]
    [IsoId("_W7K08RYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type light Louisiana sweet (LLS).")]
    LightLouisianaSweet = AssetClassDetailedSubProductTypeCode.LightLouisianaSweet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type liquid natural gas.
    /// Encoded/decoded by serializers as &quot;LNGG&quot;.
    /// </summary>
    [EnumMember(Value = "LNGG")]
    [IsoId("_XCAcwRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type liquid natural gas.")]
    LNG = AssetClassDetailedSubProductTypeCode.LNG, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type maize.
    /// Encoded/decoded by serializers as &quot;CORN&quot;.
    /// </summary>
    [EnumMember(Value = "CORN")]
    [IsoId("_XIZ_sRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type maize.")]
    Maize = AssetClassDetailedSubProductTypeCode.Maize, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type mars.
    /// Encoded/decoded by serializers as &quot;MARS&quot;.
    /// </summary>
    [EnumMember(Value = "MARS")]
    [IsoId("_XNnP0RYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type mars.")]
    Mars = AssetClassDetailedSubProductTypeCode.Mars, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type milled wheat.
    /// Encoded/decoded by serializers as &quot;MWHT&quot;.
    /// </summary>
    [EnumMember(Value = "MWHT")]
    [IsoId("_XXSJMRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type milled wheat.")]
    MillingWheat = AssetClassDetailedSubProductTypeCode.MillingWheat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type molybdenum.
    /// Encoded/decoded by serializers as &quot;MOLY&quot;.
    /// </summary>
    [EnumMember(Value = "MOLY")]
    [IsoId("_XhGzkRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type molybdenum.")]
    Molybdenum = AssetClassDetailedSubProductTypeCode.Molybdenum, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type naptha.
    /// Encoded/decoded by serializers as &quot;NAPH&quot;.
    /// </summary>
    [EnumMember(Value = "NAPH")]
    [IsoId("_XxxFwRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type naptha.")]
    Naphta = AssetClassDetailedSubProductTypeCode.Naphta, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type NBP (National Balancing Point).
    /// Encoded/decoded by serializers as &quot;NBPG&quot;.
    /// </summary>
    [EnumMember(Value = "NBPG")]
    [IsoId("_X4nUoRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type NBP (National Balancing Point).")]
    NBP = AssetClassDetailedSubProductTypeCode.NBP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type NASAAC (North American Special Aluminum Alloy Contract).
    /// Encoded/decoded by serializers as &quot;NASC&quot;.
    /// </summary>
    [EnumMember(Value = "NASC")]
    [IsoId("_YCIdARYHEeejf-cbr8l5qw")]
    [Description(
        @"Commodity attribute of type NASAAC (North American Special Aluminum Alloy Contract)."
    )]
    NASAAC = AssetClassDetailedSubProductTypeCode.NASAAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type NCG (NetConnect Germany).
    /// Encoded/decoded by serializers as &quot;NCGG&quot;.
    /// </summary>
    [EnumMember(Value = "NCGG")]
    [IsoId("_YOxx4RYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type NCG (NetConnect Germany).")]
    NCG = AssetClassDetailedSubProductTypeCode.NCG, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type NGL (Natural Gas Liquids).
    /// Encoded/decoded by serializers as &quot;NGLO&quot;.
    /// </summary>
    [EnumMember(Value = "NGLO")]
    [IsoId("_YUR88RYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type NGL (Natural Gas Liquids).")]
    NGL = AssetClassDetailedSubProductTypeCode.NGL, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type nickel.
    /// Encoded/decoded by serializers as &quot;NICK&quot;.
    /// </summary>
    [EnumMember(Value = "NICK")]
    [IsoId("_YeGnURYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type nickel.")]
    Nickel = AssetClassDetailedSubProductTypeCode.Nickel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type off-peak.
    /// Encoded/decoded by serializers as &quot;OFFP&quot;.
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_YoOMoRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type off-peak.")]
    OffPeak = AssetClassDetailedSubProductTypeCode.OffPeak, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type aluminium.
    /// Encoded/decoded by serializers as &quot;ALUM&quot;.
    /// </summary>
    [EnumMember(Value = "ALUM")]
    [IsoId("_ZUjuMRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type aluminium.")]
    Aluminium = AssetClassDetailedSubProductTypeCode.Aluminium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type aluminium alloy.
    /// Encoded/decoded by serializers as &quot;ALUA&quot;.
    /// </summary>
    [EnumMember(Value = "ALUA")]
    [IsoId("_ZZdcURYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type aluminium alloy.")]
    AluminiumAlloy = AssetClassDetailedSubProductTypeCode.AluminiumAlloy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type bakken.
    /// Encoded/decoded by serializers as &quot;BAKK&quot;.
    /// </summary>
    [EnumMember(Value = "BAKK")]
    [IsoId("_ZjIVsRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type bakken.")]
    Bakken = AssetClassDetailedSubProductTypeCode.Bakken, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type base load.
    /// Encoded/decoded by serializers as &quot;BSLD&quot;.
    /// </summary>
    [EnumMember(Value = "BSLD")]
    [IsoId("_Zq38cRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type base load.")]
    BaseLoad = AssetClassDetailedSubProductTypeCode.BaseLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type biodiesel.
    /// Encoded/decoded by serializers as &quot;BDSL&quot;.
    /// </summary>
    [EnumMember(Value = "BDSL")]
    [IsoId("_ZxtkQRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type biodiesel.")]
    Biodiesel = AssetClassDetailedSubProductTypeCode.Biodiesel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type Brent.
    /// Encoded/decoded by serializers as &quot;BRNT&quot;.
    /// </summary>
    [EnumMember(Value = "BRNT")]
    [IsoId("_Z42uERYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type Brent.")]
    Brent = AssetClassDetailedSubProductTypeCode.Brent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type Brent NX (New Expiry).
    /// Encoded/decoded by serializers as &quot;BRNX&quot;.
    /// </summary>
    [EnumMember(Value = "BRNX")]
    [IsoId("_aBVUoRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type Brent NX (New Expiry).")]
    BrentNX = AssetClassDetailedSubProductTypeCode.BrentNX, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type canadian.
    /// Encoded/decoded by serializers as &quot;CNDA&quot;.
    /// </summary>
    [EnumMember(Value = "CNDA")]
    [IsoId("_aHb8oRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type canadian.")]
    Canadian = AssetClassDetailedSubProductTypeCode.Canadian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type emissions allowance CER (Certified Emission Reduction).
    /// Encoded/decoded by serializers as &quot;CERE&quot;.
    /// </summary>
    [EnumMember(Value = "CERE")]
    [IsoId("_aSAN4RYHEeejf-cbr8l5qw")]
    [Description(
        @"Commodity attribute of type emissions allowance CER (Certified Emission Reduction)."
    )]
    CER = AssetClassDetailedSubProductTypeCode.CER, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type cobalt.
    /// Encoded/decoded by serializers as &quot;CBLT&quot;.
    /// </summary>
    [EnumMember(Value = "CBLT")]
    [IsoId("_abObURYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type cobalt.")]
    Cobalt = AssetClassDetailedSubProductTypeCode.Cobalt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type cocoa.
    /// Encoded/decoded by serializers as &quot;CCOA&quot;.
    /// </summary>
    [EnumMember(Value = "CCOA")]
    [IsoId("_am1OYRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type cocoa.")]
    Cocoa = AssetClassDetailedSubProductTypeCode.Cocoa, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type condensate.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_atq2MRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type condensate.")]
    Condensate = AssetClassDetailedSubProductTypeCode.Condensate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type containership.
    /// Encoded/decoded by serializers as &quot;CSHP&quot;.
    /// </summary>
    [EnumMember(Value = "CSHP")]
    [IsoId("_a00AARYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type containership.")]
    Containership = AssetClassDetailedSubProductTypeCode.Containership, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type copper.
    /// Encoded/decoded by serializers as &quot;COPR&quot;.
    /// </summary>
    [EnumMember(Value = "COPR")]
    [IsoId("_bDiYgRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type copper.")]
    Copper = AssetClassDetailedSubProductTypeCode.Copper, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type diesel.
    /// Encoded/decoded by serializers as &quot;DSEL&quot;.
    /// </summary>
    [EnumMember(Value = "DSEL")]
    [IsoId("_bPJLkRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type diesel.")]
    Diesel = AssetClassDetailedSubProductTypeCode.Diesel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type dry bulk carrier.
    /// Encoded/decoded by serializers as &quot;DBCR&quot;.
    /// </summary>
    [EnumMember(Value = "DBCR")]
    [IsoId("_bUWbsRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type dry bulk carrier.")]
    DryBulkCarrier = AssetClassDetailedSubProductTypeCode.DryBulkCarrier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type Dubai.
    /// Encoded/decoded by serializers as &quot;DUBA&quot;.
    /// </summary>
    [EnumMember(Value = "DUBA")]
    [IsoId("_bbV0gRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type Dubai.")]
    Dubai = AssetClassDetailedSubProductTypeCode.Dubai, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type emissions allowance ERU (European Reduction Unit).
    /// Encoded/decoded by serializers as &quot;ERUE&quot;.
    /// </summary>
    [EnumMember(Value = "ERUE")]
    [IsoId("_bhvXcRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type emissions allowance ERU (European Reduction Unit).")]
    ERU = AssetClassDetailedSubProductTypeCode.ERU, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type ESPO (Eastern Siberia Pacific Ocean).
    /// Encoded/decoded by serializers as &quot;ESPO&quot;.
    /// </summary>
    [EnumMember(Value = "ESPO")]
    [IsoId("_bolmURYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type ESPO (Eastern Siberia Pacific Ocean).")]
    ESPO = AssetClassDetailedSubProductTypeCode.ESPO, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type ethanol.
    /// Encoded/decoded by serializers as &quot;ETHA&quot;.
    /// </summary>
    [EnumMember(Value = "ETHA")]
    [IsoId("_bvk_IRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type ethanol.")]
    Ethanol = AssetClassDetailedSubProductTypeCode.Ethanol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type emissions allowance EUA (European Union Allowance).
    /// Encoded/decoded by serializers as &quot;EUAE&quot;.
    /// </summary>
    [EnumMember(Value = "EUAE")]
    [IsoId("_b3T-0RYHEeejf-cbr8l5qw")]
    [Description(
        @"Commodity attribute of type emissions allowance EUA (European Union Allowance)."
    )]
    EUA = AssetClassDetailedSubProductTypeCode.EUA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type emissions allowance EUAA (European Union Aviation Allowance).
    /// Encoded/decoded by serializers as &quot;EUAA&quot;.
    /// </summary>
    [EnumMember(Value = "EUAA")]
    [IsoId("_b-TXoRYHEeejf-cbr8l5qw")]
    [Description(
        @"Commodity attribute of type emissions allowance EUAA (European Union Aviation Allowance)."
    )]
    EUAA = AssetClassDetailedSubProductTypeCode.EUAA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type feed wheat.
    /// Encoded/decoded by serializers as &quot;FWHT&quot;.
    /// </summary>
    [EnumMember(Value = "FWHT")]
    [IsoId("_cHOqIRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type feed wheat.")]
    FeedWheat = AssetClassDetailedSubProductTypeCode.FeedWheat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type financial transmission rights.
    /// Encoded/decoded by serializers as &quot;FITR&quot;.
    /// </summary>
    [EnumMember(Value = "FITR")]
    [IsoId("_cPHa0RYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type financial transmission rights.")]
    FinancialTransmissionRights = AssetClassDetailedSubProductTypeCode.FinancialTransmissionRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_drWvURYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type palladium.
    /// Encoded/decoded by serializers as &quot;PLDM&quot;.
    /// </summary>
    [EnumMember(Value = "PLDM")]
    [IsoId("_dwtwcRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type palladium.")]
    Palladium = AssetClassDetailedSubProductTypeCode.Palladium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type peak load.
    /// Encoded/decoded by serializers as &quot;PKLD&quot;.
    /// </summary>
    [EnumMember(Value = "PKLD")]
    [IsoId("_d17AkRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type peak load.")]
    PeakLoad = AssetClassDetailedSubProductTypeCode.PeakLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type platinum.
    /// Encoded/decoded by serializers as &quot;PTNM&quot;.
    /// </summary>
    [EnumMember(Value = "PTNM")]
    [IsoId("_d8BokRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type platinum.")]
    Platinum = AssetClassDetailedSubProductTypeCode.Platinum, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type potatoes.
    /// Encoded/decoded by serializers as &quot;POTA&quot;.
    /// </summary>
    [EnumMember(Value = "POTA")]
    [IsoId("_eDT8URYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type potatoes.")]
    Potatoes = AssetClassDetailedSubProductTypeCode.Potatoes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type rapeseed.
    /// Encoded/decoded by serializers as &quot;RPSD&quot;.
    /// </summary>
    [EnumMember(Value = "RPSD")]
    [IsoId("_eKAaMRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type rapeseed.")]
    Rapeseed = AssetClassDetailedSubProductTypeCode.Rapeseed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type raw sugar.
    /// Encoded/decoded by serializers as &quot;BRWN&quot;.
    /// </summary>
    [EnumMember(Value = "BRWN")]
    [IsoId("_eQjHERYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type raw sugar.")]
    RawSugar = AssetClassDetailedSubProductTypeCode.RawSugar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type rice.
    /// Encoded/decoded by serializers as &quot;RICE&quot;.
    /// </summary>
    [EnumMember(Value = "RICE")]
    [IsoId("_eWW0IRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type rice.")]
    Rice = AssetClassDetailedSubProductTypeCode.Rice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type robusta coffee.
    /// Encoded/decoded by serializers as &quot;ROBU&quot;.
    /// </summary>
    [EnumMember(Value = "ROBU")]
    [IsoId("_edDSARYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type robusta coffee.")]
    RobustaCoffee = AssetClassDetailedSubProductTypeCode.RobustaCoffee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type silver.
    /// Encoded/decoded by serializers as &quot;SLVR&quot;.
    /// </summary>
    [EnumMember(Value = "SLVR")]
    [IsoId("_ejTD8RYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type silver.")]
    Silver = AssetClassDetailedSubProductTypeCode.Silver, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type soybeans.
    /// Encoded/decoded by serializers as &quot;SOYB&quot;.
    /// </summary>
    [EnumMember(Value = "SOYB")]
    [IsoId("_eudLERYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type soybeans.")]
    Soybeans = AssetClassDetailedSubProductTypeCode.Soybeans, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type steel.
    /// Encoded/decoded by serializers as &quot;STEL&quot;.
    /// </summary>
    [EnumMember(Value = "STEL")]
    [IsoId("_ezqbMRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type steel.")]
    Steel = AssetClassDetailedSubProductTypeCode.Steel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type tanker.
    /// Encoded/decoded by serializers as &quot;TNKR&quot;.
    /// </summary>
    [EnumMember(Value = "TNKR")]
    [IsoId("_fBNH8RYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type tanker.")]
    Tanker = AssetClassDetailedSubProductTypeCode.Tanker, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type tapis.
    /// Encoded/decoded by serializers as &quot;TAPI&quot;.
    /// </summary>
    [EnumMember(Value = "TAPI")]
    [IsoId("_fICvwRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type tapis.")]
    Tapis = AssetClassDetailedSubProductTypeCode.Tapis, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type tin.
    /// Encoded/decoded by serializers as &quot;TINN&quot;.
    /// </summary>
    [EnumMember(Value = "TINN")]
    [IsoId("_fOJXwRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type tin.")]
    Tin = AssetClassDetailedSubProductTypeCode.Tin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type TTF (Dutch Title Transfer Facility).
    /// Encoded/decoded by serializers as &quot;TTFG&quot;.
    /// </summary>
    [EnumMember(Value = "TTFG")]
    [IsoId("_fYtpARYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type TTF (Dutch Title Transfer Facility).")]
    TTF = AssetClassDetailedSubProductTypeCode.TTF, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type urals.
    /// Encoded/decoded by serializers as &quot;URAL&quot;.
    /// </summary>
    [EnumMember(Value = "URAL")]
    [IsoId("_ff_8wRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type urals.")]
    Urals = AssetClassDetailedSubProductTypeCode.Urals, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type white sugar.
    /// Encoded/decoded by serializers as &quot;WHSG&quot;.
    /// </summary>
    [EnumMember(Value = "WHSG")]
    [IsoId("_fl8zwRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type white sugar.")]
    WhiteSugar = AssetClassDetailedSubProductTypeCode.WhiteSugar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type WTI (West Texas Intermediate).
    /// Encoded/decoded by serializers as &quot;WTIO&quot;.
    /// </summary>
    [EnumMember(Value = "WTIO")]
    [IsoId("_fxswwRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type WTI (West Texas Intermediate).")]
    WTI = AssetClassDetailedSubProductTypeCode.WTI, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type zinc.
    /// Encoded/decoded by serializers as &quot;ZINC&quot;.
    /// </summary>
    [EnumMember(Value = "ZINC")]
    [IsoId("_f5lhcRYHEeejf-cbr8l5qw")]
    [Description(@"Commodity attribute of type zinc.")]
    Zinc = AssetClassDetailedSubProductTypeCode.Zinc, // same ordinal as derivation source for type conversions
}
