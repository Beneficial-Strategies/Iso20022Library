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
/// Contractual details related to the agreement between parties.
/// </summary>
[IsoId("_ozNtAY-eEeaEa8S_GI1QNA")]
[DisplayName("Agreement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Agreement5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Full name of the base standard agreement, annexes and amendments in place between the principals and applicable to this deal.
    /// </summary>
    [IsoId("_pB8Fh4-eEeaEa8S_GI1QNA")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric representation of the day of the month and year.
    /// </summary>
    [IsoId("_pB8Fj4-eEeaEa8S_GI1QNA")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? Date { get; init; } 
    #else
    public System.DateTime? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Contractual currency forming the basis of a financing agreement and associated transactions. Usually, but not always, the same as the trade currency.
    /// </summary>
    [IsoId("_pB8Fl4-eEeaEa8S_GI1QNA")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Type of financing closing.
    /// </summary>
    [IsoId("_pB8Fn4-eEeaEa8S_GI1QNA")]
    [DisplayName("Closing Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgTp")]
    #endif
    [IsoXmlTag("ClsgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClosingType1Code? ClosingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosingType1Code? ClosingType { get; init; } 
    #else
    public ClosingType1Code? ClosingType { get; set; } 
    #endif
    
    /// <summary>
    /// Start date of a financing deal that is the date the buyer pays the seller cash and takes control of the collateral.
    /// </summary>
    [IsoId("_pB8Fp4-eEeaEa8S_GI1QNA")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? StartDate { get; init; } 
    #else
    public System.DateTime? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies type of settlement.
    /// </summary>
    [IsoId("_pB8Fr4-eEeaEa8S_GI1QNA")]
    [DisplayName("Delivery Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryTp")]
    #endif
    [IsoXmlTag("DlvryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryType2Code? DeliveryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryType2Code? DeliveryType { get; init; } 
    #else
    public DeliveryType2Code? DeliveryType { get; set; } 
    #endif
    
    /// <summary>
    /// Fraction of the cash consideration that must be collateralized, expressed as a percent. A margin ratio of 02% indicates that the value of the collateral (after deducting for &quot;haircut&quot;) must exceed the cash consideration by 2%.
    /// </summary>
    [IsoId("_pB8Ft4-eEeaEa8S_GI1QNA")]
    [DisplayName("Margin Ratio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnRatio")]
    #endif
    [IsoXmlTag("MrgnRatio")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? MarginRatio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MarginRatio { get; init; } 
    #else
    public System.Decimal? MarginRatio { get; set; } 
    #endif
    
    
    #nullable disable
    
}
