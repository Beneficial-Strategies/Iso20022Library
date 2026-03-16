// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional details of the intra-balance movements data.
/// </summary>
[IsoId("_YX0RITneEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Movement")]
public record IntraBalanceMovement6
{
    /// <summary>
    /// Balance from which the amount of money is moved.
    /// </summary>
    [IsoId("_YisEITneEem7JZMuWtwtsg")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; }

    /// <summary>
    /// Balance to which the amount of money is moved.
    /// </summary>
    [IsoId("_YisEKTneEem7JZMuWtwtsg")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; }

    /// <summary>
    /// Amount of money effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_YisEMTneEem7JZMuWtwtsg")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required Amount2Choice_ SettlementAmount { get; init; }

    /// <summary>
    /// Amount of money effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_YisEMzneEem7JZMuWtwtsg")]
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public Amount2Choice_? SettledAmount { get; init; }

    /// <summary>
    /// Amount of money previously settled.
    /// </summary>
    [IsoId("_YisENTneEem7JZMuWtwtsg")]
    [DisplayName("Previously Settled Amount")]
    [IsoXmlTag("PrevslySttldAmt")]
    public Amount2Choice_? PreviouslySettledAmount { get; init; }

    /// <summary>
    /// Amount of money remaining to be settled.
    /// </summary>
    [IsoId("_YisENzneEem7JZMuWtwtsg")]
    [DisplayName("Remaining Settlement Amount")]
    [IsoXmlTag("RmngSttlmAmt")]
    public Amount2Choice_? RemainingSettlementAmount { get; init; }

    /// <summary>
    /// Date and time at which the amount of money is intended to be moved.
    /// </summary>
    [IsoId("_YisEOTneEem7JZMuWtwtsg")]
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    public required DateAndDateTime2Choice_ IntendedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the amount of money is moved.
    /// </summary>
    [IsoId("_YisEQTneEem7JZMuWtwtsg")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_YisESTneEem7JZMuWtwtsg")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StatusDate { get; init; }

    /// <summary>
    /// Number identifying a lot constituting the sub-balance.
    /// </summary>
    [IsoId("_YisEUTneEem7JZMuWtwtsg")]
    [DisplayName("Cash Sub Balance Identification")]
    [IsoXmlTag("CshSubBalId")]
    public GenericIdentification37? CashSubBalanceIdentification { get; init; }

    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_YisEUzneEem7JZMuWtwtsg")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public Linkages57? Linkages { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_YisEVTneEem7JZMuWtwtsg")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_YisEXTneEem7JZMuWtwtsg")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public SystemPartyIdentification8? MessageOriginator { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_YisEXzneEem7JZMuWtwtsg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_YisEZzneEem7JZMuWtwtsg")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_YisEbzneEem7JZMuWtwtsg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
