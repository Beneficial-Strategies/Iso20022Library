// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the sector of a party with non financial activities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_H2VH0BQYEeWSI-Fz8Zwg6g")]
[Description(@"Specifies the sector of a party with non financial activities.")]
[Derivations(typeof(NonFinancialPartySector1Code))]
public enum NonFinancialPartySectorCode
{
    /// <summary>
    /// Agriculture, forestry and fishing activities.
    /// Encoded/decoded by serializers as &quot;AGRI&quot;.
    /// </summary>
    [EnumMember(Value = "AGRI")]
    [IsoId("_KwGxUBQYEeWSI-Fz8Zwg6g")]
    [Description(@"Agriculture, forestry and fishing activities.|")]
    AgricultureForestryAndFishing,
    
    /// <summary>
    /// Mining and quarrying activities.
    /// Encoded/decoded by serializers as &quot;MING&quot;.
    /// </summary>
    [EnumMember(Value = "MING")]
    [IsoId("_K9peEBQYEeWSI-Fz8Zwg6g")]
    [Description(@"Mining and quarrying activities.|")]
    MiningAndQuarrying,
    
    /// <summary>
    /// Manufacturing activities.
    /// Encoded/decoded by serializers as &quot;MAFG&quot;.
    /// </summary>
    [EnumMember(Value = "MAFG")]
    [IsoId("_K_db8BQYEeWSI-Fz8Zwg6g")]
    [Description(@"Manufacturing activities.|")]
    Manufacturing,
    
    /// <summary>
    /// Electricity, gas, steam and air conditioning supply activities.
    /// Encoded/decoded by serializers as &quot;SPLY&quot;.
    /// </summary>
    [EnumMember(Value = "SPLY")]
    [IsoId("_LA_F8BQYEeWSI-Fz8Zwg6g")]
    [Description(@"Electricity, gas, steam and air conditioning supply activities.|")]
    ElectricityGasSteamAndAirConditioningSupply,
    
    /// <summary>
    /// Water supply, sewerage, waste management and remediation activities.
    /// Encoded/decoded by serializers as &quot;WTER&quot;.
    /// </summary>
    [EnumMember(Value = "WTER")]
    [IsoId("_LCzD0BQYEeWSI-Fz8Zwg6g")]
    [Description(@"Water supply, sewerage, waste management and remediation activities.|")]
    WaterSupplySewerageWasteManagementAndRemediation,
    
    /// <summary>
    /// Construction activities.
    /// Encoded/decoded by serializers as &quot;CSTR&quot;.
    /// </summary>
    [EnumMember(Value = "CSTR")]
    [IsoId("_LEa0cBQYEeWSI-Fz8Zwg6g")]
    [Description(@"Construction activities.")]
    Construction,
    
    /// <summary>
    /// Wholesale and retail trade, repair of motor vehicles and motorcycles.
    /// Encoded/decoded by serializers as &quot;WRRM&quot;.
    /// </summary>
    [EnumMember(Value = "WRRM")]
    [IsoId("_6QPQIBQYEeWSI-Fz8Zwg6g")]
    [Description(@"Wholesale and retail trade, repair of motor vehicles and motorcycles.")]
    MotorVehiclesAndMotorcycles,
    
    /// <summary>
    /// Information and communication activities.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_8T8NQBQYEeWSI-Fz8Zwg6g")]
    [Description(@"Information and communication activities.")]
    InformationAndCommunication,
    
    /// <summary>
    /// Transportation and storage activities.
    /// Encoded/decoded by serializers as &quot;TRAS&quot;.
    /// </summary>
    [EnumMember(Value = "TRAS")]
    [IsoId("_-XFJsBQYEeWSI-Fz8Zwg6g")]
    [Description(@"Transportation and storage activities.")]
    TransportationAndStorage,
    
    /// <summary>
    /// Accommodation and food service activities.
    /// Encoded/decoded by serializers as &quot;ACAF&quot;.
    /// </summary>
    [EnumMember(Value = "ACAF")]
    [IsoId("_ABOXUBQZEeWSI-Fz8Zwg6g")]
    [Description(@"Accommodation and food service activities.")]
    AccomodationAndFood,
    
    /// <summary>
    /// Financial and insurance activities.
    /// Encoded/decoded by serializers as &quot;FINA&quot;.
    /// </summary>
    [EnumMember(Value = "FINA")]
    [IsoId("_V_6w0BVZEeWLrt6TQWUeiw")]
    [Description(@"Financial and insurance activities.")]
    FinancialAndInsuranceActivity,
    
    /// <summary>
    /// Real estate activities.
    /// Encoded/decoded by serializers as &quot;RESA&quot;.
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_WIZXYBVZEeWLrt6TQWUeiw")]
    [Description(@"Real estate activities.")]
    RealEstateActivity,
    
    /// <summary>
    /// Professional, scientific and technical activities.
    /// Encoded/decoded by serializers as &quot;PSTA&quot;.
    /// </summary>
    [EnumMember(Value = "PSTA")]
    [IsoId("_WRLf8BVZEeWLrt6TQWUeiw")]
    [Description(@"Professional, scientific and technical activities.|")]
    ProfessionalScientificAndTechnicalActivity,
    
    /// <summary>
    /// Administrative and support service activities.
    /// Encoded/decoded by serializers as &quot;ASSA&quot;.
    /// </summary>
    [EnumMember(Value = "ASSA")]
    [IsoId("_WRea4BVZEeWLrt6TQWUeiw")]
    [Description(@"Administrative and support service activities.|")]
    AdministrativeAndSupportServiceActivity,
    
    /// <summary>
    /// Public administration and defence, compulsory social security.
    /// Encoded/decoded by serializers as &quot;PADS&quot;.
    /// </summary>
    [EnumMember(Value = "PADS")]
    [IsoId("_WZqGgBVZEeWLrt6TQWUeiw")]
    [Description(@"Public administration and defence, compulsory social security.|")]
    PublicAdministrationAndDefence,
    
    /// <summary>
    /// Education activities.
    /// Encoded/decoded by serializers as &quot;EDUC&quot;.
    /// </summary>
    [EnumMember(Value = "EDUC")]
    [IsoId("_WiItEBVZEeWLrt6TQWUeiw")]
    [Description(@"Education activities.")]
    Education,
    
    /// <summary>
    /// Human health and social work activities.
    /// Encoded/decoded by serializers as &quot;HHSW&quot;.
    /// </summary>
    [EnumMember(Value = "HHSW")]
    [IsoId("_WiItERVZEeWLrt6TQWUeiw")]
    [Description(@"Human health and social work activities.")]
    HumanHealthAndSocialWorkActivity,
    
    /// <summary>
    /// Arts, entertainment and recreation activities.
    /// Encoded/decoded by serializers as &quot;AEAR&quot;.
    /// </summary>
    [EnumMember(Value = "AEAR")]
    [IsoId("_WqUYsBVZEeWLrt6TQWUeiw")]
    [Description(@"Arts, entertainment and recreation activities.|")]
    ArtsEntertainmentAndRecreation,
    
    /// <summary>
    /// Other service activities.
    /// Encoded/decoded by serializers as &quot;OTSA&quot;.
    /// </summary>
    [EnumMember(Value = "OTSA")]
    [IsoId("_WypOQBVZEeWLrt6TQWUeiw")]
    [Description(@"Other service activities.")]
    OtherServiceActivity,
    
    /// <summary>
    /// Activities of households as employers; undifferentiated goods – and services –producing activities of households for own use.
    /// Encoded/decoded by serializers as &quot;AHAE&quot;.
    /// </summary>
    [EnumMember(Value = "AHAE")]
    [IsoId("_WypOQRVZEeWLrt6TQWUeiw")]
    [Description(@"Activities of households as employers; undifferentiated goods – and services –producing activities of households for own use.")]
    ActivityOfHouseholdsAsEmployer,
    
    /// <summary>
    /// Activities of extraterritorial organisations and bodies.
    /// Encoded/decoded by serializers as &quot;AEOB&quot;.
    /// </summary>
    [EnumMember(Value = "AEOB")]
    [IsoId("_W6054BVZEeWLrt6TQWUeiw")]
    [Description(@"Activities of extraterritorial organisations and bodies.|")]
    ActivityOfExtraterritorialOrganisationAndBody,
    
}
