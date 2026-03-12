// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on transaction and conducting counterparty.
/// </summary>
[IsoId("_xzGNwVyGEe24CqbZJK5XxA")]
[DisplayName("Trade Transaction Identification")]
public partial record TradeTransactionIdentification24
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_x0MZ8VyGEe24CqbZJK5XxA")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Indication of the action type of the transaction.
    /// </summary>
    [IsoId("_x0MZ81yGEe24CqbZJK5XxA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public TransactionOperationType10Code? ActionType { get; init; } 
    
    /// <summary>
    /// Indicates the date and time of the submission of the report to the trade repository.
    /// </summary>
    [IsoId("_x0MZ9VyGEe24CqbZJK5XxA")]
    [DisplayName("Reporting Time Stamp")]
    [IsoXmlTag("RptgTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ReportingTimeStamp { get; init; } 
    
    /// <summary>
    /// Classification of derivative event type.
    /// </summary>
    [IsoId("_x0MZ91yGEe24CqbZJK5XxA")]
    [DisplayName("Derivative Event Type")]
    [IsoXmlTag("DerivEvtTp")]
    public DerivativeEventType3Code? DerivativeEventType { get; init; } 
    
    /// <summary>
    /// Indicates the time stamp of a derivative event.
    /// </summary>
    [IsoId("_x0MZ-VyGEe24CqbZJK5XxA")]
    [DisplayName("Derivative Event Time Stamp")]
    [IsoXmlTag("DerivEvtTmStmp")]
    public DateAndDateTime2Choice_? DerivativeEventTimeStamp { get; init; } 
    
    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    [IsoId("_x0MZ-1yGEe24CqbZJK5XxA")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public PartyIdentification248Choice_? OtherCounterparty { get; init; } 
    
    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier as agreed with the counterparty.
    /// </summary>
    [IsoId("_x0MZ_VyGEe24CqbZJK5XxA")]
    [DisplayName("Unique Identifier")]
    [IsoXmlTag("UnqIdr")]
    public UniqueTransactionIdentifier2Choice_? UniqueIdentifier { get; init; } 
    
    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    [IsoId("_x0MZ_1yGEe24CqbZJK5XxA")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement8? MasterAgreement { get; init; } 
    
    /// <summary>
    /// Unique codes identifying the portfolio.
    /// </summary>
    [IsoId("_x0MaAVyGEe24CqbZJK5XxA")]
    [DisplayName("Collateral Portfolio Code")]
    [IsoXmlTag("CollPrtflCd")]
    public CollateralPortfolioCode5Choice_? CollateralPortfolioCode { get; init; } 
    
    
    #nullable disable
    
}
