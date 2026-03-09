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
[IsoId("_RVMSUVFIEeyApZmLzm74zA")]
[DisplayName("Application Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ApplicationParameters11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ApplicationParameters11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ApplicationParameters11( TerminalManagementAction3Code reqActionType,System.String reqApplicationIdentification )
    {
        ActionType = reqActionType;
        ApplicationIdentification = reqApplicationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_RbdSYVFIEeyApZmLzm74zA")]
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
    [IsoId("_RbdSY1FIEeyApZmLzm74zA")]
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
    [IsoId("_RbdSZVFIEeyApZmLzm74zA")]
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
    /// Version of the parameters&apos; format.
    /// </summary>
    [IsoId("_RbdSZ1FIEeyApZmLzm74zA")]
    [DisplayName("Parameter Format Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParamFrmtIdr")]
    #endif
    [IsoXmlTag("ParamFrmtIdr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax8Text? ParameterFormatIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ParameterFormatIdentifier { get; init; } 
    #else
    public System.String? ParameterFormatIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Full length of parameters.
    /// </summary>
    [IsoId("_RbdSaVFIEeyApZmLzm74zA")]
    [DisplayName("Parameters Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParamsLngth")]
    #endif
    [IsoXmlTag("ParamsLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? ParametersLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ParametersLength { get; init; } 
    #else
    public System.UInt64? ParametersLength { get; set; } 
    #endif
    
    /// <summary>
    /// Place of this  Block, beginning with 0, in the full parameters.
    /// </summary>
    [IsoId("_RbdSa1FIEeyApZmLzm74zA")]
    [DisplayName("Offset Start")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffsetStart")]
    #endif
    [IsoXmlTag("OffsetStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? OffsetStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? OffsetStart { get; init; } 
    #else
    public System.UInt64? OffsetStart { get; set; } 
    #endif
    
    /// <summary>
    /// Following place of this Block in the full parameters.
    /// </summary>
    [IsoId("_RbdSbVFIEeyApZmLzm74zA")]
    [DisplayName("Offset End")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffsetEnd")]
    #endif
    [IsoXmlTag("OffsetEnd")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? OffsetEnd { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? OffsetEnd { get; init; } 
    #else
    public System.UInt64? OffsetEnd { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    [IsoId("_RbdSb1FIEeyApZmLzm74zA")]
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
    [IsoId("_RbdScVFIEeyApZmLzm74zA")]
    [DisplayName("Encrypted Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdParams")]
    #endif
    [IsoXmlTag("NcrptdParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType32? EncryptedParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType32? EncryptedParameters { get; init; } 
    #else
    public ContentInformationType32? EncryptedParameters { get; set; } 
    #endif
    
    
    #nullable disable
    
}
