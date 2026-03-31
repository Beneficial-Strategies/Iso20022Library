// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the sector of a party with non financial activities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vDGpUBQYEeWSI-Fz8Zwg6g")]
[Description(@"Specifies the sector of a party with non financial activities.")]
[DerivedFrom(typeof(NonFinancialPartySectorCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NonFinancialPartySector1Code>))]
#endif
public enum NonFinancialPartySector1Code
{
    /// <summary>
    /// Water supply, sewerage, waste management and remediation activities.
    /// Encoded/decoded by serializers as &quot;WTER&quot;.
    /// </summary>
    [EnumMember(Value = "WTER")]
    [IsoId("_wE0lARQYEeWSI-Fz8Zwg6g")]
    [Description(@"Water supply, sewerage, waste management and remediation activities.|")]
    WaterSupplySewerageWasteManagementAndRemediation =
        NonFinancialPartySectorCode.WaterSupplySewerageWasteManagementAndRemediation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mining and quarrying activities.
    /// Encoded/decoded by serializers as &quot;MING&quot;.
    /// </summary>
    [EnumMember(Value = "MING")]
    [IsoId("_wMQpwRQYEeWSI-Fz8Zwg6g")]
    [Description(@"Mining and quarrying activities.|")]
    MiningAndQuarrying = NonFinancialPartySectorCode.MiningAndQuarrying, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Manufacturing activities.
    /// Encoded/decoded by serializers as &quot;MAFG&quot;.
    /// </summary>
    [EnumMember(Value = "MAFG")]
    [IsoId("_wSLEgRQYEeWSI-Fz8Zwg6g")]
    [Description(@"Manufacturing activities.|")]
    Manufacturing = NonFinancialPartySectorCode.Manufacturing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electricity, gas, steam and air conditioning supply activities.
    /// Encoded/decoded by serializers as &quot;SPLY&quot;.
    /// </summary>
    [EnumMember(Value = "SPLY")]
    [IsoId("_wXzLYRQYEeWSI-Fz8Zwg6g")]
    [Description(@"Electricity, gas, steam and air conditioning supply activities.|")]
    ElectricityGasSteamAndAirConditioningSupply =
        NonFinancialPartySectorCode.ElectricityGasSteamAndAirConditioningSupply, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Construction activities.
    /// Encoded/decoded by serializers as &quot;CSTR&quot;.
    /// </summary>
    [EnumMember(Value = "CSTR")]
    [IsoId("_wgMSYRQYEeWSI-Fz8Zwg6g")]
    [Description(@"Construction activities.")]
    Construction = NonFinancialPartySectorCode.Construction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agriculture, forestry and fishing activities.
    /// Encoded/decoded by serializers as &quot;AGRI&quot;.
    /// </summary>
    [EnumMember(Value = "AGRI")]
    [IsoId("_wnP8oRQYEeWSI-Fz8Zwg6g")]
    [Description(@"Agriculture, forestry and fishing activities.|")]
    AgricultureForestryAndFishing = NonFinancialPartySectorCode.AgricultureForestryAndFishing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accommodation and food service activities.
    /// Encoded/decoded by serializers as &quot;ACAF&quot;.
    /// </summary>
    [EnumMember(Value = "ACAF")]
    [IsoId("_FRr48RVZEeWLrt6TQWUeiw")]
    [Description(@"Accommodation and food service activities.")]
    AccomodationAndFood = NonFinancialPartySectorCode.AccomodationAndFood, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Education activities.
    /// Encoded/decoded by serializers as &quot;EDUC&quot;.
    /// </summary>
    [EnumMember(Value = "EDUC")]
    [IsoId("_4UszMRVaEeWLrt6TQWUeiw")]
    [Description(@"Education activities.")]
    Education = NonFinancialPartySectorCode.Education, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Arts, entertainment and recreation activities.
    /// Encoded/decoded by serializers as &quot;AEAR&quot;.
    /// </summary>
    [EnumMember(Value = "AEAR")]
    [IsoId("_4hDNIRVaEeWLrt6TQWUeiw")]
    [Description(@"Arts, entertainment and recreation activities.|")]
    ArtsEntertainmentAndRecreation = NonFinancialPartySectorCode.ArtsEntertainmentAndRecreation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial and insurance activities.
    /// Encoded/decoded by serializers as &quot;FINA&quot;.
    /// </summary>
    [EnumMember(Value = "FINA")]
    [IsoId("_4tixARVaEeWLrt6TQWUeiw")]
    [Description(@"Financial and insurance activities.")]
    FinancialAndInsuranceActivity = NonFinancialPartySectorCode.FinancialAndInsuranceActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Human health and social work activities.
    /// Encoded/decoded by serializers as &quot;HHSW&quot;.
    /// </summary>
    [EnumMember(Value = "HHSW")]
    [IsoId("_455K8RVaEeWLrt6TQWUeiw")]
    [Description(@"Human health and social work activities.")]
    HumanHealthAndSocialWorkActivity = NonFinancialPartySectorCode.HumanHealthAndSocialWorkActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information and communication activities.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_5HIVsRVaEeWLrt6TQWUeiw")]
    [Description(@"Information and communication activities.")]
    InformationAndCommunication = NonFinancialPartySectorCode.InformationAndCommunication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Wholesale and retail trade, repair of motor vehicles and motorcycles.
    /// Encoded/decoded by serializers as &quot;WRRM&quot;.
    /// </summary>
    [EnumMember(Value = "WRRM")]
    [IsoId("_5l7KgRVaEeWLrt6TQWUeiw")]
    [Description(@"Wholesale and retail trade, repair of motor vehicles and motorcycles.")]
    MotorVehiclesAndMotorcycles = NonFinancialPartySectorCode.MotorVehiclesAndMotorcycles, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other service activities.
    /// Encoded/decoded by serializers as &quot;OTSA&quot;.
    /// </summary>
    [EnumMember(Value = "OTSA")]
    [IsoId("_5y4BYRVaEeWLrt6TQWUeiw")]
    [Description(@"Other service activities.")]
    OtherServiceActivity = NonFinancialPartySectorCode.OtherServiceActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Professional, scientific and technical activities.
    /// Encoded/decoded by serializers as &quot;PSTA&quot;.
    /// </summary>
    [EnumMember(Value = "PSTA")]
    [IsoId("_5_N0QRVaEeWLrt6TQWUeiw")]
    [Description(@"Professional, scientific and technical activities.|")]
    ProfessionalScientificAndTechnicalActivity =
        NonFinancialPartySectorCode.ProfessionalScientificAndTechnicalActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Public administration and defence, compulsory social security.
    /// Encoded/decoded by serializers as &quot;PADS&quot;.
    /// </summary>
    [EnumMember(Value = "PADS")]
    [IsoId("_6LkOMRVaEeWLrt6TQWUeiw")]
    [Description(@"Public administration and defence, compulsory social security.|")]
    PublicAdministrationAndDefence = NonFinancialPartySectorCode.PublicAdministrationAndDefence, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Real estate activities.
    /// Encoded/decoded by serializers as &quot;RESA&quot;.
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_60LtYRVaEeWLrt6TQWUeiw")]
    [Description(@"Real estate activities.")]
    RealEstateActivity = NonFinancialPartySectorCode.RealEstateActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transportation and storage activities.
    /// Encoded/decoded by serializers as &quot;TRAS&quot;.
    /// </summary>
    [EnumMember(Value = "TRAS")]
    [IsoId("_7AiHURVaEeWLrt6TQWUeiw")]
    [Description(@"Transportation and storage activities.")]
    TransportationAndStorage = NonFinancialPartySectorCode.TransportationAndStorage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Administrative and support service activities.
    /// Encoded/decoded by serializers as &quot;ASSA&quot;.
    /// </summary>
    [EnumMember(Value = "ASSA")]
    [IsoId("_BR290exnEeWDzYHCp-PB8g")]
    [Description(@"Administrative and support service activities.|")]
    AdministrativeAndSupportServiceActivity =
        NonFinancialPartySectorCode.AdministrativeAndSupportServiceActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Activities of households as employers; undifferentiated goods – and services –producing activities of households for own use.
    /// Encoded/decoded by serializers as &quot;AHAE&quot;.
    /// </summary>
    [EnumMember(Value = "AHAE")]
    [IsoId("_CeDEIexnEeWDzYHCp-PB8g")]
    [Description(
        @"Activities of households as employers; undifferentiated goods – and services –producing activities of households for own use."
    )]
    ActivityOfHouseholdsAsEmployer = NonFinancialPartySectorCode.ActivityOfHouseholdsAsEmployer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Activities of extraterritorial organisations and bodies.
    /// Encoded/decoded by serializers as &quot;AEOB&quot;.
    /// </summary>
    [EnumMember(Value = "AEOB")]
    [IsoId("_DXnwcexnEeWDzYHCp-PB8g")]
    [Description(@"Activities of extraterritorial organisations and bodies.|")]
    ActivityOfExtraterritorialOrganisationAndBody =
        NonFinancialPartySectorCode.ActivityOfExtraterritorialOrganisationAndBody, // same ordinal as derivation source for type conversions
}
