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
[IsoId("_k7tqETZ6EeOP_KvUKe29ng")]
[DisplayName("Acceptor Configuration Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorConfigurationContent3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_lNuAETZ6EeOP_KvUKe29ng")]
    [DisplayName("Acquirer Protocol Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrPrtcolParams")]
    #endif
    [IsoXmlTag("AcqrrPrtcolParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerProtocolParameters6? AcquirerProtocolParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerProtocolParameters6? AcquirerProtocolParameters { get; init; } 
    #else
    public AcquirerProtocolParameters6? AcquirerProtocolParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_lNuAEzZ6EeOP_KvUKe29ng")]
    [DisplayName("Merchant Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntParams")]
    #endif
    [IsoXmlTag("MrchntParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10000Binary? MerchantParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? MerchantParameters { get; init; } 
    #else
    public System.Byte[]? MerchantParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_lNuAFTZ6EeOP_KvUKe29ng")]
    [DisplayName("Terminal Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlParams")]
    #endif
    [IsoXmlTag("TermnlParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTerminalParameters1? TerminalParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTerminalParameters1? TerminalParameters { get; init; } 
    #else
    public PaymentTerminalParameters1? TerminalParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_lNuAFzZ6EeOP_KvUKe29ng")]
    [DisplayName("Application Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplParams")]
    #endif
    [IsoXmlTag("ApplParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ApplicationParameters3? ApplicationParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ApplicationParameters3? ApplicationParameters { get; init; } 
    #else
    public ApplicationParameters3? ApplicationParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host.
    /// </summary>
    [IsoId("_lNuAGTZ6EeOP_KvUKe29ng")]
    [DisplayName("Host Communication Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstComParams")]
    #endif
    [IsoXmlTag("HstComParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public HostCommunicationParameter2? HostCommunicationParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HostCommunicationParameter2? HostCommunicationParameters { get; init; } 
    #else
    public HostCommunicationParameter2? HostCommunicationParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_lNuAGzZ6EeOP_KvUKe29ng")]
    [DisplayName("Security Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyParams")]
    #endif
    [IsoXmlTag("SctyParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityParameters2? SecurityParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityParameters2? SecurityParameters { get; init; } 
    #else
    public SecurityParameters2? SecurityParameters { get; set; } 
    #endif
    
    
    #nullable disable
    
}
