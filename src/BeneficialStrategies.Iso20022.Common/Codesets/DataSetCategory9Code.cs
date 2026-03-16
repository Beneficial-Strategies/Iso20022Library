// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Category of data set to transfer to the point of interaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_F1kQ8Y3dEeW32YMP0mBeyw")]
[Description(@"Category of data set to transfer to the point of interaction.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory9Code
{
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;AQPR&quot;.
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_GBoXAY3dEeW32YMP0mBeyw")]
    [Description(
        @"Acquirer specific configuration parameters for the point of interaction (POI) system."
    )]
    AcquirerParameters = DataSetCategoryCode.AcquirerParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_GBoXA43dEeW32YMP0mBeyw")]
    [Description(
        @"Payment application specific configuration parameters for the point of interaction (POI) system."
    )]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Batch upload of transaction data (data capture of a group of transactions).
    /// Encoded/decoded by serializers as &quot;TXCP&quot;.
    /// </summary>
    [EnumMember(Value = "TXCP")]
    [IsoId("_GBoXBY3dEeW32YMP0mBeyw")]
    [Description(@"Batch upload of transaction data (data capture of a group of transactions).")]
    BatchCapture = DataSetCategoryCode.BatchCapture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Batch download response for the batch capture of transactions.
    /// Encoded/decoded by serializers as &quot;AKCP&quot;.
    /// </summary>
    [EnumMember(Value = "AKCP")]
    [IsoId("_GBoXB43dEeW32YMP0mBeyw")]
    [Description(@"Batch download response for the batch capture of transactions.")]
    CaptureResponse = DataSetCategoryCode.CaptureResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data needed to create a terminal management sub-domain.
    /// Encoded/decoded by serializers as &quot;DLGT&quot;.
    /// </summary>
    [EnumMember(Value = "DLGT")]
    [IsoId("_GBoXCY3dEeW32YMP0mBeyw")]
    [Description(@"Data needed to create a terminal management sub-domain.")]
    DelegationData = DataSetCategoryCode.DelegationData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration of management plan in the point of interaction.
    /// Encoded/decoded by serializers as &quot;MGTP&quot;.
    /// </summary>
    [EnumMember(Value = "MGTP")]
    [IsoId("_GBoXC43dEeW32YMP0mBeyw")]
    [Description(@"Configuration of management plan in the point of interaction.")]
    ManagementPlan = DataSetCategoryCode.ManagementPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;MRPR&quot;.
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_GBoXDY3dEeW32YMP0mBeyw")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = DataSetCategoryCode.MerchantParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// Encoded/decoded by serializers as &quot;SCPR&quot;.
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_GBoXD43dEeW32YMP0mBeyw")]
    [Description(
        @"Point of interaction parameters related to the security of software application and application protocol."
    )]
    SecurityParameters = DataSetCategoryCode.SecurityParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as &quot;SWPK&quot;.
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_GBoXEY3dEeW32YMP0mBeyw")]
    [Description(@"Software module.")]
    SoftwareModule = DataSetCategoryCode.SoftwareModule, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Report of software configuration and parameter status.
    /// Encoded/decoded by serializers as &quot;STRP&quot;.
    /// </summary>
    [EnumMember(Value = "STRP")]
    [IsoId("_GBoXE43dEeW32YMP0mBeyw")]
    [Description(@"Report of software configuration and parameter status.")]
    StatusReport = DataSetCategoryCode.StatusReport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as &quot;TRPR&quot;.
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_GBoXFY3dEeW32YMP0mBeyw")]
    [Description(
        @"Point of interaction parameters attached to the terminal as serial number or physical capabilities."
    )]
    TerminalParameters = DataSetCategoryCode.TerminalParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.
    /// Encoded/decoded by serializers as &quot;VDPR&quot;.
    /// </summary>
    [EnumMember(Value = "VDPR")]
    [IsoId("_GBoXF43dEeW32YMP0mBeyw")]
    [Description(
        @"Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities."
    )]
    VendorParameters = DataSetCategoryCode.VendorParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any combination of configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;PARA&quot;.
    /// </summary>
    [EnumMember(Value = "PARA")]
    [IsoId("_GBoXGY3dEeW32YMP0mBeyw")]
    [Description(
        @"Any combination of configuration parameters for the point of interaction (POI)."
    )]
    Parameters = DataSetCategoryCode.Parameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as &quot;TMSP&quot;.
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_Lx4eYY3dEeW32YMP0mBeyw")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters = DataSetCategoryCode.TMSProtocolParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_cpAMgY3dEeW32YMP0mBeyw")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters = DataSetCategoryCode.CertificateParameters, // same ordinal as derivation source for type conversions
}
