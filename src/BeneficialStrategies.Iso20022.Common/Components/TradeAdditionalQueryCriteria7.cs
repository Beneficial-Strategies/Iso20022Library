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
[IsoId("_QWIcTa5pEeuo-IflVgGqiA")]
[DisplayName("Trade Additional Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeAdditionalQueryCriteria7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Action types allowed as query criteria.
    /// </summary>
    [IsoId("_Qlef065pEeuo-IflVgGqiA")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionOperationType6Code? ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionOperationType6Code? ActionType { get; init; } 
    #else
    public TransactionOperationType6Code? ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the execution venue of the reported transaction.
    /// </summary>
    [IsoId("_Qlef1a5pEeuo-IflVgGqiA")]
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
    /// Indicates the nature of the reporting counterparty (if it is a central counterparty (CCP), a financial counterparty, a non-financial counterparty or another type of counterparty).
    /// </summary>
    [IsoId("_Qlef165pEeuo-IflVgGqiA")]
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
    [IsoId("_Qlef2a5pEeuo-IflVgGqiA")]
    [DisplayName("Corporate Sector")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpSctr")]
    #endif
    [IsoXmlTag("CorpSctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateSectorCriteria5? CorporateSector { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateSectorCriteria5? CorporateSector { get; init; } 
    #else
    public CorporateSectorCriteria5? CorporateSector { get; set; } 
    #endif
    
    
    #nullable disable
    
}
