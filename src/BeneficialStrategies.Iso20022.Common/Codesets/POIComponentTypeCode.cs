// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Generic component type belonging to a POI (Point of Interaction) Terminal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVCuEAEcEeCQm6a_G2yO_w_-1692790704")]
[Description(@"Generic component type belonging to a POI (Point of Interaction) Terminal.")]
[Derivations(typeof(POIComponentType4Code),typeof(POIComponentType3Code),typeof(POIComponentType6Code),typeof(POIComponentType5Code),typeof(POIComponentType2Code),typeof(POIComponentType1Code))]
public enum POIComponentTypeCode
{
    /// <summary>
    /// Payment or other software application.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_TVCuEQEcEeCQm6a_G2yO_w_-1995847219")]
    [Description(@"Payment or other software application.")]
    Soft,
    
    /// <summary>
    /// EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;EMVK&quot;.
    /// </summary>
    [EnumMember(Value = "EMVK")]
    [IsoId("_TVMfAAEcEeCQm6a_G2yO_w_289163219")]
    [Description(@"EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).")]
    EMVKernel,
    
    /// <summary>
    /// EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;EMVO&quot;.
    /// </summary>
    [EnumMember(Value = "EMVO")]
    [IsoId("_TVMfAQEcEeCQm6a_G2yO_w_1211326529")]
    [Description(@"EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).")]
    EMVLevel1,
    
    /// <summary>
    /// Merchant interface.
    /// Encoded/decoded by serializers as &quot;MRIT&quot;.
    /// </summary>
    [EnumMember(Value = "MRIT")]
    [IsoId("_TVMfAgEcEeCQm6a_G2yO_w_910663924")]
    [Description(@"Merchant interface.")]
    MerchantInterface,
    
    /// <summary>
    /// Cardholder Interface.
    /// Encoded/decoded by serializers as &quot;CHIT&quot;.
    /// </summary>
    [EnumMember(Value = "CHIT")]
    [IsoId("_TVMfAwEcEeCQm6a_G2yO_w_275632078")]
    [Description(@"Cardholder Interface.")]
    CardholderInterface,
    
    /// <summary>
    /// Security module.
    /// Encoded/decoded by serializers as &quot;SECM&quot;.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_TVMfBAEcEeCQm6a_G2yO_w_-1110391711")]
    [Description(@"Security module.")]
    SecureModule,
    
    /// <summary>
    /// Personal identification number (or PIN) entry device (PED).
    /// Encoded/decoded by serializers as &quot;PEDV&quot;.
    /// </summary>
    [EnumMember(Value = "PEDV")]
    [IsoId("_TVMfBQEcEeCQm6a_G2yO_w_173447283")]
    [Description(@"Personal identification number (or PIN) entry device (PED).")]
    PINEntryDevice,
    
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;AQPR&quot;.
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_KVkWYX1DEeCF8NjrBemJWQ_-44649657")]
    [Description(@"Acquirer specific configuration parameters for the point of interaction (POI) system.")]
    AcquirerParameters,
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;MRPR&quot;.
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_KVkWYn1DEeCF8NjrBemJWQ_1600617778")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters,
    
    /// <summary>
    /// Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.
    /// Encoded/decoded by serializers as &quot;VDPR&quot;.
    /// </summary>
    [EnumMember(Value = "VDPR")]
    [IsoId("_KVkWY31DEeCF8NjrBemJWQ_-1155561076")]
    [Description(@"Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.")]
    VendorParameters,
    
    /// <summary>
    /// Parameters for acquirer interface of the point of interaction, including acquirer host configuration parameters.
    /// Encoded/decoded by serializers as &quot;AQPP&quot;.
    /// </summary>
    [EnumMember(Value = "AQPP")]
    [IsoId("_sPjUEb4pEeKkGaJ0UrThyA_535095901")]
    [Description(@"Parameters for acquirer interface of the point of interaction, including acquirer host configuration parameters.")]
    AcquirerProtocolParameters,
    
    /// <summary>
    /// Parameters of a payment application running on the point of interaction.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_sPjUEr4pEeKkGaJ0UrThyA_-955798156")]
    [Description(@"Parameters of a payment application running on the point of interaction.")]
    ApplicationParameters,
    
    /// <summary>
    /// Device sub-component of a component of the point of interaction.
    /// Encoded/decoded by serializers as &quot;DVCE&quot;.
    /// </summary>
    [EnumMember(Value = "DVCE")]
    [IsoId("_sPjUE74pEeKkGaJ0UrThyA_1891417940")]
    [Description(@"Device sub-component of a component of the point of interaction.")]
    Device,
    
    /// <summary>
    /// Driver module of the point of interaction.
    /// Encoded/decoded by serializers as &quot;DRVR&quot;.
    /// </summary>
    [EnumMember(Value = "DRVR")]
    [IsoId("_sPjUFL4pEeKkGaJ0UrThyA_1207919194")]
    [Description(@"Driver module of the point of interaction.")]
    Driver,
    
    /// <summary>
    /// Software module of the point of interaction.
    /// Encoded/decoded by serializers as &quot;MDWR&quot;.
    /// </summary>
    [EnumMember(Value = "MDWR")]
    [IsoId("_sPseAL4pEeKkGaJ0UrThyA_-2053152791")]
    [Description(@"Software module of the point of interaction.")]
    Middleware,
    
    /// <summary>
    /// Software that manages hardware to provide common services to the applications.
    /// Encoded/decoded by serializers as &quot;OPST&quot;.
    /// </summary>
    [EnumMember(Value = "OPST")]
    [IsoId("_sPseAb4pEeKkGaJ0UrThyA_-1277603711")]
    [Description(@"Software that manages hardware to provide common services to the applications.")]
    OperatingSystem,
    
    /// <summary>
    /// Payment application software.
    /// Encoded/decoded by serializers as &quot;APLI&quot;.
    /// </summary>
    [EnumMember(Value = "APLI")]
    [IsoId("_sPseAr4pEeKkGaJ0UrThyA_1717215001")]
    [Description(@"Payment application software.")]
    PaymentApplication,
    
    /// <summary>
    /// Security parameters of the point of interaction.
    /// Encoded/decoded by serializers as &quot;SCPR&quot;.
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_sPseA74pEeKkGaJ0UrThyA_-594612616")]
    [Description(@"Security parameters of the point of interaction.")]
    SecurityParameters,
    
    /// <summary>
    /// Payment server of a point of interaction system.
    /// Encoded/decoded by serializers as &quot;SERV&quot;.
    /// </summary>
    [EnumMember(Value = "SERV")]
    [IsoId("_sPseBL4pEeKkGaJ0UrThyA_583446276")]
    [Description(@"Payment server of a point of interaction system.")]
    Server,
    
    /// <summary>
    /// Payment terminal point of interaction.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_sPseBb4pEeKkGaJ0UrThyA_1775118014")]
    [Description(@"Payment terminal point of interaction.")]
    Terminal,
    
    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// Encoded/decoded by serializers as &quot;TLPR&quot;.
    /// </summary>
    [EnumMember(Value = "TLPR")]
    [IsoId("_sP2PAL4pEeKkGaJ0UrThyA_1206626140")]
    [Description(@"Manufacturer configuration parameters of the point of interaction.")]
    TerminalParameters,
    
    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_rt2wAI0SEeWRYffwL7E13A")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters,
    
    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as &quot;TMSP&quot;.
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_wBXzoI0SEeWRYffwL7E13A")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters,
    
    /// <summary>
    /// Parameters related to the Sale to POI protocol.
    /// Encoded/decoded by serializers as &quot;SAPR&quot;.
    /// </summary>
    [EnumMember(Value = "SAPR")]
    [IsoId("_94JI8NqhEeearpaEPXv9UA")]
    [Description(@"Parameters related to the Sale to POI protocol.")]
    SaleToPOIProtocolParameters,
    
    /// <summary>
    /// Component of the Sale system.
    /// Encoded/decoded by serializers as &quot;SACP&quot;.
    /// </summary>
    [EnumMember(Value = "SACP")]
    [IsoId("_BKIeINqiEeearpaEPXv9UA")]
    [Description(@"Component of the Sale system.")]
    SaleComponent,
    
    /// <summary>
    /// Any repository used for recording log traces.
    /// Encoded/decoded by serializers as &quot;LOGF&quot;.
    /// </summary>
    [EnumMember(Value = "LOGF")]
    [IsoId("_99S3kA1MEeqjM-rxn3HuXQ")]
    [Description(@"Any repository used for recording log traces.")]
    LogFile,
    
    /// <summary>
    /// Media file managed by an application of the POI.
    /// Encoded/decoded by serializers as &quot;MDFL&quot;.
    /// </summary>
    [EnumMember(Value = "MDFL")]
    [IsoId("_Uet2EQ1NEeqjM-rxn3HuXQ")]
    [Description(@"Media file managed by an application of the POI.")]
    MediaFile,
    
    /// <summary>
    /// Configuration file relevant for the POI.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_cJ9qgQ1NEeqjM-rxn3HuXQ")]
    [Description(@"Configuration file relevant for the POI.")]
    ConfigurationFile,
    
    /// <summary>
    /// Report file generated by the POI.
    /// Encoded/decoded by serializers as &quot;RPFL&quot;.
    /// </summary>
    [EnumMember(Value = "RPFL")]
    [IsoId("_f5dbEQ1NEeqjM-rxn3HuXQ")]
    [Description(@"Report file generated by the POI.")]
    ReportFile,
    
}
