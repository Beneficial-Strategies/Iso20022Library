// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Maintenance service to delegate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_g3O-gdqhEeearpaEPXv9UA")]
[Description(@"Maintenance service to delegate.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory13Code
{
    /// <summary>
    /// Configuration parameters of the payment acquirer protocol.
    /// Encoded/decoded by serializers as &quot;ACQP&quot;.
    /// </summary>
    [EnumMember(Value = "ACQP")]
    [IsoId("_g_5LQdqhEeearpaEPXv9UA")]
    [Description(@"Configuration parameters of the payment acquirer protocol.")]
    AcquirerProtocolParameters = DataSetCategoryCode.AcquirerProtocolParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_g_5LQ9qhEeearpaEPXv9UA")]
    [Description(
        @"Payment application specific configuration parameters for the point of interaction (POI) system."
    )]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Creation of a subset of the configuration parameters of an application.
    /// Encoded/decoded by serializers as &quot;APSB&quot;.
    /// </summary>
    [EnumMember(Value = "APSB")]
    [IsoId("_g_5LRdqhEeearpaEPXv9UA")]
    [Description(@"Creation of a subset of the configuration parameters of an application.")]
    ApplicationParametersSubsetCreation = DataSetCategoryCode.ApplicationParametersSubsetCreation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Download of cryptographic keys with the related information.
    /// Encoded/decoded by serializers as &quot;KDWL&quot;.
    /// </summary>
    [EnumMember(Value = "KDWL")]
    [IsoId("_g_5LR9qhEeearpaEPXv9UA")]
    [Description(@"Download of cryptographic keys with the related information.")]
    KeyDownload = DataSetCategoryCode.KeyDownload, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Activate, deactivate or revoke loaded cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KMGT&quot;.
    /// </summary>
    [EnumMember(Value = "KMGT")]
    [IsoId("_g_5LSdqhEeearpaEPXv9UA")]
    [Description(@"Activate, deactivate or revoke loaded cryptographic keys.")]
    KeyManagement = DataSetCategoryCode.KeyManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reporting on activity, status and error of a point of interaction.
    /// Encoded/decoded by serializers as &quot;RPRT&quot;.
    /// </summary>
    [EnumMember(Value = "RPRT")]
    [IsoId("_g_5LS9qhEeearpaEPXv9UA")]
    [Description(@"Reporting on activity, status and error of a point of interaction.")]
    Reporting = DataSetCategoryCode.Reporting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as &quot;SWPK&quot;.
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_g_5LTdqhEeearpaEPXv9UA")]
    [Description(@"Software module.")]
    SoftwareModule = DataSetCategoryCode.SoftwareModule, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as &quot;TMSP&quot;.
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_g_5LT9qhEeearpaEPXv9UA")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters = DataSetCategoryCode.TMSProtocolParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;MRPR&quot;.
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_g_5LUdqhEeearpaEPXv9UA")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = DataSetCategoryCode.MerchantParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as &quot;TRPR&quot;.
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_g_5LU9qhEeearpaEPXv9UA")]
    [Description(
        @"Point of interaction parameters attached to the terminal as serial number or physical capabilities."
    )]
    TerminalParameters = DataSetCategoryCode.TerminalParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_g_5LVdqhEeearpaEPXv9UA")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters = DataSetCategoryCode.CertificateParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Component of the Sale system.
    /// Encoded/decoded by serializers as &quot;SACP&quot;.
    /// </summary>
    [EnumMember(Value = "SACP")]
    [IsoId("_ixqq4dqhEeearpaEPXv9UA")]
    [Description(@"Component of the Sale system.")]
    SaleComponent = DataSetCategoryCode.SaleComponent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Parameters related to the Sale to POI protocol.
    /// Encoded/decoded by serializers as &quot;SAPR&quot;.
    /// </summary>
    [EnumMember(Value = "SAPR")]
    [IsoId("_i2sU0dqhEeearpaEPXv9UA")]
    [Description(@"Parameters related to the Sale to POI protocol.")]
    SaleToPOIProtocolParameters = DataSetCategoryCode.SaleToPOIProtocolParameters, // same ordinal as derivation source for type conversions
}
