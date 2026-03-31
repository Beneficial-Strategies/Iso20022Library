// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action instructed balance details at option level.
/// </summary>
[IsoId("_EqhGsegXEei5aPS232E3Mw")]
[DisplayName("Corporate Action Instructed Balance Option Balance SD")]
public record CorporateActionInstructedBalanceOptionBalanceSD3
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_FTkqwegXEei5aPS232E3Mw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Option Number of the extended balances.
    /// </summary>
    [IsoId("_FTkqw-gXEei5aPS232E3Mw")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Balance of uncovered protect transactions at an option level.
    /// </summary>
    [IsoId("_FTkqxegXEei5aPS232E3Mw")]
    [DisplayName("Option Uncovered Protect Balance")]
    [IsoXmlTag("OptnUcvrdPrtctBal")]
    public SignedQuantityFormat9? OptionUncoveredProtectBalance { get; init; }

    /// <summary>
    /// For rights subscription events, total number of oversubscribed units. When there is an oversubscription privilege, this quantity will be included within the Instructed quantity in the core message.
    /// </summary>
    [IsoId("_FTkqyegXEei5aPS232E3Mw")]
    [DisplayName("Option Oversubscription Quantity")]
    [IsoXmlTag("OptnOvrsbcptQty")]
    public SignedQuantityFormat9? OptionOversubscriptionQuantity { get; init; }

    /// <summary>
    /// For election merger events, the balance that is being moved into another option number for payment due to the proration of the original option.
    /// </summary>
    [IsoId("_FTkqy-gXEei5aPS232E3Mw")]
    [DisplayName("Option Unaccepted Balance")]
    [IsoXmlTag("OptnUaccptdBal")]
    public SignedQuantityFormat9? OptionUnacceptedBalance { get; init; }
}
