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
[IsoId("__rPfEWTmEe2Qhbz5WMMCCA")]
[DisplayName("Trade Additional Query Criteria")]
public partial record TradeAdditionalQueryCriteria9
{
    #nullable enable
    
    /// <summary>
    /// Code list of the action types allowed as query criteria.
    /// </summary>
    [IsoId("__s2oo2TmEe2Qhbz5WMMCCA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public TransactionOperationType8Code? ActionType { get; init; } 
    
    /// <summary>
    /// Indicates the execution venue of the reported transaction.
    /// </summary>
    [IsoId("__s2opWTmEe2Qhbz5WMMCCA")]
    [DisplayName("Execution Venue")]
    [IsoXmlTag("ExctnVn")]
    public SecuritiesTradeVenueCriteria1Choice_? ExecutionVenue { get; init; } 
    
    /// <summary>
    /// Indicates the nature of the reporting counterparty (if is a CCP, a financial, non-financial counterparty or other type of counterparty).
    /// </summary>
    [IsoId("__s2op2TmEe2Qhbz5WMMCCA")]
    [DisplayName("Nature Of Counterparty")]
    [IsoXmlTag("NtrOfCtrPty")]
    public PartyNatureType1Code? NatureOfCounterparty { get; init; } 
    
    /// <summary>
    /// Specifies the corporate sector of the reporting counterparty.
    /// </summary>
    [IsoId("__s2oqWTmEe2Qhbz5WMMCCA")]
    [DisplayName("Corporate Sector")]
    [IsoXmlTag("CorpSctr")]
    public CorporateSectorCriteria6? CorporateSector { get; init; } 
    
    /// <summary>
    /// Code list of available values for asset class criteria.
    /// </summary>
    [IsoId("__s2oq2TmEe2Qhbz5WMMCCA")]
    [DisplayName("Asset Class")]
    [IsoXmlTag("AsstClss")]
    public ProductType4Code? AssetClass { get; init; } 
    
    /// <summary>
    /// Indicates the product classification of the reported transaction.
    /// </summary>
    [IsoId("__s2orWTmEe2Qhbz5WMMCCA")]
    [DisplayName("Product Classification")]
    [IsoXmlTag("PdctClssfctn")]
    public ProductClassificationCriteria1? ProductClassification { get; init; } 
    
    /// <summary>
    /// Information concerning the reported transaction level type.
    /// </summary>
    [IsoId("__s2or2TmEe2Qhbz5WMMCCA")]
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public ModificationLevel1Code? Level { get; init; } 
    
    /// <summary>
    /// Classification of derivative event type.
    /// </summary>
    [IsoId("_CfiysGTnEe2Qhbz5WMMCCA")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public DerivativeEventType3Code? EventType { get; init; } 
    
    
    #nullable disable
    
}
