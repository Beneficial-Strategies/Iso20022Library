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
/// Content of the acceptor configuration.
/// </summary>
[IsoId("_F5K64XIiEe299ZbWCkdR_w")]
[DisplayName("Acceptor Configuration Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorConfigurationContent12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// True if the whole configuration related to the terminal manager has to be replaced by the configuration included in the message content.
    /// </summary>
    [IsoId("_GDPc4XIiEe299ZbWCkdR_w")]
    [DisplayName("Replace Configuration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RplcCfgtn")]
    #endif
    [IsoXmlTag("RplcCfgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReplaceConfiguration { get; init; } 
    #else
    public System.String? ReplaceConfiguration { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    [IsoId("_GDPc43IiEe299ZbWCkdR_w")]
    [DisplayName("TMS Protocol Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMSPrtcolParams")]
    #endif
    [IsoXmlTag("TMSPrtcolParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TMSProtocolParameters7? TMSProtocolParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSProtocolParameters7? TMSProtocolParameters { get; init; } 
    #else
    public TMSProtocolParameters7? TMSProtocolParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_GDPc5XIiEe299ZbWCkdR_w")]
    [DisplayName("Acquirer Protocol Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrPrtcolParams")]
    #endif
    [IsoXmlTag("AcqrrPrtcolParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerProtocolParameters16? AcquirerProtocolParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerProtocolParameters16? AcquirerProtocolParameters { get; init; } 
    #else
    public AcquirerProtocolParameters16? AcquirerProtocolParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to a service provider.
    /// </summary>
    [IsoId("_GDPc53IiEe299ZbWCkdR_w")]
    [DisplayName("Service Provider Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcPrvdrParams")]
    #endif
    [IsoXmlTag("SvcPrvdrParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ServiceProviderParameters3? ServiceProviderParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceProviderParameters3? ServiceProviderParameters { get; init; } 
    #else
    public ServiceProviderParameters3? ServiceProviderParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_GDPc6XIiEe299ZbWCkdR_w")]
    [DisplayName("Merchant Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntParams")]
    #endif
    [IsoXmlTag("MrchntParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MerchantConfigurationParameters6? MerchantParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MerchantConfigurationParameters6? MerchantParameters { get; init; } 
    #else
    public MerchantConfigurationParameters6? MerchantParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_GDPc63IiEe299ZbWCkdR_w")]
    [DisplayName("Terminal Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlParams")]
    #endif
    [IsoXmlTag("TermnlParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTerminalParameters8? TerminalParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTerminalParameters8? TerminalParameters { get; init; } 
    #else
    public PaymentTerminalParameters8? TerminalParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_GDQD8XIiEe299ZbWCkdR_w")]
    [DisplayName("Application Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplParams")]
    #endif
    [IsoXmlTag("ApplParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ApplicationParameters12? ApplicationParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ApplicationParameters12? ApplicationParameters { get; init; } 
    #else
    public ApplicationParameters12? ApplicationParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    [IsoId("_GDQD83IiEe299ZbWCkdR_w")]
    [DisplayName("Host Communication Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstComParams")]
    #endif
    [IsoXmlTag("HstComParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public HostCommunicationParameter6? HostCommunicationParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HostCommunicationParameter6? HostCommunicationParameters { get; init; } 
    #else
    public HostCommunicationParameter6? HostCommunicationParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_GDQD9XIiEe299ZbWCkdR_w")]
    [DisplayName("Security Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyParams")]
    #endif
    [IsoXmlTag("SctyParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityParameters15? SecurityParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityParameters15? SecurityParameters { get; init; } 
    #else
    public SecurityParameters15? SecurityParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters dedicated to protocols between a sale system and the POI.
    /// </summary>
    [IsoId("_GDQD93IiEe299ZbWCkdR_w")]
    [DisplayName("Sale To POI Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleToPOIParams")]
    #endif
    [IsoXmlTag("SaleToPOIParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SaleToPOIProtocolParameter3? SaleToPOIParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleToPOIProtocolParameter3? SaleToPOIParameters { get; init; } 
    #else
    public SaleToPOIProtocolParameter3? SaleToPOIParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Group of software packages to transfer to a group of POIComponent of the POI System.
    /// </summary>
    [IsoId("_GDQrAXIiEe299ZbWCkdR_w")]
    [DisplayName("Terminal Package")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlPackg")]
    #endif
    [IsoXmlTag("TermnlPackg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminalPackageType4? TerminalPackage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalPackageType4? TerminalPackage { get; init; } 
    #else
    public TerminalPackageType4? TerminalPackage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
