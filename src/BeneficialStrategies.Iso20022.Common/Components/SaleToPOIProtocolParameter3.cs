// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters to communicate with a sale system.
/// </summary>
[IsoId("_tmvvQXIVEe2OqYulmHWukQ")]
[DisplayName("Sale To POI Protocol Parameter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SaleToPOIProtocolParameter3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SaleToPOIProtocolParameter3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SaleToPOIProtocolParameter3( TerminalManagementAction3Code reqActionType,System.String reqVersion,System.String reqHostIdentification )
    {
        ActionType = reqActionType;
        Version = reqVersion;
        HostIdentification = reqHostIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_ttnzUXIVEe2OqYulmHWukQ")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction3Code ActionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementAction3Code ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction3Code ActionType { get; init; } 
    #else
    public TerminalManagementAction3Code ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_ttnzU3IVEe2OqYulmHWukQ")]
    [DisplayName("Merchant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntId")]
    #endif
    [IsoXmlTag("MrchntId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation26? MerchantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation26? MerchantIdentification { get; init; } 
    #else
    public Organisation26? MerchantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the parameters.
    /// </summary>
    [IsoId("_ttnzVXIVEe2OqYulmHWukQ")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax256Text Version { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Version { get; init; } 
    #else
    public System.String Version { get; set; } 
    #endif
    
    /// <summary>
    /// Identification used to retrieve HostCommunicationParameters.
    /// </summary>
    [IsoId("_ttnzV3IVEe2OqYulmHWukQ")]
    [DisplayName("Host Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstId")]
    #endif
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text HostIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String HostIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String HostIdentification { get; init; } 
    #else
    public System.String HostIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the POI during communication with sale system.
    /// </summary>
    [IsoId("_ttnzWXIVEe2OqYulmHWukQ")]
    [DisplayName("Merchant POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntPOIId")]
    #endif
    [IsoXmlTag("MrchntPOIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MerchantPOIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MerchantPOIIdentification { get; init; } 
    #else
    public System.String? MerchantPOIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the SaleSystem connected to the POI.
    /// </summary>
    [IsoId("_ttnzW3IVEe2OqYulmHWukQ")]
    [DisplayName("Sale Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleId")]
    #endif
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleIdentification { get; init; } 
    #else
    public System.String? SaleIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identify a message that a Sale system could send to the POI system.
    /// </summary>
    [IsoId("_3C5rMHIWEe2OqYulmHWukQ")]
    [DisplayName("Allowed Sale Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwdSaleMsg")]
    #endif
    [IsoXmlTag("AllwdSaleMsg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RetailerMessage1Code? AllowedSaleMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerMessage1Code? AllowedSaleMessage { get; init; } 
    #else
    public RetailerMessage1Code? AllowedSaleMessage { get; set; } 
    #endif
    
    /// <summary>
    /// Identify a message that a POI system could send to the Sale system.
    /// </summary>
    [IsoId("_js7fkHIXEe2OqYulmHWukQ")]
    [DisplayName("Allowed POI Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwdPOIMsg")]
    #endif
    [IsoXmlTag("AllwdPOIMsg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RetailerMessage1Code? AllowedPOIMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerMessage1Code? AllowedPOIMessage { get; init; } 
    #else
    public RetailerMessage1Code? AllowedPOIMessage { get; set; } 
    #endif
    
    /// <summary>
    /// Identify a service that a POI system could support to the Sale system.
    /// </summary>
    [IsoId("_RC-scHIYEe2OqYulmHWukQ")]
    [DisplayName("Allowed POI Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwdPOISvc")]
    #endif
    [IsoXmlTag("AllwdPOISvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RetailerService2Code? AllowedPOIService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerService2Code? AllowedPOIService { get; init; } 
    #else
    public RetailerService2Code? AllowedPOIService { get; set; } 
    #endif
    
    /// <summary>
    /// Identify a device request that a Sale system could ask to the POI system.
    /// </summary>
    [IsoId("__D-60HIYEe2OqYulmHWukQ")]
    [DisplayName("Allowed Sale Device")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwdSaleDvc")]
    #endif
    [IsoXmlTag("AllwdSaleDvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RetailerService8Code? AllowedSaleDevice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerService8Code? AllowedSaleDevice { get; init; } 
    #else
    public RetailerService8Code? AllowedSaleDevice { get; set; } 
    #endif
    
    /// <summary>
    /// List of types that the receiver supports and that the sender could use as type of an ExternallyDefinedData message component.
    /// </summary>
    [IsoId("_ttnzXXIVEe2OqYulmHWukQ")]
    [DisplayName("Externally Type Supported")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlyTpSpprtd")]
    #endif
    [IsoXmlTag("XtrnlyTpSpprtd")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? ExternallyTypeSupported { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExternallyTypeSupported { get; init; } 
    #else
    public System.String? ExternallyTypeSupported { get; set; } 
    #endif
    
    
    #nullable disable
    
}
