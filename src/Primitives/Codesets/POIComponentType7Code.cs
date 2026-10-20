// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of component belonging to a POI (Point of Interaction) Terminal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DvXzQZxJEe-Jl6tBAvMHqA")]
[Description(@"Type of component belonging to a POI (Point of Interaction) Terminal.")]
[DerivedFrom(typeof(POIComponentTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<POIComponentType7Code>))]
public enum POIComponentType7Code
{
    /// <summary>
    /// Payment application software.
    /// Encoded/decoded by serializers as &quot;APLI&quot;.
    /// </summary>
    [EnumMember(Value = "APLI")]
    [IsoId("_DwU1kZxJEe-Jl6tBAvMHqA")]
    [Description(@"Payment application software.")]
    PaymentApplication = POIComponentTypeCode.PaymentApplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Parameters of a payment application running on the point of interaction.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_DwU1g5xJEe-Jl6tBAvMHqA")]
    [Description(
        @"Parameters of a payment application running on the point of interaction."
    )]
    ApplicationParameters = POIComponentTypeCode.ApplicationParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Parameters for acquirer interface of the point of interaction, including acquirer host configuration parameters.
    /// Encoded/decoded by serializers as &quot;AQPP&quot;.
    /// </summary>
    [EnumMember(Value = "AQPP")]
    [IsoId("_DwU1gZxJEe-Jl6tBAvMHqA")]
    [Description(
        @"Parameters for acquirer interface of the point of interaction, including acquirer host configuration parameters."
    )]
    AcquirerProtocolParameters = POIComponentTypeCode.AcquirerProtocolParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration file relevant for the POI.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_DwU1rZxJEe-Jl6tBAvMHqA")]
    [Description(@"Configuration file relevant for the POI.")]
    ConfigurationFile = POIComponentTypeCode.ConfigurationFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_DwU1n5xJEe-Jl6tBAvMHqA")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters = POIComponentTypeCode.CertificateParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Driver module of the point of interaction.
    /// Encoded/decoded by serializers as &quot;DRVR&quot;.
    /// </summary>
    [EnumMember(Value = "DRVR")]
    [IsoId("_DwU1mZxJEe-Jl6tBAvMHqA")]
    [Description(@"Driver module of the point of interaction.")]
    Driver = POIComponentTypeCode.Driver, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Device sub-component of a component of the point of interaction.
    /// Encoded/decoded by serializers as &quot;DVCE&quot;.
    /// </summary>
    [EnumMember(Value = "DVCE")]
    [IsoId("_DwU1jZxJEe-Jl6tBAvMHqA")]
    [Description(@"Device sub-component of a component of the point of interaction.")]
    Device = POIComponentTypeCode.Device, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EMV application kernel.
    /// Encoded/decoded by serializers as &quot;EMVK&quot;.
    /// </summary>
    [EnumMember(Value = "EMVK")]
    [IsoId("_DwU1k5xJEe-Jl6tBAvMHqA")]
    [Description(
        @"EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa)."
    )]
    EMVKernel = POIComponentTypeCode.EMVKernel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EMV physical interface.
    /// Encoded/decoded by serializers as &quot;EMVO&quot;.
    /// </summary>
    [EnumMember(Value = "EMVO")]
    [IsoId("_DwU1lZxJEe-Jl6tBAvMHqA")]
    [Description(
        @"EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa)."
    )]
    EMVLevel1 = POIComponentTypeCode.EMVLevel1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any repository used for recording log traces.
    /// Encoded/decoded by serializers as &quot;LOGF&quot;.
    /// </summary>
    [EnumMember(Value = "LOGF")]
    [IsoId("_DwU1p5xJEe-Jl6tBAvMHqA")]
    [Description(@"Any repository used for recording log traces.")]
    LogFile = POIComponentTypeCode.LogFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Media file managed by an application of the POI.
    /// Encoded/decoded by serializers as &quot;MDFL&quot;.
    /// </summary>
    [EnumMember(Value = "MDFL")]
    [IsoId("_DwU1qZxJEe-Jl6tBAvMHqA")]
    [Description(@"Media file managed by an application of the POI.")]
    MediaFile = POIComponentTypeCode.MediaFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Software module of the point of interaction.
    /// Encoded/decoded by serializers as &quot;MDWR&quot;.
    /// </summary>
    [EnumMember(Value = "MDWR")]
    [IsoId("_DwU1l5xJEe-Jl6tBAvMHqA")]
    [Description(@"Software module of the point of interaction.")]
    Middleware = POIComponentTypeCode.Middleware, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;MRPR&quot;.
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_DwU1nZxJEe-Jl6tBAvMHqA")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = POIComponentTypeCode.MerchantParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Software that manages hardware to provide common services to the applications.
    /// Encoded/decoded by serializers as &quot;OPST&quot;.
    /// </summary>
    [EnumMember(Value = "OPST")]
    [IsoId("_DwU1m5xJEe-Jl6tBAvMHqA")]
    [Description(
        @"Software that manages hardware to provide common services to the applications."
    )]
    OperatingSystem = POIComponentTypeCode.OperatingSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Probe used to monitor a feature on the POI.
    /// Encoded/decoded by serializers as &quot;PROB&quot;.
    /// </summary>
    [EnumMember(Value = "PROB")]
    [IsoId("_WJY3IaDhEe-MRKYsaX6JDg")]
    [Description(@"Probe used to monitor a feature on the POI.")]
    Probe = POIComponentTypeCode.Probe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Report file generated by the POI.
    /// Encoded/decoded by serializers as &quot;RPFL&quot;.
    /// </summary>
    [EnumMember(Value = "RPFL")]
    [IsoId("_DwU1r5xJEe-Jl6tBAvMHqA")]
    [Description(@"Report file generated by the POI.")]
    ReportFile = POIComponentTypeCode.ReportFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Component of the Sale system.
    /// Encoded/decoded by serializers as &quot;SACP&quot;.
    /// </summary>
    [EnumMember(Value = "SACP")]
    [IsoId("_DwU1o5xJEe-Jl6tBAvMHqA")]
    [Description(@"Component of the Sale system.")]
    SaleComponent = POIComponentTypeCode.SaleComponent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Parameters related to the Sale to POI protocol.
    /// Encoded/decoded by serializers as &quot;SAPR&quot;.
    /// </summary>
    [EnumMember(Value = "SAPR")]
    [IsoId("_DwU1pZxJEe-Jl6tBAvMHqA")]
    [Description(@"Parameters related to the Sale to POI protocol.")]
    SaleToPOIProtocolParameters = POIComponentTypeCode.SaleToPOIProtocolParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security parameters of the point of interaction.
    /// Encoded/decoded by serializers as &quot;SCPR&quot;.
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_DwU1h5xJEe-Jl6tBAvMHqA")]
    [Description(@"Security parameters of the point of interaction.")]
    SecurityParameters = POIComponentTypeCode.SecurityParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security module.
    /// Encoded/decoded by serializers as &quot;SECM&quot;.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_DwU1j5xJEe-Jl6tBAvMHqA")]
    [Description(@"Security module.")]
    SecureModule = POIComponentTypeCode.SecureModule, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment server of a point of interaction system.
    /// Encoded/decoded by serializers as &quot;SERV&quot;.
    /// </summary>
    [EnumMember(Value = "SERV")]
    [IsoId("_DwU1iZxJEe-Jl6tBAvMHqA")]
    [Description(@"Payment server of a point of interaction system.")]
    Server = POIComponentTypeCode.Server, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment or other software application.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_DwU1q5xJEe-Jl6tBAvMHqA")]
    [Description(@"Payment or other software application.")]
    Soft = POIComponentTypeCode.Soft, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment terminal point of interaction.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_DwU1i5xJEe-Jl6tBAvMHqA")]
    [Description(@"Payment terminal point of interaction.")]
    Terminal = POIComponentTypeCode.Terminal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// Encoded/decoded by serializers as &quot;TLPR&quot;.
    /// </summary>
    [EnumMember(Value = "TLPR")]
    [IsoId("_DwU1hZxJEe-Jl6tBAvMHqA")]
    [Description(@"Manufacturer configuration parameters of the point of interaction.")]
    TerminalParameters = POIComponentTypeCode.TerminalParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as &quot;TMSP&quot;.
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_DwU1oZxJEe-Jl6tBAvMHqA")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters = POIComponentTypeCode.TMSProtocolParameters, // same ordinal as derivation source for type conversions
}
