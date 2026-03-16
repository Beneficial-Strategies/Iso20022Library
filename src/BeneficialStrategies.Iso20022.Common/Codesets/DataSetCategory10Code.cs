// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Maintenance services provided by a terminal manager.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ue5BEY35EeWRwov1g9WL_A")]
[Description(@"Maintenance services provided by a terminal manager.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory10Code
{
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;AQPR&quot;.
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_UpxbYY35EeWRwov1g9WL_A")]
    [Description(
        @"Acquirer specific configuration parameters for the point of interaction (POI) system."
    )]
    AcquirerParameters = DataSetCategoryCode.AcquirerParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_UpxbY435EeWRwov1g9WL_A")]
    [Description(
        @"Payment application specific configuration parameters for the point of interaction (POI) system."
    )]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The terminal manager is the master.
    /// Encoded/decoded by serializers as &quot;MTMG&quot;.
    /// </summary>
    [EnumMember(Value = "MTMG")]
    [IsoId("_UpxbZY35EeWRwov1g9WL_A")]
    [Description(@"The terminal manager is the master.")]
    MasterTerminalManager = DataSetCategoryCode.MasterTerminalManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;MRPR&quot;.
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_UpxbZ435EeWRwov1g9WL_A")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = DataSetCategoryCode.MerchantParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Monitoring of the terminal estate.
    /// Encoded/decoded by serializers as &quot;MTOR&quot;.
    /// </summary>
    [EnumMember(Value = "MTOR")]
    [IsoId("_UpxbaY35EeWRwov1g9WL_A")]
    [Description(@"Monitoring of the terminal estate.")]
    Monitoring = DataSetCategoryCode.Monitoring, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// Encoded/decoded by serializers as &quot;SCPR&quot;.
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_Upxba435EeWRwov1g9WL_A")]
    [Description(
        @"Point of interaction parameters related to the security of software application and application protocol."
    )]
    SecurityParameters = DataSetCategoryCode.SecurityParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as &quot;SWPK&quot;.
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_UpxbbY35EeWRwov1g9WL_A")]
    [Description(@"Software module.")]
    SoftwareModule = DataSetCategoryCode.SoftwareModule, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as &quot;TRPR&quot;.
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_Upxbb435EeWRwov1g9WL_A")]
    [Description(
        @"Point of interaction parameters attached to the terminal as serial number or physical capabilities."
    )]
    TerminalParameters = DataSetCategoryCode.TerminalParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_YHlmEY35EeWRwov1g9WL_A")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters = DataSetCategoryCode.CertificateParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as &quot;TMSP&quot;.
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_Yhq6AY35EeWRwov1g9WL_A")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters = DataSetCategoryCode.TMSProtocolParameters, // same ordinal as derivation source for type conversions
}
