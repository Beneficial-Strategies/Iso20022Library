// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Oil.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__BXQMA2eEeW72qLtWESimw")]
[Description(@"Further sub product code list for commodity derivative Oil.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassDetailedSubProductType7Code>))]
#endif
public enum AssetClassDetailedSubProductType7Code
{
    /// <summary>
    /// Commodity attribute of type bakken.
    /// Encoded/decoded by serializers as &quot;BAKK&quot;.
    /// </summary>
    [EnumMember(Value = "BAKK")]
    [IsoId("_8MTcsQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type bakken.")]
    Bakken = AssetClassDetailedSubProductTypeCode.Bakken, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type biodiesel.
    /// Encoded/decoded by serializers as &quot;BDSL&quot;.
    /// </summary>
    [EnumMember(Value = "BDSL")]
    [IsoId("_8ZincQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type biodiesel.")]
    Biodiesel = AssetClassDetailedSubProductTypeCode.Biodiesel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type Brent.
    /// Encoded/decoded by serializers as &quot;BRNT&quot;.
    /// </summary>
    [EnumMember(Value = "BRNT")]
    [IsoId("_8otr4Q2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type Brent.")]
    Brent = AssetClassDetailedSubProductTypeCode.Brent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type Brent NX (New Expiry).
    /// Encoded/decoded by serializers as &quot;BRNX&quot;.
    /// </summary>
    [EnumMember(Value = "BRNX")]
    [IsoId("_-JapoQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type Brent NX (New Expiry).")]
    BrentNX = AssetClassDetailedSubProductTypeCode.BrentNX, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type canadian.
    /// Encoded/decoded by serializers as &quot;CNDA&quot;.
    /// </summary>
    [EnumMember(Value = "CNDA")]
    [IsoId("_-kgDIQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type canadian.")]
    Canadian = AssetClassDetailedSubProductTypeCode.Canadian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type condensate.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_-x4-4Q2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type condensate.")]
    Condensate = AssetClassDetailedSubProductTypeCode.Condensate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type diesel.
    /// Encoded/decoded by serializers as &quot;DSEL&quot;.
    /// </summary>
    [EnumMember(Value = "DSEL")]
    [IsoId("__RIfoQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type diesel.")]
    Diesel = AssetClassDetailedSubProductTypeCode.Diesel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type Dubai.
    /// Encoded/decoded by serializers as &quot;DUBA&quot;.
    /// </summary>
    [EnumMember(Value = "DUBA")]
    [IsoId("_ARskwQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type Dubai.")]
    Dubai = AssetClassDetailedSubProductTypeCode.Dubai, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type ESPO (Eastern Siberia Pacific Ocean).
    /// Encoded/decoded by serializers as &quot;ESPO&quot;.
    /// </summary>
    [EnumMember(Value = "ESPO")]
    [IsoId("_Af-4YQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type ESPO (Eastern Siberia Pacific Ocean).")]
    ESPO = AssetClassDetailedSubProductTypeCode.ESPO, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type ethanol.
    /// Encoded/decoded by serializers as &quot;ETHA&quot;.
    /// </summary>
    [EnumMember(Value = "ETHA")]
    [IsoId("_CXAEYQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type ethanol.")]
    Ethanol = AssetClassDetailedSubProductTypeCode.Ethanol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type fuel.
    /// Encoded/decoded by serializers as &quot;FUEL&quot;.
    /// </summary>
    [EnumMember(Value = "FUEL")]
    [IsoId("_DtSh4Q2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type fuel.")]
    Fuel = AssetClassDetailedSubProductTypeCode.Fuel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type fuel oil.
    /// Encoded/decoded by serializers as &quot;FOIL&quot;.
    /// </summary>
    [EnumMember(Value = "FOIL")]
    [IsoId("_Em3OMQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type fuel oil.")]
    FuelOil = AssetClassDetailedSubProductTypeCode.FuelOil, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type gasoil.
    /// Encoded/decoded by serializers as &quot;GOIL&quot;.
    /// </summary>
    [EnumMember(Value = "GOIL")]
    [IsoId("_E6WK4Q2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type gasoil.")]
    Gasoil = AssetClassDetailedSubProductTypeCode.Gasoil, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type gasoline.
    /// Encoded/decoded by serializers as &quot;GSLN&quot;.
    /// </summary>
    [EnumMember(Value = "GSLN")]
    [IsoId("_FHcLsQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type gasoline.")]
    Gasoline = AssetClassDetailedSubProductTypeCode.Gasoline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type heating oil.
    /// Encoded/decoded by serializers as &quot;HEAT&quot;.
    /// </summary>
    [EnumMember(Value = "HEAT")]
    [IsoId("_Fx_kkQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type heating oil.")]
    HeatingOil = AssetClassDetailedSubProductTypeCode.HeatingOil, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type jet fuel.
    /// Encoded/decoded by serializers as &quot;JTFL&quot;.
    /// </summary>
    [EnumMember(Value = "JTFL")]
    [IsoId("_GadSwQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type jet fuel.")]
    JetFuel = AssetClassDetailedSubProductTypeCode.JetFuel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type kerosene.
    /// Encoded/decoded by serializers as &quot;KERO&quot;.
    /// </summary>
    [EnumMember(Value = "KERO")]
    [IsoId("_HmoK8Q2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type kerosene.")]
    Kerosene = AssetClassDetailedSubProductTypeCode.Kerosene, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type light Louisiana sweet (LLS).
    /// Encoded/decoded by serializers as &quot;LLSO&quot;.
    /// </summary>
    [EnumMember(Value = "LLSO")]
    [IsoId("_ILrYwQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type light Louisiana sweet (LLS).")]
    LightLouisianaSweet = AssetClassDetailedSubProductTypeCode.LightLouisianaSweet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type mars.
    /// Encoded/decoded by serializers as &quot;MARS&quot;.
    /// </summary>
    [EnumMember(Value = "MARS")]
    [IsoId("_IsQWQQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type mars.")]
    Mars = AssetClassDetailedSubProductTypeCode.Mars, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type naptha.
    /// Encoded/decoded by serializers as &quot;NAPH&quot;.
    /// </summary>
    [EnumMember(Value = "NAPH")]
    [IsoId("_JQHRQQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type naptha.")]
    Naphta = AssetClassDetailedSubProductTypeCode.Naphta, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type NGL (Natural Gas Liquids).
    /// Encoded/decoded by serializers as &quot;NGLO&quot;.
    /// </summary>
    [EnumMember(Value = "NGLO")]
    [IsoId("_KQ1HYQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type NGL (Natural Gas Liquids).")]
    NGL = AssetClassDetailedSubProductTypeCode.NGL, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type tapis.
    /// Encoded/decoded by serializers as &quot;TAPI&quot;.
    /// </summary>
    [EnumMember(Value = "TAPI")]
    [IsoId("_LYPbYQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type tapis.")]
    Tapis = AssetClassDetailedSubProductTypeCode.Tapis, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type WTI (West Texas Intermediate).
    /// Encoded/decoded by serializers as &quot;WTIO&quot;.
    /// </summary>
    [EnumMember(Value = "WTIO")]
    [IsoId("_MSjukQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type WTI (West Texas Intermediate).")]
    WTI = AssetClassDetailedSubProductTypeCode.WTI, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type urals.
    /// Encoded/decoded by serializers as &quot;URAL&quot;.
    /// </summary>
    [EnumMember(Value = "URAL")]
    [IsoId("_MkaTkQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type urals.")]
    Urals = AssetClassDetailedSubProductTypeCode.Urals, // same ordinal as derivation source for type conversions
}
