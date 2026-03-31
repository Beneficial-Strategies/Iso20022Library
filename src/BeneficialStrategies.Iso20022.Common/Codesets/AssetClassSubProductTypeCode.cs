// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product types for specific asset classes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KADecc49EeSc85GUbgBycw")]
[Description(@"Defines the sub-product types for specific asset classes.")]
[Derivations(
    typeof(AssetClassSubProductType10Code),
    typeof(AssetClassSubProductType3Code),
    typeof(AssetClassSubProductType39Code),
    typeof(AssetClassSubProductType29Code),
    typeof(AssetClassSubProductType35Code),
    typeof(AssetClassSubProductType7Code),
    typeof(AssetClassSubProductType6Code),
    typeof(AssetClassSubProductType43Code),
    typeof(AssetClassSubProductType28Code),
    typeof(AssetClassSubProductEnergyType1Code),
    typeof(AssetClassSubProductType21Code),
    typeof(AssetClassSubProductType41Code),
    typeof(AssetClassSubProductType45Code),
    typeof(AssetClassSubProductType25Code),
    typeof(AssetClassSubProductType33Code),
    typeof(AssetClassSubProductType1Code),
    typeof(AssetClassSubProductType2Code),
    typeof(AssetClassSubProductType36Code),
    typeof(AssetClassSubProductType37Code),
    typeof(AssetClassSubProductType18Code),
    typeof(AssetClassSubProductFreight1Code),
    typeof(AssetClassSubProductType15Code),
    typeof(AssetClassSubProductType34Code),
    typeof(AssetClassSubProductType44Code),
    typeof(AssetClassSubProductType32Code),
    typeof(AssetClassSubProductType30Code),
    typeof(AssetClassSubProductType22Code),
    typeof(AssetClassSubProductType38Code),
    typeof(AssetClassSubProductType8Code),
    typeof(AssetClassSubProductMetal1Code),
    typeof(AssetClassSubProductType24Code),
    typeof(AssetClassSubProductType26Code),
    typeof(AssetClassSubProductType42Code),
    typeof(AssetClassSubProductType19Code),
    typeof(AssetClassSubProductAgriculturalType1Code),
    typeof(AssetClassSubProductType23Code),
    typeof(AssetClassSubProductType47Code),
    typeof(AssetClassSubProductType20Code),
    typeof(AssetClassSubProductEnvironmentalType1Code),
    typeof(AssetClassSubProductType40Code),
    typeof(AssetClassSubProductType5Code),
    typeof(AssetClassSubProductType48Code),
    typeof(AssetClassSubProductType49Code),
    typeof(AssetClassSubProductType46Code),
    typeof(AssetClassSubProductType16Code),
    typeof(AssetClassSubProductType27Code),
    typeof(AssetClassSubProductType31Code)
)]
public enum AssetClassSubProductTypeCode
{
    /// <summary>
    /// Commodity of type dairy.
    /// Encoded/decoded by serializers as &quot;DIRY&quot;.
    /// </summary>
    [EnumMember(Value = "DIRY")]
    [IsoId("_SMFEsM49EeSc85GUbgBycw")]
    [Description(@"Commodity of type dairy.")]
    Dairy,

    /// <summary>
    /// Commodity of type forestry.
    /// Encoded/decoded by serializers as &quot;FRST&quot;.
    /// </summary>
    [EnumMember(Value = "FRST")]
    [IsoId("_SjZYgM49EeSc85GUbgBycw")]
    [Description(@"Commodity of type forestry.")]
    Forestry,

    /// <summary>
    /// Commodity of type grain oil seeds.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_SoALsM49EeSc85GUbgBycw")]
    [Description(@"Commodity of type grain oil seeds.")]
    GrainOilSeeds,

    /// <summary>
    /// Commodity of type livestock.
    /// Encoded/decoded by serializers as &quot;LSTK&quot;.
    /// </summary>
    [EnumMember(Value = "LSTK")]
    [IsoId("_StDDwM49EeSc85GUbgBycw")]
    [Description(@"Commodity of type livestock.")]
    Livestock,

    /// <summary>
    /// Commodity of type olive oil.
    /// Encoded/decoded by serializers as &quot;OOLI&quot;.
    /// </summary>
    [EnumMember(Value = "OOLI")]
    [IsoId("_SyZd0M49EeSc85GUbgBycw")]
    [Description(@"Commodity of type olive oil.")]
    OliveOil,

    /// <summary>
    /// Commodity of type softs.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_S5XogM49EeSc85GUbgBycw")]
    [Description(@"Commodity of type softs.")]
    Softs,

    /// <summary>
    /// Commodity of type coal.
    /// Encoded/decoded by serializers as &quot;COAL&quot;.
    /// </summary>
    [EnumMember(Value = "COAL")]
    [IsoId("_TAgLQM49EeSc85GUbgBycw")]
    [Description(@"Commodity of type coal.")]
    Coal,

    /// <summary>
    /// Commodity of type electricity.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_TF_vQM49EeSc85GUbgBycw")]
    [Description(@"Commodity of type electricity.")]
    Electricity,

    /// <summary>
    /// Commodity of type inter energy.
    /// Encoded/decoded by serializers as &quot;INRG&quot;.
    /// </summary>
    [EnumMember(Value = "INRG")]
    [IsoId("_TLCnUM49EeSc85GUbgBycw")]
    [Description(@"Commodity of type inter energy.")]
    InterEnergy,

    /// <summary>
    /// Commodity of type natural gas.
    /// Encoded/decoded by serializers as &quot;NGAS&quot;.
    /// </summary>
    [EnumMember(Value = "NGAS")]
    [IsoId("_TR3oEM49EeSc85GUbgBycw")]
    [Description(@"Commodity of type natural gas.")]
    NaturalGas,

    /// <summary>
    /// Commodity of type oil.
    /// Encoded/decoded by serializers as &quot;OILP&quot;.
    /// </summary>
    [EnumMember(Value = "OILP")]
    [IsoId("_TYtP4M49EeSc85GUbgBycw")]
    [Description(@"Commodity of type oil.")]
    Oil,

    /// <summary>
    /// Commodity of type precious metals.
    /// Encoded/decoded by serializers as &quot;PRME&quot;.
    /// </summary>
    [EnumMember(Value = "PRME")]
    [IsoId("_TiW7IM49EeSc85GUbgBycw")]
    [Description(@"Commodity of type precious metals.")]
    Precious,

    /// <summary>
    /// Commodity of type non precious metals.
    /// Encoded/decoded by serializers as &quot;NPRM&quot;.
    /// </summary>
    [EnumMember(Value = "NPRM")]
    [IsoId("_TqEssM49EeSc85GUbgBycw")]
    [Description(@"Commodity of type non precious metals.")]
    NonPrecious,

    /// <summary>
    /// Commodity of type emission.
    /// Encoded/decoded by serializers as &quot;EMIS&quot;.
    /// </summary>
    [EnumMember(Value = "EMIS")]
    [IsoId("_MSUs8M5GEeSc85GUbgBycw")]
    [Description(@"Commodity of type emission.")]
    Emission,

    /// <summary>
    /// Commodity of type weather.
    /// Encoded/decoded by serializers as &quot;WTHR&quot;.
    /// </summary>
    [EnumMember(Value = "WTHR")]
    [IsoId("_PgrfUM5GEeSc85GUbgBycw")]
    [Description(@"Commodity of type weather.")]
    Weather,

    /// <summary>
    /// Commodity of type freight.
    /// Encoded/decoded by serializers as &quot;FRGT&quot;.
    /// </summary>
    [EnumMember(Value = "FRGT")]
    [IsoId("_YTtgwNDvEeS8V88MH4oPOQ")]
    [Description(@"Commodity of type freight.")]
    Freight,

    /// <summary>
    /// Commodity of type multi commodity exotic.
    /// Encoded/decoded by serializers as &quot;MCEX&quot;.
    /// </summary>
    [EnumMember(Value = "MCEX")]
    [IsoId("_YbcgcNDvEeS8V88MH4oPOQ")]
    [Description(@"Commodity of type multi commodity exotic.")]
    MultiCommodityExotic,

    /// <summary>
    /// Commodity of type renewable energy.
    /// Encoded/decoded by serializers as &quot;RNNG&quot;.
    /// </summary>
    [EnumMember(Value = "RNNG")]
    [IsoId("_iq26sAnaEeWa7rBfPECYsw")]
    [Description(@"Commodity of type renewable energy.")]
    RenewableEnergy,

    /// <summary>
    /// Commodity of type light ends.
    /// Encoded/decoded by serializers as &quot;LGHT&quot;.
    /// </summary>
    [EnumMember(Value = "LGHT")]
    [IsoId("_ng5ckAnaEeWa7rBfPECYsw")]
    [Description(@"Commodity of type light ends.")]
    LightEnds,

    /// <summary>
    /// Commodity of type distillates.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_p0oZwAnaEeWa7rBfPECYsw")]
    [Description(@"Commodity of type distillates.")]
    Distillates,

    /// <summary>
    /// Commodity of type carbon.
    /// Encoded/decoded by serializers as &quot;CRBN&quot;.
    /// </summary>
    [EnumMember(Value = "CRBN")]
    [IsoId("_t_FoAAnaEeWa7rBfPECYsw")]
    [Description(@"Commodity of type carbon.")]
    Carbon,

    /// <summary>
    /// Commodity of type ammonia.
    /// Encoded/decoded by serializers as &quot;AMMO&quot;.
    /// </summary>
    [EnumMember(Value = "AMMO")]
    [IsoId("_v6Q7QAnaEeWa7rBfPECYsw")]
    [Description(@"Commodity of type ammonia.")]
    Ammonia,

    /// <summary>
    /// Commodity of type diammonium phosphate.
    /// Encoded/decoded by serializers as &quot;DAPH&quot;.
    /// </summary>
    [EnumMember(Value = "DAPH")]
    [IsoId("_1r90IAnaEeWa7rBfPECYsw")]
    [Description(@"Commodity of type diammonium phosphate.")]
    DiammoniumPhosphate,

    /// <summary>
    /// Commodity of type potash.
    /// Encoded/decoded by serializers as &quot;PTSH&quot;.
    /// </summary>
    [EnumMember(Value = "PTSH")]
    [IsoId("_6ecEoAnaEeWa7rBfPECYsw")]
    [Description(@"Commodity of type potash.")]
    Potash,

    /// <summary>
    /// Commodity of type sulphur.
    /// Encoded/decoded by serializers as &quot;SLPH&quot;.
    /// </summary>
    [EnumMember(Value = "SLPH")]
    [IsoId("_9NP0QAnaEeWa7rBfPECYsw")]
    [Description(@"Commodity of type sulphur.")]
    Sulphur,

    /// <summary>
    /// Commodity of type urea.
    /// Encoded/decoded by serializers as &quot;UREA&quot;.
    /// </summary>
    [EnumMember(Value = "UREA")]
    [IsoId("___LwYAnaEeWa7rBfPECYsw")]
    [Description(@"Commodity of type urea.")]
    Urea,

    /// <summary>
    /// Commodity of type urea and ammonium nitrite.
    /// Encoded/decoded by serializers as &quot;UAAN&quot;.
    /// </summary>
    [EnumMember(Value = "UAAN")]
    [IsoId("_DZSfwAnbEeWa7rBfPECYsw")]
    [Description(@"Commodity of type urea and ammonium nitrite.")]
    UreaAndAmmoniumNitrite,

    /// <summary>
    /// Commodity of type construction.
    /// Encoded/decoded by serializers as &quot;CSTR&quot;.
    /// </summary>
    [EnumMember(Value = "CSTR")]
    [IsoId("_HzW3UAnbEeWa7rBfPECYsw")]
    [Description(@"Commodity of type construction.")]
    Construction,

    /// <summary>
    /// Commodity of type manufacturing.
    /// Encoded/decoded by serializers as &quot;MFTG&quot;.
    /// </summary>
    [EnumMember(Value = "MFTG")]
    [IsoId("_K8fygAnbEeWa7rBfPECYsw")]
    [Description(@"Commodity of type manufacturing.")]
    Manufacturing,

    /// <summary>
    /// Commodity of type containerboard.
    /// Encoded/decoded by serializers as &quot;CBRD&quot;.
    /// </summary>
    [EnumMember(Value = "CBRD")]
    [IsoId("_S0__0AnbEeWa7rBfPECYsw")]
    [Description(@"Commodity of type containerboard.")]
    Containerboard,

    /// <summary>
    /// Commodity of type newsprint.
    /// Encoded/decoded by serializers as &quot;NSPT&quot;.
    /// </summary>
    [EnumMember(Value = "NSPT")]
    [IsoId("_VzlQ0AnbEeWa7rBfPECYsw")]
    [Description(@"Commodity of type newsprint.")]
    Newsprint,

    /// <summary>
    /// Commodity of type pulp.
    /// Encoded/decoded by serializers as &quot;PULP&quot;.
    /// </summary>
    [EnumMember(Value = "PULP")]
    [IsoId("_ZtqgwAnbEeWa7rBfPECYsw")]
    [Description(@"Commodity of type pulp.")]
    Pulp,

    /// <summary>
    /// Commodity of type recovered paper.
    /// Encoded/decoded by serializers as &quot;RCVP&quot;.
    /// </summary>
    [EnumMember(Value = "RCVP")]
    [IsoId("_cAp3EAnbEeWa7rBfPECYsw")]
    [Description(@"Commodity of type recovered paper.")]
    RecoveredPaper,

    /// <summary>
    /// Commodity of type plastic.
    /// Encoded/decoded by serializers as &quot;PLST&quot;.
    /// </summary>
    [EnumMember(Value = "PLST")]
    [IsoId("_fhm1UAnbEeWa7rBfPECYsw")]
    [Description(@"Commodity of type plastic.")]
    Plastic,

    /// <summary>
    /// Commodity of type carbon related.
    /// Encoded/decoded by serializers as &quot;CRBR&quot;.
    /// </summary>
    [EnumMember(Value = "CRBR")]
    [IsoId("_obtpkAnbEeWa7rBfPECYsw")]
    [Description(@"Commodity of type carbon related.")]
    CarbonRelated,

    /// <summary>
    /// Commodity of type wet freight.
    /// Encoded/decoded by serializers as &quot;WETF&quot;.
    /// </summary>
    [EnumMember(Value = "WETF")]
    [IsoId("_z41XsAncEeWa7rBfPECYsw")]
    [Description(@"Commodity of type wet freight.")]
    Wet,

    /// <summary>
    /// Commodity of type dry freight.
    /// Encoded/decoded by serializers as &quot;DRYF&quot;.
    /// </summary>
    [EnumMember(Value = "DRYF")]
    [IsoId("_2VV2YAncEeWa7rBfPECYsw")]
    [Description(@"Commodity of type dry freight.")]
    Dry,

    /// <summary>
    /// Commodity of type seafood.
    /// Encoded/decoded by serializers as &quot;SEAF&quot;.
    /// </summary>
    [EnumMember(Value = "SEAF")]
    [IsoId("_s-ISkAngEeWuVeNZDXyHtg")]
    [Description(@"Commodity of type seafood.")]
    Seafood,

    /// <summary>
    /// Commodity of type grain.
    /// Encoded/decoded by serializers as &quot;GRIN&quot;.
    /// </summary>
    [EnumMember(Value = "GRIN")]
    [IsoId("_zaYkUAngEeWuVeNZDXyHtg")]
    [Description(@"Commodity of type grain.")]
    Grain,

    /// <summary>
    /// Commodity of type deliverable.
    /// Encoded/decoded by serializers as &quot;DLVR&quot;.
    /// </summary>
    [EnumMember(Value = "DLVR")]
    [IsoId("_JelS0A3oEeWc7_0KPiuk6w")]
    [Description(@"Commodity of type deliverable.")]
    Deliverable,

    /// <summary>
    /// Commodity of type non deliverable.
    /// Encoded/decoded by serializers as &quot;NDLV&quot;.
    /// </summary>
    [EnumMember(Value = "NDLV")]
    [IsoId("_LOULEA3oEeWc7_0KPiuk6w")]
    [Description(@"Commodity of type non deliverable.")]
    NonDeliverable,

    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_p2-sMEDaEeWOL-OsSq2h6w")]
    [Description(@"Commodity of other type.")]
    Other,

    /// <summary>
    /// Commodity of type potato.
    /// Encoded/decoded by serializers as &quot;POTA&quot;.
    /// </summary>
    [EnumMember(Value = "POTA")]
    [IsoId("_DAEhgPwdEeW4Wthd0Ze_kA")]
    [Description(@"Commodity of type potato.")]
    Potato,

    /// <summary>
    /// Commodity of type container ships.
    /// Encoded/decoded by serializers as &quot;CSHP&quot;.
    /// </summary>
    [EnumMember(Value = "CSHP")]
    [IsoId("_ubydwPwfEeW4Wthd0Ze_kA")]
    [Description(@"Commodity of type container ships.")]
    ContainerShip,
}
