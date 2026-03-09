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
/// Provides original client order identification and order modification time.
/// </summary>
[IsoId("_Q8rosdp-Ed-ak6NoX_4Aeg_-706864990")]
[DisplayName("Cross Order Cancel")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CrossOrderCancel1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CrossOrderCancel1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CrossOrderCancel1( System.String reqOriginalClientOrderIdentification )
    {
        OriginalClientOrderIdentification = reqOriginalClientOrderIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Client Order identification of the previous order (NOT the initial order of the day) as assigned by the institution, used to identify the previous order in cancel requests.
    /// </summary>
    [IsoId("_Q8rostp-Ed-ak6NoX_4Aeg_-602509461")]
    [DisplayName("Original Client Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlClntOrdrId")]
    #endif
    [IsoXmlTag("OrgnlClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalClientOrderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalClientOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalClientOrderIdentification { get; init; } 
    #else
    public System.String OriginalClientOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the most recent (or current) CreationDateTime reported for the order. The original order modification time is provided as an optional field on Order Cancel Request to identify that the state of the order has not changed since the request was issued.
    /// </summary>
    [IsoId("_Q8ros9p-Ed-ak6NoX_4Aeg_-565566764")]
    [DisplayName("Original Order Modification Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlOrdrModTm")]
    #endif
    [IsoXmlTag("OrgnlOrdrModTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OriginalOrderModificationTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OriginalOrderModificationTime { get; init; } 
    #else
    public System.DateTime? OriginalOrderModificationTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
