// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of component belonging to a POI (Point of Interaction) Terminal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2WBokY0SEeWRYffwL7E13A")]
[Description(@"Type of component belonging to a POI (Point of Interaction) Terminal.")]
[DerivedFrom(typeof(POIComponentTypeCode))]
public enum POIComponentType4Code
{
    /// <summary>
    /// Parameters for acquirer interface of the point of interaction, including acquirer host configuration parameters.
    /// Encoded/decoded by serializers as &quot;AQPP&quot;.
    /// </summary>
    [EnumMember(Value = "AQPP")]
    [IsoId("_2gdW8Y0SEeWRYffwL7E13A")]
    [Description(@"Parameters for acquirer interface of the point of interaction, including acquirer host configuration parameters.")]
    AcquirerProtocolParameters = POIComponentTypeCode.AcquirerProtocolParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Parameters of a payment application running on the point of interaction.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_2gdW840SEeWRYffwL7E13A")]
    [Description(@"Parameters of a payment application running on the point of interaction.")]
    ApplicationParameters = POIComponentTypeCode.ApplicationParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// Encoded/decoded by serializers as &quot;TLPR&quot;.
    /// </summary>
    [EnumMember(Value = "TLPR")]
    [IsoId("_2gdW9Y0SEeWRYffwL7E13A")]
    [Description(@"Manufacturer configuration parameters of the point of interaction.")]
    TerminalParameters = POIComponentTypeCode.TerminalParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security parameters of the point of interaction.
    /// Encoded/decoded by serializers as &quot;SCPR&quot;.
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_2gdW940SEeWRYffwL7E13A")]
    [Description(@"Security parameters of the point of interaction.")]
    SecurityParameters = POIComponentTypeCode.SecurityParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment server of a point of interaction system.
    /// Encoded/decoded by serializers as &quot;SERV&quot;.
    /// </summary>
    [EnumMember(Value = "SERV")]
    [IsoId("_2gdW-Y0SEeWRYffwL7E13A")]
    [Description(@"Payment server of a point of interaction system.")]
    Server = POIComponentTypeCode.Server, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment terminal point of interaction.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_2gdW-40SEeWRYffwL7E13A")]
    [Description(@"Payment terminal point of interaction.")]
    Terminal = POIComponentTypeCode.Terminal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device sub-component of a component of the point of interaction.
    /// Encoded/decoded by serializers as &quot;DVCE&quot;.
    /// </summary>
    [EnumMember(Value = "DVCE")]
    [IsoId("_2gdW_Y0SEeWRYffwL7E13A")]
    [Description(@"Device sub-component of a component of the point of interaction.")]
    Device = POIComponentTypeCode.Device, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security module.
    /// Encoded/decoded by serializers as &quot;SECM&quot;.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_2gdW_40SEeWRYffwL7E13A")]
    [Description(@"Security module.")]
    SecureModule = POIComponentTypeCode.SecureModule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment application software.
    /// Encoded/decoded by serializers as &quot;APLI&quot;.
    /// </summary>
    [EnumMember(Value = "APLI")]
    [IsoId("_2gdXAY0SEeWRYffwL7E13A")]
    [Description(@"Payment application software.")]
    PaymentApplication = POIComponentTypeCode.PaymentApplication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;EMVK&quot;.
    /// </summary>
    [EnumMember(Value = "EMVK")]
    [IsoId("_2gdXA40SEeWRYffwL7E13A")]
    [Description(@"EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).")]
    EMVKernel = POIComponentTypeCode.EMVKernel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;EMVO&quot;.
    /// </summary>
    [EnumMember(Value = "EMVO")]
    [IsoId("_2gdXBY0SEeWRYffwL7E13A")]
    [Description(@"EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).")]
    EMVLevel1 = POIComponentTypeCode.EMVLevel1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Software module of the point of interaction.
    /// Encoded/decoded by serializers as &quot;MDWR&quot;.
    /// </summary>
    [EnumMember(Value = "MDWR")]
    [IsoId("_2gdXB40SEeWRYffwL7E13A")]
    [Description(@"Software module of the point of interaction.")]
    Middleware = POIComponentTypeCode.Middleware, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Driver module of the point of interaction.
    /// Encoded/decoded by serializers as &quot;DRVR&quot;.
    /// </summary>
    [EnumMember(Value = "DRVR")]
    [IsoId("_2gdXCY0SEeWRYffwL7E13A")]
    [Description(@"Driver module of the point of interaction.")]
    Driver = POIComponentTypeCode.Driver, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Software that manages hardware to provide common services to the applications.
    /// Encoded/decoded by serializers as &quot;OPST&quot;.
    /// </summary>
    [EnumMember(Value = "OPST")]
    [IsoId("_2gdXC40SEeWRYffwL7E13A")]
    [Description(@"Software that manages hardware to provide common services to the applications.")]
    OperatingSystem = POIComponentTypeCode.OperatingSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;MRPR&quot;.
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_2gdXDY0SEeWRYffwL7E13A")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = POIComponentTypeCode.MerchantParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_6Ira0Y0SEeWRYffwL7E13A")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters = POIComponentTypeCode.CertificateParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as &quot;TMSP&quot;.
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_6XJUoY0SEeWRYffwL7E13A")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters = POIComponentTypeCode.TMSProtocolParameters, // same ordinal as derivation source for type conversions
    
}
