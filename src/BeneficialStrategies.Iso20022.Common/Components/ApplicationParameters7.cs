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
/// Acceptor parameters dedicated to a payment application of the point of interaction.
/// </summary>
[IsoId("_gCnL8dtXEee9e6xduATmQg")]
[DisplayName("Application Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ApplicationParameters7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ApplicationParameters7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ApplicationParameters7( TerminalManagementAction3Code reqActionType,System.String reqApplicationIdentification )
    {
        ActionType = reqActionType;
        ApplicationIdentification = reqApplicationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_gLhQUdtXEee9e6xduATmQg")]
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
    /// Identification of the payment application.
    /// </summary>
    [IsoId("_gLhQU9tXEee9e6xduATmQg")]
    [DisplayName("Application Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplId")]
    #endif
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ApplicationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ApplicationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ApplicationIdentification { get; init; } 
    #else
    public System.String ApplicationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    [IsoId("_gLhQVdtXEee9e6xduATmQg")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Version { get; init; } 
    #else
    public System.String? Version { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    [IsoId("_gLhQV9tXEee9e6xduATmQg")]
    [DisplayName("Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Params")]
    #endif
    [IsoXmlTag("Params")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100KBinary? Parameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Parameters { get; init; } 
    #else
    public System.Byte[]? Parameters { get; set; } 
    #endif
    
    /// <summary>
    /// Sensitive parameters (sequence of parameters including the envelope) encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_gLhQWdtXEee9e6xduATmQg")]
    [DisplayName("Encrypted Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdParams")]
    #endif
    [IsoXmlTag("NcrptdParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType17? EncryptedParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType17? EncryptedParameters { get; init; } 
    #else
    public ContentInformationType17? EncryptedParameters { get; set; } 
    #endif
    
    
    #nullable disable
    
}
