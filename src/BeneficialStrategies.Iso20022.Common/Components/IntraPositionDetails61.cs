// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
[IsoId("_cacoEzi8Eeydid5dcNPKvg")]
[DisplayName("Intra Position Details")]
public partial record IntraPositionDetails61
{
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_cacoGzi8Eeydid5dcNPKvg")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required FinancialInstrumentQuantity36Choice_ SettledQuantity { get; init; } 
    
    /// <summary>
    /// Number identifying a Securities Sub balance Type for example restriction identification.
    /// </summary>
    [IsoId("_cacoIzi8Eeydid5dcNPKvg")]
    [DisplayName("Securities Sub Balance Identification")]
    [IsoXmlTag("SctiesSubBalId")]
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; init; } 
    
    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    [IsoId("_cacoJTi8Eeydid5dcNPKvg")]
    [DisplayName("Collateral Monitor Amount")]
    [IsoXmlTag("CollMntrAmt")]
    public AmountAndDirection55? CollateralMonitorAmount { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_cacoJzi8Eeydid5dcNPKvg")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity36Choice_? PreviouslySettledQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_cacoLzi8Eeydid5dcNPKvg")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity36Choice_? RemainingToBeSettledQuantity { get; init; } 
    
    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    [IsoId("_cacoNzi8Eeydid5dcNPKvg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTime2Choice_ SettlementDate { get; init; } 
    
    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    [IsoId("_cacoPzi8Eeydid5dcNPKvg")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateAndDateTime2Choice_? AvailableDate { get; init; } 
    
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_cacoRzi8Eeydid5dcNPKvg")]
    [DisplayName("Corporate Action Event Type")]
    [IsoXmlTag("CorpActnEvtTp")]
    public CorporateActionEventType101Choice_? CorporateActionEventType { get; init; } 
    
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_cacoTzi8Eeydid5dcNPKvg")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown6 BalanceFrom { get; init; } 
    
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_cacoVzi8Eeydid5dcNPKvg")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown6 BalanceTo { get; init; } 
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_cacoXzi8Eeydid5dcNPKvg")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    
    
    #nullable disable
    
}
