// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information and details on the status of a trade.
/// </summary>
[IsoId("_3HeesQN0Ee2-vqzwMUAewg")]
[DisplayName("Trade Data")]
public partial record TradeData40
{
    #nullable enable
    
    /// <summary>
    /// Represents the original reference of the instruction for which the status is given, as assigned by the participant that submitted the foreign exchange trade.
    /// </summary>
    [IsoId("_3Nj4lQN0Ee2-vqzwMUAewg")]
    [DisplayName("Originator Reference")]
    [IsoXmlTag("OrgtrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginatorReference { get; init; } 
    
    /// <summary>
    /// Reference to the unique system identification assigned to the trade by the central matching system.
    /// </summary>
    [IsoId("_3Nj4lwN0Ee2-vqzwMUAewg")]
    [DisplayName("Matching System Unique Reference")]
    [IsoXmlTag("MtchgSysUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; } 
    
    /// <summary>
    /// Reference to the unique matching identification assigned to the trade and to the matching trade from the counterparty by the central matching system.
    /// </summary>
    [IsoId("_3Nj4mQN0Ee2-vqzwMUAewg")]
    [DisplayName("Matching System Matching Reference")]
    [IsoXmlTag("MtchgSysMtchgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MatchingSystemMatchingReference { get; init; } 
    
    /// <summary>
    /// Unique reference from the central settlement system that allows the removal of alleged trades once the matched status notification for the matching side has been received.
    /// </summary>
    [IsoId("_3Nj4mwN0Ee2-vqzwMUAewg")]
    [DisplayName("Matching System Matched Side Reference")]
    [IsoXmlTag("MtchgSysMtchdSdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MatchingSystemMatchedSideReference { get; init; } 
    
    /// <summary>
    /// The current settlement date of the notification.
    /// </summary>
    [IsoId("_3Nj4nQN0Ee2-vqzwMUAewg")]
    [DisplayName("Current Settlement Date")]
    [IsoXmlTag("CurSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CurrentSettlementDate { get; init; } 
    
    /// <summary>
    /// Settlement date has been amended.
    /// </summary>
    [IsoId("_3Nj4nwN0Ee2-vqzwMUAewg")]
    [DisplayName("New Settlement Date")]
    [IsoXmlTag("NewSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NewSettlementDate { get; init; } 
    
    /// <summary>
    /// Specifies the date and time at which the current status was assigned to the individual trade.
    /// </summary>
    [IsoId("_3Nj4oQN0Ee2-vqzwMUAewg")]
    [DisplayName("Current Status Date Time")]
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CurrentStatusDateTime { get; init; } 
    
    /// <summary>
    /// Product type of the individual trade.
    /// </summary>
    [IsoId("_3Nj4owN0Ee2-vqzwMUAewg")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProductType { get; init; } 
    
    /// <summary>
    /// Indicate the requested settlement session that the related trade is part of.
    /// </summary>
    [IsoId("_3Nj4pQN0Ee2-vqzwMUAewg")]
    [DisplayName("Settlement Session Identifier")]
    [IsoXmlTag("SttlmSsnIdr")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; } 
    
    /// <summary>
    /// Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.
    /// </summary>
    [IsoId("_3Nj4pwN0Ee2-vqzwMUAewg")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public RegulatoryReporting7? RegulatoryReporting { get; init; } 
    
    
    #nullable disable
    
}
