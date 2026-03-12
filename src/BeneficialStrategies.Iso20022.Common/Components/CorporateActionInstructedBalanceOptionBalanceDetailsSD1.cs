// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action instructed balance details at option level.
/// </summary>
[IsoId("_Y8Lvc5H6EeaNbfbSYshZYw")]
[DisplayName("Corporate Action Instructed Balance Option Balance Details SD")]
public partial record CorporateActionInstructedBalanceOptionBalanceDetailsSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_Y8LvdZH6EeaNbfbSYshZYw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Balance of uncovered protect transactions at an option level.
    /// </summary>
    [IsoId("_Y8LvdJH6EeaNbfbSYshZYw")]
    [DisplayName("Option Uncovered Protect Balance")]
    [IsoXmlTag("OptnUcvrdPrtctBal")]
    public SignedQuantityFormat9? OptionUncoveredProtectBalance { get; init; } 
    
    /// <summary>
    /// Daily total of instructions for a given option. Balance will include only made instructions.
    /// </summary>
    [IsoId("_R8Kz4JH7EeaNbfbSYshZYw")]
    [DisplayName("Option Daily Instructed Balance")]
    [IsoXmlTag("OptnDalyInstdBal")]
    public SignedQuantityFormat9? OptionDailyInstructedBalance { get; init; } 
    
    /// <summary>
    /// For rights subscription events, total number of oversubscribed units. When there is an oversubscription priviledge, this quantity will be included within the Instructed quantityin the core message.
    /// </summary>
    [IsoId("_mbohsJH7EeaNbfbSYshZYw")]
    [DisplayName("Option Oversubscription Quantity")]
    [IsoXmlTag("OptnOvrsbcptQty")]
    public SignedQuantityFormat9? OptionOversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// For election merger events, the balance that is being moved into another option number for payment due to the proration of the original option.
    /// </summary>
    [IsoId("_vpFIsJH7EeaNbfbSYshZYw")]
    [DisplayName("Option Unaccepted Balance")]
    [IsoXmlTag("OptnUaccptdBal")]
    public SignedQuantityFormat9? OptionUnacceptedBalance { get; init; } 
    
    
    #nullable disable
    
}
