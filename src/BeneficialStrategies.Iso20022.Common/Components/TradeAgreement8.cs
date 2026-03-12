// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and identification of a trade together with references to previous events in its life.
/// </summary>
[IsoId("_zMQpoR3aEeKXIbeXfdPzuw")]
[DisplayName("Trade Agreement")]
public partial record TradeAgreement8
{
    #nullable enable
    
    /// <summary>
    /// Date on which the trading parties agreed to amend or cancel the trade.
    /// </summary>
    [IsoId("_zXykNR3aEeKXIbeXfdPzuw")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; } 
    
    /// <summary>
    /// Reference of the present instruction assigned by the party issuing the message. This reference must be unique amongst all messages of same type sent by the same party.
    /// </summary>
    [IsoId("_sHsTlTqKEeKXK8qRvydwAw")]
    [DisplayName("Originator Reference")]
    [IsoXmlTag("OrgtrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginatorReference { get; init; } 
    
    /// <summary>
    /// Identification of a matching system reference by a choice between a matching system unique identification or the related reference.
    /// </summary>
    [IsoId("_XvET0kNtEeKtI7DGRusoBg")]
    [DisplayName("Matching System Reference")]
    [IsoXmlTag("MtchgSysRef")]
    public required MatchingSystemReference1Choice_ MatchingSystemReference { get; init; } 
    
    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    [IsoId("_zXykPR3aEeKXIbeXfdPzuw")]
    [DisplayName("Common Reference")]
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommonReference { get; init; } 
    
    /// <summary>
    /// Describes the reason for the cancellation or the amendment.
    /// </summary>
    [IsoId("_zXykQR3aEeKXIbeXfdPzuw")]
    [DisplayName("Amend Or Cancel Reason")]
    [IsoXmlTag("AmdOrCclRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AmendOrCancelReason { get; init; } 
    
    /// <summary>
    /// Specifies the type of underlying transaction, for example cancellation (CANC).
    /// </summary>
    [IsoId("_zXykSR3aEeKXIbeXfdPzuw")]
    [DisplayName("Operation Type")]
    [IsoXmlTag("OprTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? OperationType { get; init; } 
    
    /// <summary>
    /// Specifies the business role between the submitter and the trade party, for example Agent (AGNT).
    /// </summary>
    [IsoId("_zXykTR3aEeKXIbeXfdPzuw")]
    [DisplayName("Operation Scope")]
    [IsoXmlTag("OprScp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? OperationScope { get; init; } 
    
    /// <summary>
    /// To indicate the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_k8djFx3aEeKXIbeXfdPzuw")]
    [DisplayName("Settlement Session Identifier")]
    [IsoXmlTag("SttlmSsnIdr")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; } 
    
    
    #nullable disable
    
}
