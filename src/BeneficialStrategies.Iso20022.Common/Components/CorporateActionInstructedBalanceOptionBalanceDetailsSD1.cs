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
/// Provides additional information regarding corporate action instructed balance details at option level.
/// </summary>
[IsoId("_Y8Lvc5H6EeaNbfbSYshZYw")]
[DisplayName("Corporate Action Instructed Balance Option Balance Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionInstructedBalanceOptionBalanceDetailsSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionInstructedBalanceOptionBalanceDetailsSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionInstructedBalanceOptionBalanceDetailsSD1( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_Y8LvdZH6EeaNbfbSYshZYw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of uncovered protect transactions at an option level.
    /// </summary>
    [IsoId("_Y8LvdJH6EeaNbfbSYshZYw")]
    [DisplayName("Option Uncovered Protect Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnUcvrdPrtctBal")]
    #endif
    [IsoXmlTag("OptnUcvrdPrtctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? OptionUncoveredProtectBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? OptionUncoveredProtectBalance { get; init; } 
    #else
    public SignedQuantityFormat9? OptionUncoveredProtectBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of instructions for a given option. Balance will include only made instructions.
    /// </summary>
    [IsoId("_R8Kz4JH7EeaNbfbSYshZYw")]
    [DisplayName("Option Daily Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnDalyInstdBal")]
    #endif
    [IsoXmlTag("OptnDalyInstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? OptionDailyInstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? OptionDailyInstructedBalance { get; init; } 
    #else
    public SignedQuantityFormat9? OptionDailyInstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// For rights subscription events, total number of oversubscribed units. When there is an oversubscription priviledge, this quantity will be included within the Instructed quantityin the core message.
    /// </summary>
    [IsoId("_mbohsJH7EeaNbfbSYshZYw")]
    [DisplayName("Option Oversubscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnOvrsbcptQty")]
    #endif
    [IsoXmlTag("OptnOvrsbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? OptionOversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? OptionOversubscriptionQuantity { get; init; } 
    #else
    public SignedQuantityFormat9? OptionOversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// For election merger events, the balance that is being moved into another option number for payment due to the proration of the original option.
    /// </summary>
    [IsoId("_vpFIsJH7EeaNbfbSYshZYw")]
    [DisplayName("Option Unaccepted Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnUaccptdBal")]
    #endif
    [IsoXmlTag("OptnUaccptdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? OptionUnacceptedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? OptionUnacceptedBalance { get; init; } 
    #else
    public SignedQuantityFormat9? OptionUnacceptedBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
