// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Query criteria regarding action type, product classification, venue of execution, asset class, corporate sector nature of counterparty.
/// </summary>
[IsoId("_QWIcTa5pEeuo-IflVgGqiA")]
[DisplayName("Trade Additional Query Criteria")]
public partial record TradeAdditionalQueryCriteria7
{
    #nullable enable
    
    /// <summary>
    /// Action types allowed as query criteria.
    /// </summary>
    [IsoId("_Qlef065pEeuo-IflVgGqiA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public TransactionOperationType6Code? ActionType { get; init; } 
    
    /// <summary>
    /// Indicates the execution venue of the reported transaction.
    /// </summary>
    [IsoId("_Qlef1a5pEeuo-IflVgGqiA")]
    [DisplayName("Execution Venue")]
    [IsoXmlTag("ExctnVn")]
    public SecuritiesTradeVenueCriteria1Choice_? ExecutionVenue { get; init; } 
    
    /// <summary>
    /// Indicates the nature of the reporting counterparty (if it is a central counterparty (CCP), a financial counterparty, a non-financial counterparty or another type of counterparty).
    /// </summary>
    [IsoId("_Qlef165pEeuo-IflVgGqiA")]
    [DisplayName("Nature Of Counterparty")]
    [IsoXmlTag("NtrOfCtrPty")]
    public PartyNatureType1Code? NatureOfCounterparty { get; init; } 
    
    /// <summary>
    /// Specifies the corporate sector of the reporting counterparty.
    /// </summary>
    [IsoId("_Qlef2a5pEeuo-IflVgGqiA")]
    [DisplayName("Corporate Sector")]
    [IsoXmlTag("CorpSctr")]
    public CorporateSectorCriteria5? CorporateSector { get; init; } 
    
    
    #nullable disable
    
}
