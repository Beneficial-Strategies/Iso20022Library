// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Category of data set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lk9GcQ0aEeqUVL7sB4m7NA")]
[Description(@"Category of data set.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory14Code
{
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;AQPR&quot;.
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_lwb9sQ0aEeqUVL7sB4m7NA")]
    [Description(
        @"Acquirer specific configuration parameters for the point of interaction (POI) system."
    )]
    AcquirerParameters = DataSetCategoryCode.AcquirerParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_lwb9sw0aEeqUVL7sB4m7NA")]
    [Description(
        @"Payment application specific configuration parameters for the point of interaction (POI) system."
    )]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Batch upload of transaction data (data capture of a group of transactions).
    /// Encoded/decoded by serializers as &quot;TXCP&quot;.
    /// </summary>
    [EnumMember(Value = "TXCP")]
    [IsoId("_lwb9tQ0aEeqUVL7sB4m7NA")]
    [Description(@"Batch upload of transaction data (data capture of a group of transactions).")]
    BatchCapture = DataSetCategoryCode.BatchCapture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Batch download response for the batch capture of transactions.
    /// Encoded/decoded by serializers as &quot;AKCP&quot;.
    /// </summary>
    [EnumMember(Value = "AKCP")]
    [IsoId("_lwb9tw0aEeqUVL7sB4m7NA")]
    [Description(@"Batch download response for the batch capture of transactions.")]
    CaptureResponse = DataSetCategoryCode.CaptureResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data needed to create a terminal management sub-domain.
    /// Encoded/decoded by serializers as &quot;DLGT&quot;.
    /// </summary>
    [EnumMember(Value = "DLGT")]
    [IsoId("_lwb9uQ0aEeqUVL7sB4m7NA")]
    [Description(@"Data needed to create a terminal management sub-domain.")]
    DelegationData = DataSetCategoryCode.DelegationData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration of management plan in the point of interaction.
    /// Encoded/decoded by serializers as &quot;MGTP&quot;.
    /// </summary>
    [EnumMember(Value = "MGTP")]
    [IsoId("_lwb9uw0aEeqUVL7sB4m7NA")]
    [Description(@"Configuration of management plan in the point of interaction.")]
    ManagementPlan = DataSetCategoryCode.ManagementPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;MRPR&quot;.
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_lwb9vQ0aEeqUVL7sB4m7NA")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = DataSetCategoryCode.MerchantParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// Encoded/decoded by serializers as &quot;SCPR&quot;.
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_lwb9vw0aEeqUVL7sB4m7NA")]
    [Description(
        @"Point of interaction parameters related to the security of software application and application protocol."
    )]
    SecurityParameters = DataSetCategoryCode.SecurityParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as &quot;SWPK&quot;.
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_lwb9wQ0aEeqUVL7sB4m7NA")]
    [Description(@"Software module.")]
    SoftwareModule = DataSetCategoryCode.SoftwareModule, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Report of software configuration and parameter status.
    /// Encoded/decoded by serializers as &quot;STRP&quot;.
    /// </summary>
    [EnumMember(Value = "STRP")]
    [IsoId("_lwb9ww0aEeqUVL7sB4m7NA")]
    [Description(@"Report of software configuration and parameter status.")]
    StatusReport = DataSetCategoryCode.StatusReport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as &quot;TRPR&quot;.
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_lwb9xQ0aEeqUVL7sB4m7NA")]
    [Description(
        @"Point of interaction parameters attached to the terminal as serial number or physical capabilities."
    )]
    TerminalParameters = DataSetCategoryCode.TerminalParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.
    /// Encoded/decoded by serializers as &quot;VDPR&quot;.
    /// </summary>
    [EnumMember(Value = "VDPR")]
    [IsoId("_lwb9xw0aEeqUVL7sB4m7NA")]
    [Description(
        @"Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities."
    )]
    VendorParameters = DataSetCategoryCode.VendorParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any combination of configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;PARA&quot;.
    /// </summary>
    [EnumMember(Value = "PARA")]
    [IsoId("_lwb9yQ0aEeqUVL7sB4m7NA")]
    [Description(
        @"Any combination of configuration parameters for the point of interaction (POI)."
    )]
    Parameters = DataSetCategoryCode.Parameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as &quot;TMSP&quot;.
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_lwb9yw0aEeqUVL7sB4m7NA")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters = DataSetCategoryCode.TMSProtocolParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_lwb9zQ0aEeqUVL7sB4m7NA")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters = DataSetCategoryCode.CertificateParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any repository used for recording log traces.
    /// Encoded/decoded by serializers as &quot;LOGF&quot;.
    /// </summary>
    [EnumMember(Value = "LOGF")]
    [IsoId("_lwb9zw0aEeqUVL7sB4m7NA")]
    [Description(@"Any repository used for recording log traces.")]
    LogFile = DataSetCategoryCode.LogFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trigger for CertificateManagementRequest.
    /// Encoded/decoded by serializers as &quot;CMRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CMRQ")]
    [IsoId("_lwb90Q0aEeqUVL7sB4m7NA")]
    [Description(@"Trigger for CertificateManagementRequest.")]
    CertificateManagementRequest = DataSetCategoryCode.CertificateManagementRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Media file managed by an application of the POI.
    /// Encoded/decoded by serializers as &quot;MDFL&quot;.
    /// </summary>
    [EnumMember(Value = "MDFL")]
    [IsoId("_w7sVMQ0aEeqUVL7sB4m7NA")]
    [Description(@"Media file managed by an application of the POI.")]
    MediaFile = DataSetCategoryCode.MediaFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Software Application or module of the POI.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_x4JWYQ0aEeqUVL7sB4m7NA")]
    [Description(@"Software Application or module of the POI.")]
    SoftwareApplication = DataSetCategoryCode.SoftwareApplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration file relevant for the POI.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_zIHwgQ0aEeqUVL7sB4m7NA")]
    [Description(@"Configuration file relevant for the POI.")]
    ConfigurationFile = DataSetCategoryCode.ConfigurationFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Report file generated by the POI.
    /// Encoded/decoded by serializers as &quot;RPFL&quot;.
    /// </summary>
    [EnumMember(Value = "RPFL")]
    [IsoId("_z52vcQ0aEeqUVL7sB4m7NA")]
    [Description(@"Report file generated by the POI.")]
    ReportFile = DataSetCategoryCode.ReportFile, // same ordinal as derivation source for type conversions
}
