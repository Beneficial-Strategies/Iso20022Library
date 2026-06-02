// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies additional details of the transaction.
/// </summary>
[IsoId("_LpZDIWdDEemvNLufWGIVOQ")]
[DisplayName("Intra Position Movement8")]
public record IntraPositionMovement8
{
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_L2ayQWdDEemvNLufWGIVOQ")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; }

    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_L2aySWdDEemvNLufWGIVOQ")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_L2ayUWdDEemvNLufWGIVOQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_L2ayWWdDEemvNLufWGIVOQ")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes92? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_L2ayW2dDEemvNLufWGIVOQ")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity1Choice SettlementQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_L2ayXWdDEemvNLufWGIVOQ")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public FinancialInstrumentQuantity1Choice? SettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_L2ayX2dDEemvNLufWGIVOQ")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity1Choice? PreviouslySettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_L2ayYWdDEemvNLufWGIVOQ")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity1Choice? RemainingToBeSettledQuantity { get; init; }

    /// <summary>
    /// Date and time at which the securities are intended to be moved.
    /// </summary>
    [IsoId("_L2ayY2dDEemvNLufWGIVOQ")]
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    public required DateAndDateTime2Choice IntendedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are moved.
    /// </summary>
    [IsoId("_L2aya2dDEemvNLufWGIVOQ")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTime2Choice? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_L2bZVWdDEemvNLufWGIVOQ")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    public IsoISODateTime? StatusDate { get; init; }

    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    [IsoId("_L2bZXWdDEemvNLufWGIVOQ")]
    [DisplayName("Acknowledged Status Time Stamp")]
    [IsoXmlTag("AckdStsTmStmp")]
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; }

    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_L2bZX2dDEemvNLufWGIVOQ")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages57> Linkages { get; init; } = [];

    /// <summary>
    /// Number identifying a lot constituting the sub-balance.
    /// </summary>
    [IsoId("_L2bZYWdDEemvNLufWGIVOQ")]
    [DisplayName("Securities Sub Balance Identification")]
    [IsoXmlTag("SctiesSubBalId")]
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_L2bZY2dDEemvNLufWGIVOQ")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice? Priority { get; init; }

    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_L2bZa2dDEemvNLufWGIVOQ")]
    [DisplayName("Corporate Action Event Type")]
    [IsoXmlTag("CorpActnEvtTp")]
    public CorporateActionEventType56Choice? CorporateActionEventType { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_L2bZbWdDEemvNLufWGIVOQ")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public SystemPartyIdentification8? MessageOriginator { get; init; }

    /// <summary>
    /// Specifies the creation date/time of the intra-position movement.
    /// </summary>
    [IsoId("_L2bZb2dDEemvNLufWGIVOQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_L2bZd2dDEemvNLufWGIVOQ")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_L2bZf2dDEemvNLufWGIVOQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
