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
[IsoId("_EoBb8b-0Eeeb2ZBoAlSG1Q")]
[DisplayName("Corporate Action Instructed Balance Option Balance Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionInstructedBalanceOptionBalanceDetailsSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionInstructedBalanceOptionBalanceDetailsSD2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionInstructedBalanceOptionBalanceDetailsSD2( OptionNumber1Choice_ reqOptionNumber )
    {
        OptionNumber = reqOptionNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_E3yWQb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Option Number of the extended balances.
    /// </summary>
    [IsoId("_R4_EcL_wEeeb2ZBoAlSG1Q")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionNumber1Choice_ OptionNumber { get; init; } 
    #else
    public OptionNumber1Choice_ OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of uncovered protect transactions at an option level.
    /// </summary>
    [IsoId("_E3yWQ7-0Eeeb2ZBoAlSG1Q")]
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
    [IsoId("_E3yWRb-0Eeeb2ZBoAlSG1Q")]
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
    /// For rights subscription events, total number of oversubscribed units. When there is an oversubscription privilege, this quantity will be included within the Instructed quantity in the core message.
    /// </summary>
    [IsoId("_E3yWR7-0Eeeb2ZBoAlSG1Q")]
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
    [IsoId("_E3yWSb-0Eeeb2ZBoAlSG1Q")]
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
