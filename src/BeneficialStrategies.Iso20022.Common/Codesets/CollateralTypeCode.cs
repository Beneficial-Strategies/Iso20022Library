// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a_0hldp-Ed-ak6NoX_4Aeg_591395154")]
[Description(@"Specifies the type of collateral.")]
[Derivations(typeof(CollateralType3Code),typeof(CollateralType2Code),typeof(CollateralType6Code),typeof(CollateralType1Code),typeof(CollateralType8Code))]
public enum CollateralTypeCode
{
    /// <summary>
    /// Instrument issued by a bank substituting its name and credit standing for that of its customer. A letter of credit is a written undertaking of the bank, issued for the account of a customer (the applicant), to honour a demand for payment, upon the beneficiary&apos;s compliance with the terms and conditions set forth in the undertaking.
    /// Encoded/decoded by serializers as &quot;LCRE&quot;.
    /// </summary>
    [EnumMember(Value = "LCRE")]
    [IsoId("_a_0hl9p-Ed-ak6NoX_4Aeg_353770673")]
    [Description(@"Instrument issued by a bank substituting its name and credit standing for that of its customer. A letter of credit is a written undertaking of the bank, issued for the account of a customer (the applicant), to honour a demand for payment, upon the beneficiary's compliance with the terms and conditions set forth in the undertaking.")]
    LetterOfCredit,
    
    /// <summary>
    /// Collateral type is cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_a_0hmNp-Ed-ak6NoX_4Aeg_634801681")]
    [Description(@"Collateral type is cash.")]
    Cash,
    
    /// <summary>
    /// Collateral type is securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_a_9rgNp-Ed-ak6NoX_4Aeg_635724957")]
    [Description(@"Collateral type is securities.")]
    Securities,
    
    /// <summary>
    /// Collateral type are physical entities, for example, airplanes for debt issued by the airline industry.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_a_9rgdp-Ed-ak6NoX_4Aeg_636647622")]
    [Description(@"Collateral type are physical entities, for example, airplanes for debt issued by the airline industry.")]
    PhysicalEntities,
    
    /// <summary>
    /// Collateral type is an insurance contract.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_a_9rgtp-Ed-ak6NoX_4Aeg_636650588")]
    [Description(@"Collateral type is an insurance contract.")]
    Insurance,
    
    /// <summary>
    /// Collateral type is stock certificates.
    /// Encoded/decoded by serializers as &quot;STCF&quot;.
    /// </summary>
    [EnumMember(Value = "STCF")]
    [IsoId("__-SlQNojEeC60axPepSq7g_-190441268")]
    [Description(@"Collateral type is stock certificates.")]
    StockCertificate,
    
    /// <summary>
    /// Collateral type is bonds.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("__-SlQdojEeC60axPepSq7g_-2128498734")]
    [Description(@"Collateral type is bonds.")]
    Bond,
    
    /// <summary>
    /// Collateral type is a bank guarantee.
    /// Encoded/decoded by serializers as &quot;GBBK&quot;.
    /// </summary>
    [EnumMember(Value = "GBBK")]
    [IsoId("__-SlQtojEeC60axPepSq7g_1571827888")]
    [Description(@"Collateral type is a bank guarantee.")]
    BankGuarantee,
    
    /// <summary>
    /// Other assets that could be used as collateral.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a_0hltp-Ed-ak6NoX_4Aeg_239931607")]
    [Description(@"Other assets that could be used as collateral.")]
    Other,
    
    /// <summary>
    /// Collateral type is commodities.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_0lVtwDIIEear3KYiQI7_2Q")]
    [Description(@"Collateral type is commodities.")]
    Commodity,
    
    /// <summary>
    /// Collateral type is automobile.
    /// Encoded/decoded by serializers as &quot;CARX&quot;.
    /// </summary>
    [EnumMember(Value = "CARX")]
    [IsoId("_fU7kACSVEemoiMEiwtMpyw")]
    [Description(@"Collateral type is automobile.")]
    Automobile,
    
    /// <summary>
    /// Collateral type is industrial vehicle.
    /// Encoded/decoded by serializers as &quot;INDV&quot;.
    /// </summary>
    [EnumMember(Value = "INDV")]
    [IsoId("_jUBPwCSVEemoiMEiwtMpyw")]
    [Description(@"Collateral type is industrial vehicle.")]
    IndustrialVehicle,
    
    /// <summary>
    /// Collateral type is commercial track.
    /// Encoded/decoded by serializers as &quot;CMTR&quot;.
    /// </summary>
    [EnumMember(Value = "CMTR")]
    [IsoId("_xKHc4CSVEemoiMEiwtMpyw")]
    [Description(@"Collateral type is commercial track.")]
    CommercialTruck,
    
    /// <summary>
    /// Collateral type is rail vehicle.
    /// Encoded/decoded by serializers as &quot;RALV&quot;.
    /// </summary>
    [EnumMember(Value = "RALV")]
    [IsoId("_0z4Y4CSVEemoiMEiwtMpyw")]
    [Description(@"Collateral type is rail vehicle.")]
    RailVehicle,
    
    /// <summary>
    /// Collateral type is nautical commercial vehicle.
    /// Encoded/decoded by serializers as &quot;NACM&quot;.
    /// </summary>
    [EnumMember(Value = "NACM")]
    [IsoId("_314xUCSVEemoiMEiwtMpyw")]
    [Description(@"Collateral type is nautical commercial vehicle.")]
    NauticalCommercialVehicle,
    
    /// <summary>
    /// Collateral type is nautical leisure vehicle.
    /// Encoded/decoded by serializers as &quot;NALV&quot;.
    /// </summary>
    [EnumMember(Value = "NALV")]
    [IsoId("_CGFOwCSWEemoiMEiwtMpyw")]
    [Description(@"Collateral type is nautical leisure vehicle.")]
    NauticalLeisureVehicle,
    
    /// <summary>
    /// Collateral type is aeroplane.
    /// Encoded/decoded by serializers as &quot;AERO&quot;.
    /// </summary>
    [EnumMember(Value = "AERO")]
    [IsoId("_IEa1cCSWEemoiMEiwtMpyw")]
    [Description(@"Collateral type is aeroplane.")]
    Aeroplane,
    
    /// <summary>
    /// Collateral type is machine.
    /// Encoded/decoded by serializers as &quot;MCHT&quot;.
    /// </summary>
    [EnumMember(Value = "MCHT")]
    [IsoId("_K2dfQCSWEemoiMEiwtMpyw")]
    [Description(@"Collateral type is machine.")]
    MachineTool,
    
    /// <summary>
    /// Collateral type is industrial equipment.
    /// Encoded/decoded by serializers as &quot;INDE&quot;.
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_N5r_sCSWEemoiMEiwtMpyw")]
    [Description(@"Collateral type is industrial equipment.")]
    IndustrialEquipment,
    
    /// <summary>
    /// Collateral type is office equipment.
    /// Encoded/decoded by serializers as &quot;OFEQ&quot;.
    /// </summary>
    [EnumMember(Value = "OFEQ")]
    [IsoId("_TAMmgCSWEemoiMEiwtMpyw")]
    [Description(@"Collateral type is office equipment.")]
    OfficeEquipment,
    
    /// <summary>
    /// Collateral type is IT equipment.
    /// Encoded/decoded by serializers as &quot;ITEQ&quot;.
    /// </summary>
    [EnumMember(Value = "ITEQ")]
    [IsoId("_YEuQUCSWEemoiMEiwtMpyw")]
    [Description(@"Collateral type is IT equipment.")]
    ITEquipment,
    
    /// <summary>
    /// Collateral type is medical equipment.
    /// Encoded/decoded by serializers as &quot;MDEQ&quot;.
    /// </summary>
    [EnumMember(Value = "MDEQ")]
    [IsoId("_bw8qcCSWEemoiMEiwtMpyw")]
    [Description(@"Collateral type is medical equipment.")]
    MedicalEquipment,
    
    /// <summary>
    /// Collateral type is energy related equipment.
    /// Encoded/decoded by serializers as &quot;ENEQ&quot;.
    /// </summary>
    [EnumMember(Value = "ENEQ")]
    [IsoId("_fcHUoCSWEemoiMEiwtMpyw")]
    [Description(@"Collateral type is energy related equipment.")]
    EnergyRelatedEquipment,
    
    /// <summary>
    /// Collateral type is commercial building.
    /// Encoded/decoded by serializers as &quot;CBLD&quot;.
    /// </summary>
    [EnumMember(Value = "CBLD")]
    [IsoId("_keqogCSWEemoiMEiwtMpyw")]
    [Description(@"Collateral type is commercial building.")]
    CommercialBuilding,
    
    /// <summary>
    /// Collateral type is residential building.
    /// Encoded/decoded by serializers as &quot;RBLD&quot;.
    /// </summary>
    [EnumMember(Value = "RBLD")]
    [IsoId("_pwz3kCSWEemoiMEiwtMpyw")]
    [Description(@"Collateral type is residential building.")]
    ResidentialBuilding,
    
    /// <summary>
    /// Collateral type is industrial building.
    /// Encoded/decoded by serializers as &quot;IBLD&quot;.
    /// </summary>
    [EnumMember(Value = "IBLD")]
    [IsoId("_th0rECSWEemoiMEiwtMpyw")]
    [Description(@"Collateral type is industrial building.")]
    IndustrialBuilding,
    
    /// <summary>
    /// Commercial type is other vehicle.
    /// Encoded/decoded by serializers as &quot;OTHV&quot;.
    /// </summary>
    [EnumMember(Value = "OTHV")]
    [IsoId("_yckt0CSWEemoiMEiwtMpyw")]
    [Description(@"Commercial type is other vehicle.")]
    OtherVehicle,
    
    /// <summary>
    /// Collateral type is other equipment.
    /// Encoded/decoded by serializers as &quot;OTHE&quot;.
    /// </summary>
    [EnumMember(Value = "OTHE")]
    [IsoId("_OSzN0CSXEemoiMEiwtMpyw")]
    [Description(@"Collateral type is other equipment.")]
    OtherEquipment,
    
    /// <summary>
    /// Collateral type is other real estate.
    /// Encoded/decoded by serializers as &quot;OTRE&quot;.
    /// </summary>
    [EnumMember(Value = "OTRE")]
    [IsoId("_v16_MCSXEemoiMEiwtMpyw")]
    [Description(@"Collateral type is other real estate.")]
    OtherRealEstate,
    
    /// <summary>
    /// Collateral type is other goods or inventory.
    /// Encoded/decoded by serializers as &quot;OTGI&quot;.
    /// </summary>
    [EnumMember(Value = "OTGI")]
    [IsoId("_1vmIUCSXEemoiMEiwtMpyw")]
    [Description(@"Collateral type is other goods or inventory.")]
    OtherGoodsOrInventory,
    
    /// <summary>
    /// Collateral type is guarantee.
    /// Encoded/decoded by serializers as &quot;GUAR&quot;.
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("_757joCSXEemoiMEiwtMpyw")]
    [Description(@"Collateral type is guarantee.")]
    Guarantee,
    
    /// <summary>
    /// Collateral type is other financial asset.
    /// Encoded/decoded by serializers as &quot;OTFA&quot;.
    /// </summary>
    [EnumMember(Value = "OTFA")]
    [IsoId("_AJCoYCSYEemoiMEiwtMpyw")]
    [Description(@"Collateral type is other financial asset.")]
    OtherFinancialAsset,
    
    /// <summary>
    /// Collateral type is mixed categories due to security over all assets of the obligor.
    /// Encoded/decoded by serializers as &quot;MIXD&quot;.
    /// </summary>
    [EnumMember(Value = "MIXD")]
    [IsoId("_ETTCUCSYEemoiMEiwtMpyw")]
    [Description(@"Collateral type is mixed categories due to security over all assets of the obligor.")]
    MixedCategoriesDueToSecurityOverAllAssetsOfTheObligor,
    
    /// <summary>
    /// Total credit claims.
    /// Encoded/decoded by serializers as &quot;CCCL&quot;.
    /// </summary>
    [EnumMember(Value = "CCCL")]
    [IsoId("_LtWSgALvEeutW5-TpeYJhA")]
    [Description(@"Total credit claims.")]
    TotalCreditClaims,
    
    /// <summary>
    /// Total fixed term deposit used as collateral.
    /// Encoded/decoded by serializers as &quot;CFTD&quot;.
    /// </summary>
    [EnumMember(Value = "CFTD")]
    [IsoId("_Ys1nwALvEeutW5-TpeYJhA")]
    [Description(@"Total fixed term deposit used as collateral.")]
    TotalFixedTermDeposit,
    
    /// <summary>
    /// Total interest for fixed term Deposit used as collateral.
    /// Encoded/decoded by serializers as &quot;CFTI&quot;.
    /// </summary>
    [EnumMember(Value = "CFTI")]
    [IsoId("_l8GeYALvEeutW5-TpeYJhA")]
    [Description(@"Total interest for fixed term Deposit used as collateral.")]
    TotalInterestForFixedTermDeposit,
    
    /// <summary>
    /// Total triparty collateral.
    /// Encoded/decoded by serializers as &quot;CTRC&quot;.
    /// </summary>
    [EnumMember(Value = "CTRC")]
    [IsoId("_yZhoYALvEeutW5-TpeYJhA")]
    [Description(@"Total triparty collateral.")]
    TotalTripartyCollateral,
    
    /// <summary>
    /// Total externally managed collateral for credit claims.
    /// Encoded/decoded by serializers as &quot;CXCC&quot;.
    /// </summary>
    [EnumMember(Value = "CXCC")]
    [IsoId("_5YSxUALvEeutW5-TpeYJhA")]
    [Description(@"Total externally managed collateral for credit claims.")]
    TotalExternallyManagedCollateralForCreditClaim,
    
    /// <summary>
    /// Total externally managed collateral apart from credit claims.
    /// Encoded/decoded by serializers as &quot;CEMC&quot;.
    /// </summary>
    [EnumMember(Value = "CEMC")]
    [IsoId("_D2hDsALwEeutW5-TpeYJhA")]
    [Description(@"Total externally managed collateral apart from credit claims.|")]
    TotalExternallyManagedCollateralApartFromCreditClaims,
    
    /// <summary>
    /// Total collateral affected to open market operations.
    /// Encoded/decoded by serializers as &quot;COMO&quot;.
    /// </summary>
    [EnumMember(Value = "COMO")]
    [IsoId("_Op3RgALwEeutW5-TpeYJhA")]
    [Description(@"Total collateral affected to open market operations.")]
    TotalCollateralAffectedToOpenMarketOperations,
    
    /// <summary>
    /// Total collateral operations.
    /// Encoded/decoded by serializers as &quot;CTCO&quot;.
    /// </summary>
    [EnumMember(Value = "CTCO")]
    [IsoId("_9gYyoALwEeutW5-TpeYJhA")]
    [Description(@"Total collateral operations.||")]
    TotalCollateralOperations,
    
    /// <summary>
    /// Total collateral value after relative credit limit.
    /// Encoded/decoded by serializers as &quot;CCVR&quot;.
    /// </summary>
    [EnumMember(Value = "CCVR")]
    [IsoId("_FLfdIALxEeutW5-TpeYJhA")]
    [Description(@"Total collateral value after relative credit limit.")]
    TotalCollateralValueAfterRelativeCreditLimit,
    
}
