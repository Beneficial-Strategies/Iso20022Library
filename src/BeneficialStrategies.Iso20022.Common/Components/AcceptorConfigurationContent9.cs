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
[IsoId("_No_w0QufEeqw5uEXxQ9H4g")]
[DisplayName("Acceptor Configuration Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorConfigurationContent9
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
    [IsoId("_NzqvwQufEeqw5uEXxQ9H4g")]
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
    [IsoId("_NzqvwwufEeqw5uEXxQ9H4g")]
    [DisplayName("TMS Protocol Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMSPrtcolParams")]
    #endif
    [IsoXmlTag("TMSPrtcolParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TMSProtocolParameters5? TMSProtocolParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSProtocolParameters5? TMSProtocolParameters { get; init; } 
    #else
    public TMSProtocolParameters5? TMSProtocolParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_NzqvxQufEeqw5uEXxQ9H4g")]
    [DisplayName("Acquirer Protocol Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrPrtcolParams")]
    #endif
    [IsoXmlTag("AcqrrPrtcolParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerProtocolParameters13? AcquirerProtocolParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerProtocolParameters13? AcquirerProtocolParameters { get; init; } 
    #else
    public AcquirerProtocolParameters13? AcquirerProtocolParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_NzqvxwufEeqw5uEXxQ9H4g")]
    [DisplayName("Merchant Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntParams")]
    #endif
    [IsoXmlTag("MrchntParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MerchantConfigurationParameters5? MerchantParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MerchantConfigurationParameters5? MerchantParameters { get; init; } 
    #else
    public MerchantConfigurationParameters5? MerchantParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_NzqvyQufEeqw5uEXxQ9H4g")]
    [DisplayName("Terminal Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlParams")]
    #endif
    [IsoXmlTag("TermnlParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTerminalParameters7? TerminalParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTerminalParameters7? TerminalParameters { get; init; } 
    #else
    public PaymentTerminalParameters7? TerminalParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_NzqvywufEeqw5uEXxQ9H4g")]
    [DisplayName("Application Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplParams")]
    #endif
    [IsoXmlTag("ApplParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ApplicationParameters9? ApplicationParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ApplicationParameters9? ApplicationParameters { get; init; } 
    #else
    public ApplicationParameters9? ApplicationParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    [IsoId("_NzqvzQufEeqw5uEXxQ9H4g")]
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
    [IsoId("_NzqvzwufEeqw5uEXxQ9H4g")]
    [DisplayName("Security Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyParams")]
    #endif
    [IsoXmlTag("SctyParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityParameters12? SecurityParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityParameters12? SecurityParameters { get; init; } 
    #else
    public SecurityParameters12? SecurityParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters dedicated to protocols between a sale system and the POI.
    /// </summary>
    [IsoId("_Nzqv0QufEeqw5uEXxQ9H4g")]
    [DisplayName("Sale To POI Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleToPOIParams")]
    #endif
    [IsoXmlTag("SaleToPOIParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SaleToPOIProtocolParameter1? SaleToPOIParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleToPOIProtocolParameter1? SaleToPOIParameters { get; init; } 
    #else
    public SaleToPOIProtocolParameter1? SaleToPOIParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Group of software packages to transfer to a group of POIComponent of the POI System.
    /// </summary>
    [IsoId("_np21MAugEeqw5uEXxQ9H4g")]
    [DisplayName("Terminal Package")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlPackg")]
    #endif
    [IsoXmlTag("TermnlPackg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminalPackageType1? TerminalPackage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalPackageType1? TerminalPackage { get; init; } 
    #else
    public TerminalPackageType1? TerminalPackage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
