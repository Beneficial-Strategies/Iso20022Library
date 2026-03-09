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
/// Information related to multimodal transportation of goods.
/// </summary>
[IsoId("_StCMANp-Ed-ak6NoX_4Aeg_1369687043")]
[DisplayName("Multimodal Transport")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MultimodalTransport3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MultimodalTransport3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MultimodalTransport3( System.String reqTakingInCharge,System.String reqPlaceOfFinalDestination )
    {
        TakingInCharge = reqTakingInCharge;
        PlaceOfFinalDestination = reqPlaceOfFinalDestination;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the location where the goods are take in charge for transportation.
    /// </summary>
    [IsoId("_StCMAdp-Ed-ak6NoX_4Aeg_1369687683")]
    [DisplayName("Taking In Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TakngInChrg")]
    #endif
    [IsoXmlTag("TakngInChrg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TakingInCharge { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TakingInCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TakingInCharge { get; init; } 
    #else
    public System.String TakingInCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the location of the final destination of the goods.
    /// </summary>
    [IsoId("_StL9ANp-Ed-ak6NoX_4Aeg_1369687605")]
    [DisplayName("Place Of Final Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfFnlDstn")]
    #endif
    [IsoXmlTag("PlcOfFnlDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PlaceOfFinalDestination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceOfFinalDestination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceOfFinalDestination { get; init; } 
    #else
    public System.String PlaceOfFinalDestination { get; set; } 
    #endif
    
    
    #nullable disable
    
}
