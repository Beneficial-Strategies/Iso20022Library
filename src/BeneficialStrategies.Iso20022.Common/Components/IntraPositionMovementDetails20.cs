// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
[IsoId("_ccpngzi8Eeydid5dcNPKvg")]
[DisplayName("Intra Position Movement Details")]
public record IntraPositionMovementDetails20
{
    /// <summary>
    /// Identifications (account owner and/or account servicer) of the intra-position movement.
    /// </summary>
    [IsoId("_ccpnhzi8Eeydid5dcNPKvg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public References75Choice_? Identification { get; init; }

    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_ccpniTi8Eeydid5dcNPKvg")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required FinancialInstrumentQuantity36Choice_ SettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_ccpnizi8Eeydid5dcNPKvg")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity36Choice_? PreviouslySettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_ccpnjTi8Eeydid5dcNPKvg")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity36Choice_? RemainingToBeSettledQuantity { get; init; }

    /// <summary>
    /// Number identifying a securities sub-balance type for example restriction identification.
    /// </summary>
    [IsoId("_ccpnjzi8Eeydid5dcNPKvg")]
    [DisplayName("Securities Sub Balance Identification")]
    [IsoXmlTag("SctiesSubBalId")]
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; init; }

    /// <summary>
    /// Balance to which the securities were moved.
    /// </summary>
    [IsoId("_ccpnkTi8Eeydid5dcNPKvg")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required SecuritiesBalanceType8Choice_ BalanceTo { get; init; }

    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    [IsoId("_ccpnkzi8Eeydid5dcNPKvg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTime2Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    [IsoId("_ccpnlTi8Eeydid5dcNPKvg")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateAndDateTime2Choice_? AvailableDate { get; init; }

    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    [IsoId("_ccpnlzi8Eeydid5dcNPKvg")]
    [DisplayName("Acknowledged Status Time Stamp")]
    [IsoXmlTag("AckdStsTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; }

    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_ccpnmTi8Eeydid5dcNPKvg")]
    [DisplayName("Corporate Action Event Type")]
    [IsoXmlTag("CorpActnEvtTp")]
    public CorporateActionEventType101Choice_? CorporateActionEventType { get; init; }

    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    [IsoId("_ccpnmzi8Eeydid5dcNPKvg")]
    [DisplayName("Collateral Monitor Amount")]
    [IsoXmlTag("CollMntrAmt")]
    public AmountAndDirection55? CollateralMonitorAmount { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_ccpnnTi8Eeydid5dcNPKvg")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? InstructionProcessingAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ccpnnzi8Eeydid5dcNPKvg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
