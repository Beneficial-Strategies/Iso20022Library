// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Maintenance service to delegate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EtNxwTAMEeugIJ3Gvoevmg")]
[Description(@"Maintenance service to delegate.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory16Code
{
    /// <summary>
    /// Configuration parameters of the payment acquirer protocol.
    /// Encoded/decoded by serializers as &quot;ACQP&quot;.
    /// </summary>
    [EnumMember(Value = "ACQP")]
    [IsoId("_E6YrETAMEeugIJ3Gvoevmg")]
    [Description(@"Configuration parameters of the payment acquirer protocol.")]
    AcquirerProtocolParameters = DataSetCategoryCode.AcquirerProtocolParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_E6YrEzAMEeugIJ3Gvoevmg")]
    [Description(@"Payment application specific configuration parameters for the point of interaction (POI) system.")]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creation of a subset of the configuration parameters of an application.
    /// Encoded/decoded by serializers as &quot;APSB&quot;.
    /// </summary>
    [EnumMember(Value = "APSB")]
    [IsoId("_E6YrFTAMEeugIJ3Gvoevmg")]
    [Description(@"Creation of a subset of the configuration parameters of an application.")]
    ApplicationParametersSubsetCreation = DataSetCategoryCode.ApplicationParametersSubsetCreation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Download of cryptographic keys with the related information.
    /// Encoded/decoded by serializers as &quot;KDWL&quot;.
    /// </summary>
    [EnumMember(Value = "KDWL")]
    [IsoId("_E6YrFzAMEeugIJ3Gvoevmg")]
    [Description(@"Download of cryptographic keys with the related information.")]
    KeyDownload = DataSetCategoryCode.KeyDownload, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Activate, deactivate or revoke loaded cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KMGT&quot;.
    /// </summary>
    [EnumMember(Value = "KMGT")]
    [IsoId("_E6YrGTAMEeugIJ3Gvoevmg")]
    [Description(@"Activate, deactivate or revoke loaded cryptographic keys.")]
    KeyManagement = DataSetCategoryCode.KeyManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reporting on activity, status and error of a point of interaction.
    /// Encoded/decoded by serializers as &quot;RPRT&quot;.
    /// </summary>
    [EnumMember(Value = "RPRT")]
    [IsoId("_E6YrGzAMEeugIJ3Gvoevmg")]
    [Description(@"Reporting on activity, status and error of a point of interaction.")]
    Reporting = DataSetCategoryCode.Reporting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as &quot;SWPK&quot;.
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_E6YrHTAMEeugIJ3Gvoevmg")]
    [Description(@"Software module.")]
    SoftwareModule = DataSetCategoryCode.SoftwareModule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as &quot;TMSP&quot;.
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_E6YrHzAMEeugIJ3Gvoevmg")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters = DataSetCategoryCode.TMSProtocolParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;MRPR&quot;.
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_E6YrITAMEeugIJ3Gvoevmg")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = DataSetCategoryCode.MerchantParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as &quot;TRPR&quot;.
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_E6YrIzAMEeugIJ3Gvoevmg")]
    [Description(@"Point of interaction parameters attached to the terminal as serial number or physical capabilities.")]
    TerminalParameters = DataSetCategoryCode.TerminalParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_E6YrJTAMEeugIJ3Gvoevmg")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters = DataSetCategoryCode.CertificateParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Component of the Sale system.
    /// Encoded/decoded by serializers as &quot;SACP&quot;.
    /// </summary>
    [EnumMember(Value = "SACP")]
    [IsoId("_E6YrJzAMEeugIJ3Gvoevmg")]
    [Description(@"Component of the Sale system.")]
    SaleComponent = DataSetCategoryCode.SaleComponent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Parameters related to the Sale to POI protocol.
    /// Encoded/decoded by serializers as &quot;SAPR&quot;.
    /// </summary>
    [EnumMember(Value = "SAPR")]
    [IsoId("_E6YrKTAMEeugIJ3Gvoevmg")]
    [Description(@"Parameters related to the Sale to POI protocol.")]
    SaleToPOIProtocolParameters = DataSetCategoryCode.SaleToPOIProtocolParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any repository used for recording log traces.
    /// Encoded/decoded by serializers as &quot;LOGF&quot;.
    /// </summary>
    [EnumMember(Value = "LOGF")]
    [IsoId("_E6YrKzAMEeugIJ3Gvoevmg")]
    [Description(@"Any repository used for recording log traces.")]
    LogFile = DataSetCategoryCode.LogFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Report file generated by the POI.
    /// Encoded/decoded by serializers as &quot;RPFL&quot;.
    /// </summary>
    [EnumMember(Value = "RPFL")]
    [IsoId("_E6YrLTAMEeugIJ3Gvoevmg")]
    [Description(@"Report file generated by the POI.")]
    ReportFile = DataSetCategoryCode.ReportFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration file relevant for the POI.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_E6YrLzAMEeugIJ3Gvoevmg")]
    [Description(@"Configuration file relevant for the POI.")]
    ConfigurationFile = DataSetCategoryCode.ConfigurationFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service Provider specific parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;SPRP&quot;.
    /// </summary>
    [EnumMember(Value = "SPRP")]
    [IsoId("_Hn1IwTAMEeugIJ3Gvoevmg")]
    [Description(@"Service Provider specific parameters for the point of interaction (POI) system.")]
    ServiceProviderParameters = DataSetCategoryCode.ServiceProviderParameters, // same ordinal as derivation source for type conversions
    
}
