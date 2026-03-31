// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the data for the posting intra-balance movements.
/// </summary>
[IsoId("_ZXSw6zneEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Posting")]
public record IntraBalancePosting6
{
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_ZhRzUzneEem7JZMuWtwtsg")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("_ZhRzWzneEem7JZMuWtwtsg")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_ZhRzYzneEem7JZMuWtwtsg")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction as assigned by the processor.
    /// </summary>
    [IsoId("_ZhRzazneEem7JZMuWtwtsg")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_ZhRzbTneEem7JZMuWtwtsg")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_ZhRzdTneEem7JZMuWtwtsg")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Balance to which the amount of money is moved.
    /// </summary>
    [IsoId("_ZhRzfTneEem7JZMuWtwtsg")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; }

    /// <summary>
    /// Amount of money effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_ZhRzhTneEem7JZMuWtwtsg")]
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public required Amount2Choice_ SettledAmount { get; init; }

    /// <summary>
    /// Amount of money previously settled.
    /// </summary>
    [IsoId("_ZhRzhzneEem7JZMuWtwtsg")]
    [DisplayName("Previously Settled Amount")]
    [IsoXmlTag("PrevslySttldAmt")]
    public Amount2Choice_? PreviouslySettledAmount { get; init; }

    /// <summary>
    /// Amount of money remaining to be settled.
    /// </summary>
    [IsoId("_ZhRziTneEem7JZMuWtwtsg")]
    [DisplayName("Remaining Settlement Amount")]
    [IsoXmlTag("RmngSttlmAmt")]
    public Amount2Choice_? RemainingSettlementAmount { get; init; }

    /// <summary>
    /// Date and time at which the amount of money is moved.
    /// </summary>
    [IsoId("_ZhRzizneEem7JZMuWtwtsg")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public required DateAndDateTime2Choice_ EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_ZhRzkzneEem7JZMuWtwtsg")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StatusDate { get; init; }

    /// <summary>
    /// Number identifying a lot constituting the sub-balance.
    /// </summary>
    [IsoId("_ZhRzmzneEem7JZMuWtwtsg")]
    [DisplayName("Cash Sub Balance Identification")]
    [IsoXmlTag("CshSubBalId")]
    public GenericIdentification37? CashSubBalanceIdentification { get; init; }

    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_ZhRznTneEem7JZMuWtwtsg")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages57> Linkages { get; init; } = [];

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_ZhRznzneEem7JZMuWtwtsg")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_ZhRzpzneEem7JZMuWtwtsg")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public SystemPartyIdentification8? MessageOriginator { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_ZhRzqTneEem7JZMuWtwtsg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_ZhRzsTneEem7JZMuWtwtsg")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ZhRzuTneEem7JZMuWtwtsg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
