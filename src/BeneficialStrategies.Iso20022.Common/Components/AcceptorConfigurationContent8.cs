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
[IsoId("_52vI0dXzEeia9rtBTv_9KA")]
[DisplayName("Acceptor Configuration Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorConfigurationContent8
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
    [IsoId("_6AvZYdXzEeia9rtBTv_9KA")]
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
    [IsoId("_6AvZY9XzEeia9rtBTv_9KA")]
    [DisplayName("TMS Protocol Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMSPrtcolParams")]
    #endif
    [IsoXmlTag("TMSPrtcolParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TMSProtocolParameters4? TMSProtocolParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSProtocolParameters4? TMSProtocolParameters { get; init; } 
    #else
    public TMSProtocolParameters4? TMSProtocolParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_6AvZZdXzEeia9rtBTv_9KA")]
    [DisplayName("Acquirer Protocol Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrPrtcolParams")]
    #endif
    [IsoXmlTag("AcqrrPrtcolParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerProtocolParameters12? AcquirerProtocolParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerProtocolParameters12? AcquirerProtocolParameters { get; init; } 
    #else
    public AcquirerProtocolParameters12? AcquirerProtocolParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_6AvZZ9XzEeia9rtBTv_9KA")]
    [DisplayName("Merchant Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntParams")]
    #endif
    [IsoXmlTag("MrchntParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MerchantConfigurationParameters4? MerchantParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MerchantConfigurationParameters4? MerchantParameters { get; init; } 
    #else
    public MerchantConfigurationParameters4? MerchantParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_6AvZadXzEeia9rtBTv_9KA")]
    [DisplayName("Terminal Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlParams")]
    #endif
    [IsoXmlTag("TermnlParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTerminalParameters6? TerminalParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTerminalParameters6? TerminalParameters { get; init; } 
    #else
    public PaymentTerminalParameters6? TerminalParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_6AvZa9XzEeia9rtBTv_9KA")]
    [DisplayName("Application Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplParams")]
    #endif
    [IsoXmlTag("ApplParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ApplicationParameters8? ApplicationParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ApplicationParameters8? ApplicationParameters { get; init; } 
    #else
    public ApplicationParameters8? ApplicationParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    [IsoId("_6AvZbdXzEeia9rtBTv_9KA")]
    [DisplayName("Host Communication Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstComParams")]
    #endif
    [IsoXmlTag("HstComParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public HostCommunicationParameter5? HostCommunicationParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HostCommunicationParameter5? HostCommunicationParameters { get; init; } 
    #else
    public HostCommunicationParameter5? HostCommunicationParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_6AwAcdXzEeia9rtBTv_9KA")]
    [DisplayName("Security Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyParams")]
    #endif
    [IsoXmlTag("SctyParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityParameters11? SecurityParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityParameters11? SecurityParameters { get; init; } 
    #else
    public SecurityParameters11? SecurityParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters dedicated to protocols between a sale system and the POI.
    /// </summary>
    [IsoId("_6AwAc9XzEeia9rtBTv_9KA")]
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
    
    
    #nullable disable
    
}
