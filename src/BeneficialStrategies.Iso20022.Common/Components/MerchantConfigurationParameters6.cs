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
/// Acceptor parameters dedicated to the merchant.
/// </summary>
[IsoId("_0MN8QTAZEeugIJ3Gvoevmg")]
[DisplayName("Merchant Configuration Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MerchantConfigurationParameters6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MerchantConfigurationParameters6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MerchantConfigurationParameters6( TerminalManagementAction3Code reqActionType )
    {
        ActionType = reqActionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_0YL7sTAZEeugIJ3Gvoevmg")]
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
    /// Identification of the merchant for the MTM, if the POI manages several merchants.
    /// </summary>
    [IsoId("_0YL7szAZEeugIJ3Gvoevmg")]
    [DisplayName("Merchant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntId")]
    #endif
    [IsoXmlTag("MrchntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MerchantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MerchantIdentification { get; init; } 
    #else
    public System.String? MerchantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the merchant parameters.
    /// </summary>
    [IsoId("_0YL7tTAZEeugIJ3Gvoevmg")]
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
    [IsoId("_0YL7tzAZEeugIJ3Gvoevmg")]
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
    /// Local proxy configuration.
    /// </summary>
    [IsoId("_0YL7uTAZEeugIJ3Gvoevmg")]
    [DisplayName("Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prxy")]
    #endif
    [IsoXmlTag("Prxy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters8? Proxy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters8? Proxy { get; init; } 
    #else
    public NetworkParameters8? Proxy { get; set; } 
    #endif
    
    /// <summary>
    /// Full length of other parameters.
    /// </summary>
    [IsoId("_tMDFIzAZEeugIJ3Gvoevmg")]
    [DisplayName("Other Parameters Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrParamsLngth")]
    #endif
    [IsoXmlTag("OthrParamsLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? OtherParametersLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? OtherParametersLength { get; init; } 
    #else
    public System.UInt64? OtherParametersLength { get; set; } 
    #endif
    
    /// <summary>
    /// Place of this  Block, beginning with 0, in the full other parameters.
    /// </summary>
    [IsoId("_tMDFJDAZEeugIJ3Gvoevmg")]
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
    /// Following place of this Block in the full other parameters.
    /// </summary>
    [IsoId("_tMDFJTAZEeugIJ3Gvoevmg")]
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
    /// Other merchant parameters.
    /// </summary>
    [IsoId("_0YL7uzAZEeugIJ3Gvoevmg")]
    [DisplayName("Other Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrParams")]
    #endif
    [IsoXmlTag("OthrParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10000Binary? OtherParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? OtherParameters { get; init; } 
    #else
    public System.Byte[]? OtherParameters { get; set; } 
    #endif
    
    
    #nullable disable
    
}
