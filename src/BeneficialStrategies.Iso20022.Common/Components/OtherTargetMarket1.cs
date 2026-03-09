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
/// Other target market parameter.
/// </summary>
[IsoId("_d1KFQD8VEeih8-WNbS6hbA")]
[DisplayName("Other Target Market")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherTargetMarket1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OtherTargetMarket1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OtherTargetMarket1( System.String reqTargetMarketType )
    {
        TargetMarketType = reqTargetMarketType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of target market parameter.
    /// </summary>
    [IsoId("_lV2PgD8VEeih8-WNbS6hbA")]
    [DisplayName("Target Market Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtMktTp")]
    #endif
    [IsoXmlTag("TrgtMktTp")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text TargetMarketType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TargetMarketType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TargetMarketType { get; init; } 
    #else
    public System.String TargetMarketType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the target market.
    /// </summary>
    [IsoId("_qN1SIT8VEeih8-WNbS6hbA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
