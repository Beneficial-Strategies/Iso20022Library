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
[IsoId("_bc-yEdGREeaQk737TH1Fzw")]
[DisplayName("Trade Additional Query Criteria")]
public partial record TradeAdditionalQueryCriteria3
{
    #nullable enable
    
    /// <summary>
    /// Code list of the action types allowed as query criteria.
    /// </summary>
    [IsoId("_bmONodGREeaQk737TH1Fzw")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public TransactionOperationType3Code? ActionType { get; init; } 
    
    /// <summary>
    /// Indicates the execution venue of the reported transaction.
    /// </summary>
    [IsoId("_bmONo9GREeaQk737TH1Fzw")]
    [DisplayName("Execution Venue")]
    [IsoXmlTag("ExctnVn")]
    public SecuritiesTradeVenueCriteria1Choice_? ExecutionVenue { get; init; } 
    
    /// <summary>
    /// Indicates the nature of the reporting counterparty (if is a CCP, a financial, non-financial counterparty or other type of counterparty).
    /// </summary>
    [IsoId("_bmONpdGREeaQk737TH1Fzw")]
    [DisplayName("Nature Of Counterparty")]
    [IsoXmlTag("NtrOfCtrPty")]
    public PartyNatureType1Code? NatureOfCounterparty { get; init; } 
    
    /// <summary>
    /// Specifies the corporate sector of the reporting counterparty.
    /// </summary>
    [IsoId("_bmONp9GREeaQk737TH1Fzw")]
    [DisplayName("Corporate Sector")]
    [IsoXmlTag("CorpSctr")]
    public CorporateSectorCriteria3? CorporateSector { get; init; } 
    
    /// <summary>
    /// Code list of available values for asset class criteria.
    /// </summary>
    [IsoId("_bmONqdGREeaQk737TH1Fzw")]
    [DisplayName("Asset Class")]
    [IsoXmlTag("AsstClss")]
    public ProductType4Code? AssetClass { get; init; } 
    
    /// <summary>
    /// Indicates the product classification of the reported transaction.
    /// </summary>
    [IsoId("_bmONq9GREeaQk737TH1Fzw")]
    [DisplayName("Product Classification")]
    [IsoXmlTag("PdctClssfctn")]
    public ProductClassificationCriteria1? ProductClassification { get; init; } 
    
    
    #nullable disable
    
}
