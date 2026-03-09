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
/// Additional references linked to the cross order cancel request.
/// </summary>
[IsoId("_RAGwJdp-Ed-ak6NoX_4Aeg_1422002216")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Reference13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Reference13( System.String reqOriginalCrossOrderIdentification,System.String reqHostCrossIdentification )
    {
        OriginalCrossOrderIdentification = reqOriginalCrossOrderIdentification;
        HostCrossIdentification = reqHostCrossIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Cross Identifier of the previous cross order (not the initial cross order of the day) as assigned by the institution, used to identify the previous cross order in CrossOrdercancelRequest.
    /// </summary>
    [IsoId("_RAGwJtp-Ed-ak6NoX_4Aeg_889444605")]
    [DisplayName("Original Cross Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCrossOrdrId")]
    #endif
    [IsoXmlTag("OrgnlCrossOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalCrossOrderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalCrossOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalCrossOrderIdentification { get; init; } 
    #else
    public System.String OriginalCrossOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Host assigned entity identification that can be used to reference all components of a cross; sides + strategy + legs. Used as the primary key with which to refer to the Cross Order for cancellation. The HostCrossId will also be used to link together components of the cross order. For example, each individual Notice of Execution associated with the order will carry HostCrossID in order to tie back to the original cross order.
    /// </summary>
    [IsoId("_RAGwJ9p-Ed-ak6NoX_4Aeg_889444665")]
    [DisplayName("Host Cross Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstCrossId")]
    #endif
    [IsoXmlTag("HstCrossId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text HostCrossIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String HostCrossIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String HostCrossIdentification { get; init; } 
    #else
    public System.String HostCrossIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
