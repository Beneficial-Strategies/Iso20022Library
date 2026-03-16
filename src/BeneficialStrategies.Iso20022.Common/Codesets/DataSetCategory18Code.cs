// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Category of data set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zT5JgXC7Ee2bmOA3bkVsMg")]
[Description(@"Category of data set.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory18Code
{
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;AQPR&quot;.
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_zbWcYXC7Ee2bmOA3bkVsMg")]
    [Description(
        @"Acquirer specific configuration parameters for the point of interaction (POI) system."
    )]
    AcquirerParameters = DataSetCategoryCode.AcquirerParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_zbWcY3C7Ee2bmOA3bkVsMg")]
    [Description(
        @"Payment application specific configuration parameters for the point of interaction (POI) system."
    )]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Batch upload of transaction data (data capture of a group of transactions).
    /// Encoded/decoded by serializers as &quot;TXCP&quot;.
    /// </summary>
    [EnumMember(Value = "TXCP")]
    [IsoId("_zbWcZXC7Ee2bmOA3bkVsMg")]
    [Description(@"Batch upload of transaction data (data capture of a group of transactions).")]
    BatchCapture = DataSetCategoryCode.BatchCapture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Batch download response for the batch capture of transactions.
    /// Encoded/decoded by serializers as &quot;AKCP&quot;.
    /// </summary>
    [EnumMember(Value = "AKCP")]
    [IsoId("_zbWcZ3C7Ee2bmOA3bkVsMg")]
    [Description(@"Batch download response for the batch capture of transactions.")]
    CaptureResponse = DataSetCategoryCode.CaptureResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data needed to create a terminal management sub-domain.
    /// Encoded/decoded by serializers as &quot;DLGT&quot;.
    /// </summary>
    [EnumMember(Value = "DLGT")]
    [IsoId("_zbWcaXC7Ee2bmOA3bkVsMg")]
    [Description(@"Data needed to create a terminal management sub-domain.")]
    DelegationData = DataSetCategoryCode.DelegationData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration of management plan in the point of interaction.
    /// Encoded/decoded by serializers as &quot;MGTP&quot;.
    /// </summary>
    [EnumMember(Value = "MGTP")]
    [IsoId("_zbWca3C7Ee2bmOA3bkVsMg")]
    [Description(@"Configuration of management plan in the point of interaction.")]
    ManagementPlan = DataSetCategoryCode.ManagementPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;MRPR&quot;.
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_zbWcbXC7Ee2bmOA3bkVsMg")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = DataSetCategoryCode.MerchantParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// Encoded/decoded by serializers as &quot;SCPR&quot;.
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_zbWcb3C7Ee2bmOA3bkVsMg")]
    [Description(
        @"Point of interaction parameters related to the security of software application and application protocol."
    )]
    SecurityParameters = DataSetCategoryCode.SecurityParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as &quot;SWPK&quot;.
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_zbWccXC7Ee2bmOA3bkVsMg")]
    [Description(@"Software module.")]
    SoftwareModule = DataSetCategoryCode.SoftwareModule, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Report of software configuration and parameter status.
    /// Encoded/decoded by serializers as &quot;STRP&quot;.
    /// </summary>
    [EnumMember(Value = "STRP")]
    [IsoId("_zbWcc3C7Ee2bmOA3bkVsMg")]
    [Description(@"Report of software configuration and parameter status.")]
    StatusReport = DataSetCategoryCode.StatusReport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as &quot;TRPR&quot;.
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_zbWcdXC7Ee2bmOA3bkVsMg")]
    [Description(
        @"Point of interaction parameters attached to the terminal as serial number or physical capabilities."
    )]
    TerminalParameters = DataSetCategoryCode.TerminalParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.
    /// Encoded/decoded by serializers as &quot;VDPR&quot;.
    /// </summary>
    [EnumMember(Value = "VDPR")]
    [IsoId("_zbWcd3C7Ee2bmOA3bkVsMg")]
    [Description(
        @"Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities."
    )]
    VendorParameters = DataSetCategoryCode.VendorParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any combination of configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;PARA&quot;.
    /// </summary>
    [EnumMember(Value = "PARA")]
    [IsoId("_zbWceXC7Ee2bmOA3bkVsMg")]
    [Description(
        @"Any combination of configuration parameters for the point of interaction (POI)."
    )]
    Parameters = DataSetCategoryCode.Parameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as &quot;TMSP&quot;.
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_zbWce3C7Ee2bmOA3bkVsMg")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters = DataSetCategoryCode.TMSProtocolParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_zbWcfXC7Ee2bmOA3bkVsMg")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters = DataSetCategoryCode.CertificateParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any repository used for recording log traces.
    /// Encoded/decoded by serializers as &quot;LOGF&quot;.
    /// </summary>
    [EnumMember(Value = "LOGF")]
    [IsoId("_zbWcf3C7Ee2bmOA3bkVsMg")]
    [Description(@"Any repository used for recording log traces.")]
    LogFile = DataSetCategoryCode.LogFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trigger for CertificateManagementRequest.
    /// Encoded/decoded by serializers as &quot;CMRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CMRQ")]
    [IsoId("_zbWcgXC7Ee2bmOA3bkVsMg")]
    [Description(@"Trigger for CertificateManagementRequest.")]
    CertificateManagementRequest = DataSetCategoryCode.CertificateManagementRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Media file managed by an application of the POI.
    /// Encoded/decoded by serializers as &quot;MDFL&quot;.
    /// </summary>
    [EnumMember(Value = "MDFL")]
    [IsoId("_zbWcg3C7Ee2bmOA3bkVsMg")]
    [Description(@"Media file managed by an application of the POI.")]
    MediaFile = DataSetCategoryCode.MediaFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration file relevant for the POI.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_zbWchXC7Ee2bmOA3bkVsMg")]
    [Description(@"Configuration file relevant for the POI.")]
    ConfigurationFile = DataSetCategoryCode.ConfigurationFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Report file generated by the POI.
    /// Encoded/decoded by serializers as &quot;RPFL&quot;.
    /// </summary>
    [EnumMember(Value = "RPFL")]
    [IsoId("_zbWch3C7Ee2bmOA3bkVsMg")]
    [Description(@"Report file generated by the POI.")]
    ReportFile = DataSetCategoryCode.ReportFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Parameters related to the Sale to POI protocol.
    /// Encoded/decoded by serializers as &quot;SAPR&quot;.
    /// </summary>
    [EnumMember(Value = "SAPR")]
    [IsoId("_-eojoXC7Ee2bmOA3bkVsMg")]
    [Description(@"Parameters related to the Sale to POI protocol.")]
    SaleToPOIProtocolParameters = DataSetCategoryCode.SaleToPOIProtocolParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service Provider specific parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;SPRP&quot;.
    /// </summary>
    [EnumMember(Value = "SPRP")]
    [IsoId("__x_o8XC7Ee2bmOA3bkVsMg")]
    [Description(
        @"Service Provider specific parameters for the point of interaction (POI) system."
    )]
    ServiceProviderParameters = DataSetCategoryCode.ServiceProviderParameters, // same ordinal as derivation source for type conversions
}
