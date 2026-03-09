// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Category of data set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t59j4FEHEeyApZmLzm74zA")]
[Description(@"Category of data set.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory17Code
{
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;AQPR&quot;.
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_uJwTYVEHEeyApZmLzm74zA")]
    [Description(@"Acquirer specific configuration parameters for the point of interaction (POI) system.")]
    AcquirerParameters = DataSetCategoryCode.AcquirerParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_uJxhgVEHEeyApZmLzm74zA")]
    [Description(@"Payment application specific configuration parameters for the point of interaction (POI) system.")]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Batch upload of transaction data (data capture of a group of transactions).
    /// Encoded/decoded by serializers as &quot;TXCP&quot;.
    /// </summary>
    [EnumMember(Value = "TXCP")]
    [IsoId("_uJxhg1EHEeyApZmLzm74zA")]
    [Description(@"Batch upload of transaction data (data capture of a group of transactions).")]
    BatchCapture = DataSetCategoryCode.BatchCapture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Batch download response for the batch capture of transactions.
    /// Encoded/decoded by serializers as &quot;AKCP&quot;.
    /// </summary>
    [EnumMember(Value = "AKCP")]
    [IsoId("_uJxhhVEHEeyApZmLzm74zA")]
    [Description(@"Batch download response for the batch capture of transactions.")]
    CaptureResponse = DataSetCategoryCode.CaptureResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data needed to create a terminal management sub-domain.
    /// Encoded/decoded by serializers as &quot;DLGT&quot;.
    /// </summary>
    [EnumMember(Value = "DLGT")]
    [IsoId("_uJxhh1EHEeyApZmLzm74zA")]
    [Description(@"Data needed to create a terminal management sub-domain.")]
    DelegationData = DataSetCategoryCode.DelegationData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration of management plan in the point of interaction.
    /// Encoded/decoded by serializers as &quot;MGTP&quot;.
    /// </summary>
    [EnumMember(Value = "MGTP")]
    [IsoId("_uJxhiVEHEeyApZmLzm74zA")]
    [Description(@"Configuration of management plan in the point of interaction.")]
    ManagementPlan = DataSetCategoryCode.ManagementPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;MRPR&quot;.
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_uJxhi1EHEeyApZmLzm74zA")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = DataSetCategoryCode.MerchantParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// Encoded/decoded by serializers as &quot;SCPR&quot;.
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_uJxhjVEHEeyApZmLzm74zA")]
    [Description(@"Point of interaction parameters related to the security of software application and application protocol.")]
    SecurityParameters = DataSetCategoryCode.SecurityParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as &quot;SWPK&quot;.
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_uJyIkVEHEeyApZmLzm74zA")]
    [Description(@"Software module.")]
    SoftwareModule = DataSetCategoryCode.SoftwareModule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Report of software configuration and parameter status.
    /// Encoded/decoded by serializers as &quot;STRP&quot;.
    /// </summary>
    [EnumMember(Value = "STRP")]
    [IsoId("_uJyIk1EHEeyApZmLzm74zA")]
    [Description(@"Report of software configuration and parameter status.")]
    StatusReport = DataSetCategoryCode.StatusReport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as &quot;TRPR&quot;.
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_uJyIlVEHEeyApZmLzm74zA")]
    [Description(@"Point of interaction parameters attached to the terminal as serial number or physical capabilities.")]
    TerminalParameters = DataSetCategoryCode.TerminalParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.
    /// Encoded/decoded by serializers as &quot;VDPR&quot;.
    /// </summary>
    [EnumMember(Value = "VDPR")]
    [IsoId("_uJyIl1EHEeyApZmLzm74zA")]
    [Description(@"Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.")]
    VendorParameters = DataSetCategoryCode.VendorParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any combination of configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;PARA&quot;.
    /// </summary>
    [EnumMember(Value = "PARA")]
    [IsoId("_uJyImVEHEeyApZmLzm74zA")]
    [Description(@"Any combination of configuration parameters for the point of interaction (POI).")]
    Parameters = DataSetCategoryCode.Parameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as &quot;TMSP&quot;.
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_uJyIm1EHEeyApZmLzm74zA")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters = DataSetCategoryCode.TMSProtocolParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_uJyInVEHEeyApZmLzm74zA")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters = DataSetCategoryCode.CertificateParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any repository used for recording log traces.
    /// Encoded/decoded by serializers as &quot;LOGF&quot;.
    /// </summary>
    [EnumMember(Value = "LOGF")]
    [IsoId("_uJyIn1EHEeyApZmLzm74zA")]
    [Description(@"Any repository used for recording log traces.")]
    LogFile = DataSetCategoryCode.LogFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trigger for CertificateManagementRequest.
    /// Encoded/decoded by serializers as &quot;CMRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CMRQ")]
    [IsoId("_uJyIoVEHEeyApZmLzm74zA")]
    [Description(@"Trigger for CertificateManagementRequest.")]
    CertificateManagementRequest = DataSetCategoryCode.CertificateManagementRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Media file managed by an application of the POI.
    /// Encoded/decoded by serializers as &quot;MDFL&quot;.
    /// </summary>
    [EnumMember(Value = "MDFL")]
    [IsoId("_uJyIo1EHEeyApZmLzm74zA")]
    [Description(@"Media file managed by an application of the POI.")]
    MediaFile = DataSetCategoryCode.MediaFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration file relevant for the POI.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uJyIp1EHEeyApZmLzm74zA")]
    [Description(@"Configuration file relevant for the POI.")]
    ConfigurationFile = DataSetCategoryCode.ConfigurationFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Report file generated by the POI.
    /// Encoded/decoded by serializers as &quot;RPFL&quot;.
    /// </summary>
    [EnumMember(Value = "RPFL")]
    [IsoId("_uJyIqVEHEeyApZmLzm74zA")]
    [Description(@"Report file generated by the POI.")]
    ReportFile = DataSetCategoryCode.ReportFile, // same ordinal as derivation source for type conversions
    
}
