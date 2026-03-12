// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.059.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party sends the StandingSettlementInstructionCancellation message to the receiver to cancel a previously sent StandingSettlementInstruction message. The message can also be used to notify a counterparty of the deletion of a standing settlement information.
/// 
/// Usage
/// The instructing party (initiator) is:
/// • An account servicer, for example, a global custodian or prime broker
/// • A counterparty in a transaction, for example:
/// 	- an investment manager (executing broker),
/// 	- a global custodian (executing broker, prime broker)
/// • A vendor&apos;s application communicating on behalf of an account servicer or counterparty
/// The receiver is:
/// • An account owner, for example, an investment manager, hedge fund administrator or a party to which SSI operations have been outsourced
/// • A counterparty, for example:
/// 	- an investment manager (executing broker)
/// 	- a global custodian (executing broker, prime broker)
/// • A vendor&apos;s application communicating on behalf of the account owner or counterparty.
/// </summary>
[Description(@"Scope|An instructing party sends the StandingSettlementInstructionCancellation message to the receiver to cancel a previously sent StandingSettlementInstruction message. The message can also be used to notify a counterparty of the deletion of a standing settlement information.||Usage|The instructing party (initiator) is:|• An account servicer, for example, a global custodian or prime broker|• A counterparty in a transaction, for example:|	- an investment manager (executing broker),|	- a global custodian (executing broker, prime broker)|• A vendor's application communicating on behalf of an account servicer or counterparty|The receiver is:|• An account owner, for example, an investment manager, hedge fund administrator or a party to which SSI operations have been outsourced|• A counterparty, for example:|	- an investment manager (executing broker)|	- a global custodian (executing broker, prime broker)|• A vendor's application communicating on behalf of the account owner or counterparty.")]
[IsoId("_92E9EvRnEeK8G5J12Bcx2g")]
[DisplayName("Standing Settlement Instruction Cancellation V")]
public partial record StandingSettlementInstructionCancellationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.059.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StgSttlmInstrCxl";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.059.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Reference of this message.
    /// </summary>
    [IsoId("_aVZkUewmEeWkJ9nstgT-Yw")]
    [DisplayName("Message Reference Identification")]
    [IsoXmlTag("MsgRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageReferenceIdentification { get; init; } 
    
    /// <summary>
    /// Date on which the SSI is effective.
    /// </summary>
    [IsoId("_RA6MZvXrEeKpFY1yaoww4A")]
    [DisplayName("Effective Date Details")]
    [IsoXmlTag("FctvDtDtls")]
    public EffectiveDate1? EffectiveDateDetails { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous master identification known to the sender (or its authorised agent) and receiver (or its authorised agent), below which the SSI will be lodged. This may be an account number or reference to a fund.
    /// If no account or reference is available then “NONREF” must be specified.
    /// </summary>
    [IsoId("_RA6MZ_XrEeKpFY1yaoww4A")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification26 AccountIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the market for the standing settlement instruction.
    /// </summary>
    [IsoId("_ai_0YVK2EeOsJr32EK1NAQ")]
    [DisplayName("Market Identification")]
    [IsoXmlTag("MktId")]
    public required MarketIdentificationOrCashPurpose1Choice_ MarketIdentification { get; init; } 
    
    /// <summary>
    /// Settlement information that helps to identify the standing settlement instruction for which the cancellation is sent.
    /// </summary>
    [IsoId("_kAb0oVK1EeOsJr32EK1NAQ")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required PartyOrCurrency1Choice_ SettlementDetails { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_T4uZISIAEeOTvYhLlRFwVA")]
    [DisplayName("Previous Message Reference")]
    [IsoXmlTag("PrvsMsgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text PreviousMessageReference { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_dhGZsfXvEeKpFY1yaoww4A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since StandingSettlementInstructionCancellationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StandingSettlementInstructionCancellationV01.

