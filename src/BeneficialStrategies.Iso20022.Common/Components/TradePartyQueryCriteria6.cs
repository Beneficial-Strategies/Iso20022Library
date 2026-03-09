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
/// Details on the queried trade parties.
/// </summary>
[IsoId("_v8mgsZNYEeytjZlcgApf6A")]
[DisplayName("Trade Party Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradePartyQueryCriteria6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradePartyQueryCriteria6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradePartyQueryCriteria6( Operation3Code reqOperator )
    {
        Operator = reqOperator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the AND/OR operators as query criteria.
    /// </summary>
    [IsoId("_v-O4Y5NYEeytjZlcgApf6A")]
    [DisplayName("Operator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oprtr")]
    #endif
    [IsoXmlTag("Oprtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Operation3Code Operator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Operation3Code Operator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Operation3Code Operator { get; init; } 
    #else
    public Operation3Code Operator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the reporting counterparty of the contract.
    /// </summary>
    [IsoId("_v-O4ZZNYEeytjZlcgApf6A")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentificationQuery8? ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentificationQuery8? ReportingCounterparty { get; init; } 
    #else
    public TradePartyIdentificationQuery8? ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the other counterparty of the contract.
    /// </summary>
    [IsoId("_v-O4Z5NYEeytjZlcgApf6A")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentificationQuery8? OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentificationQuery8? OtherCounterparty { get; init; } 
    #else
    public TradePartyIdentificationQuery8? OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party subject to the rights and obligations arising from the contract.
    /// </summary>
    [IsoId("_v-O4aZNYEeytjZlcgApf6A")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentificationQuery8? Beneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentificationQuery8? Beneficiary { get; init; } 
    #else
    public TradePartyIdentificationQuery8? Beneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the entity in the case where a financial counterparty is responsible for reporting on behalf of the other counterparty.
    /// </summary>
    [IsoId("_4b3MAJNYEeytjZlcgApf6A")]
    [DisplayName("Entity Responsible For Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NttyRspnsblForRpt")]
    #endif
    [IsoXmlTag("NttyRspnsblForRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentificationQuery8? EntityResponsibleForReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentificationQuery8? EntityResponsibleForReport { get; init; } 
    #else
    public TradePartyIdentificationQuery8? EntityResponsibleForReport { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the submitting agent of the reported of the contract.
    /// </summary>
    [IsoId("_v-O4a5NYEeytjZlcgApf6A")]
    [DisplayName("Submitting Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitgAgt")]
    #endif
    [IsoXmlTag("SubmitgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentificationQuery8? SubmittingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentificationQuery8? SubmittingAgent { get; init; } 
    #else
    public TradePartyIdentificationQuery8? SubmittingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the broker who acts as an intermediary for the reporting counterparty.
    /// </summary>
    [IsoId("_v-O4bZNYEeytjZlcgApf6A")]
    [DisplayName("Broker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brkr")]
    #endif
    [IsoXmlTag("Brkr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentificationQuery8? Broker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentificationQuery8? Broker { get; init; } 
    #else
    public TradePartyIdentificationQuery8? Broker { get; set; } 
    #endif
    
    /// <summary>
    /// Unique code for the CCP that has cleared the contract.
    /// </summary>
    [IsoId("_v-O4b5NYEeytjZlcgApf6A")]
    [DisplayName("CCP")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CCP")]
    #endif
    [IsoXmlTag("CCP")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentificationQuery8? CCP { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentificationQuery8? CCP { get; init; } 
    #else
    public TradePartyIdentificationQuery8? CCP { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the clearing member through which a derivative transaction is cleared at a central counterparty (CCP).  The element applies to transactions under the agency clearing model and the principal clearing model.
    /// </summary>
    [IsoId("_Uv_I8JNZEeytjZlcgApf6A")]
    [DisplayName("Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMmb")]
    #endif
    [IsoXmlTag("ClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentificationQuery8? ClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentificationQuery8? ClearingMember { get; init; } 
    #else
    public TradePartyIdentificationQuery8? ClearingMember { get; set; } 
    #endif
    
    
    #nullable disable
    
}
