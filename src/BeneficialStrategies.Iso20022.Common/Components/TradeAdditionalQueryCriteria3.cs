// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Query criteria regarding action type, product classification, venue of execution, asset class, corporate sector nature of counterparty.
/// </summary>
[IsoId("_bc-yEdGREeaQk737TH1Fzw")]
[DisplayName("Trade Additional Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeAdditionalQueryCriteria3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Code list of the action types allowed as query criteria.
    /// </summary>
    [IsoId("_bmONodGREeaQk737TH1Fzw")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionOperationType3Code? ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionOperationType3Code? ActionType { get; init; } 
    #else
    public TransactionOperationType3Code? ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the execution venue of the reported transaction.
    /// </summary>
    [IsoId("_bmONo9GREeaQk737TH1Fzw")]
    [DisplayName("Execution Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnVn")]
    #endif
    [IsoXmlTag("ExctnVn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTradeVenueCriteria1Choice_? ExecutionVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTradeVenueCriteria1Choice_? ExecutionVenue { get; init; } 
    #else
    public SecuritiesTradeVenueCriteria1Choice_? ExecutionVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the nature of the reporting counterparty (if is a CCP, a financial, non-financial counterparty or other type of counterparty).
    /// </summary>
    [IsoId("_bmONpdGREeaQk737TH1Fzw")]
    [DisplayName("Nature Of Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtrOfCtrPty")]
    #endif
    [IsoXmlTag("NtrOfCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyNatureType1Code? NatureOfCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyNatureType1Code? NatureOfCounterparty { get; init; } 
    #else
    public PartyNatureType1Code? NatureOfCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate sector of the reporting counterparty.
    /// </summary>
    [IsoId("_bmONp9GREeaQk737TH1Fzw")]
    [DisplayName("Corporate Sector")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpSctr")]
    #endif
    [IsoXmlTag("CorpSctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateSectorCriteria3? CorporateSector { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateSectorCriteria3? CorporateSector { get; init; } 
    #else
    public CorporateSectorCriteria3? CorporateSector { get; set; } 
    #endif
    
    /// <summary>
    /// Code list of available values for asset class criteria.
    /// </summary>
    [IsoId("_bmONqdGREeaQk737TH1Fzw")]
    [DisplayName("Asset Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstClss")]
    #endif
    [IsoXmlTag("AsstClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductType4Code? AssetClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductType4Code? AssetClass { get; init; } 
    #else
    public ProductType4Code? AssetClass { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the product classification of the reported transaction.
    /// </summary>
    [IsoId("_bmONq9GREeaQk737TH1Fzw")]
    [DisplayName("Product Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctClssfctn")]
    #endif
    [IsoXmlTag("PdctClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductClassificationCriteria1? ProductClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductClassificationCriteria1? ProductClassification { get; init; } 
    #else
    public ProductClassificationCriteria1? ProductClassification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
