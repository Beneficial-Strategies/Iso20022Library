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
/// Funds transfer service
/// </summary>
[IsoId("__MxEsEUTEeea-M6VZkEPUw")]
[DisplayName("Transfer Service")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferService1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the funding service provider.
    /// </summary>
    [IsoId("_Zywr4EUUEeea-M6VZkEPUw")]
    [DisplayName("Service Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcPrvdr")]
    #endif
    [IsoXmlTag("SvcPrvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceProvider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceProvider { get; init; } 
    #else
    public System.String? ServiceProvider { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the funding service (for example, MoneyGram, Western Union, etc.).
    /// </summary>
    [IsoId("_i6qEgEUUEeea-M6VZkEPUw")]
    [DisplayName("Service Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcNm")]
    #endif
    [IsoXmlTag("SvcNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceName { get; init; } 
    #else
    public System.String? ServiceName { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the funding service.
    /// </summary>
    [IsoId("_qNfY8EUUEeea-M6VZkEPUw")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reference { get; init; } 
    #else
    public System.String? Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Purpose of the transfer. For example: person to person, business-to-business and mobile top-up.
    /// </summary>
    [IsoId("_3dKWwdIsEeirx-13kKhDlQ")]
    [DisplayName("Business Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizPurp")]
    #endif
    [IsoXmlTag("BizPurp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BusinessPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BusinessPurpose { get; init; } 
    #else
    public System.String? BusinessPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Free text that can be used between the sender and the receiver to describe the details of the transfer.
    /// </summary>
    [IsoId("_8KdMUdIsEeirx-13kKhDlQ")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
