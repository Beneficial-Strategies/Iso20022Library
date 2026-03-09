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
[IsoId("_ahZU0a1TEemkQYpo6COeTA")]
[DisplayName("Trade Party Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradePartyQueryCriteria5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradePartyQueryCriteria5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradePartyQueryCriteria5( Operation3Code reqOperator )
    {
        Operator = reqOperator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the AND/OR operators as query criteria.
    /// </summary>
    [IsoId("_alkDI61TEemkQYpo6COeTA")]
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
    [IsoId("_alkDJa1TEemkQYpo6COeTA")]
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
    /// Data specific to branch of the reporting counterparty and related fields.
    /// </summary>
    [IsoId("_alkDJ61TEemkQYpo6COeTA")]
    [DisplayName("Reporting Counterparty Branch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPtyBrnch")]
    #endif
    [IsoXmlTag("RptgCtrPtyBrnch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentificationQuery9? ReportingCounterpartyBranch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentificationQuery9? ReportingCounterpartyBranch { get; init; } 
    #else
    public TradePartyIdentificationQuery9? ReportingCounterpartyBranch { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the other counterparty of the contract.
    /// </summary>
    [IsoId("_alkDKa1TEemkQYpo6COeTA")]
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
    /// Data specific to branch of the other reporting counterparty and related fields.
    /// </summary>
    [IsoId("_alkDK61TEemkQYpo6COeTA")]
    [DisplayName("Other Counterparty Branch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPtyBrnch")]
    #endif
    [IsoXmlTag("OthrCtrPtyBrnch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentificationQuery9? OtherCounterpartyBranch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentificationQuery9? OtherCounterpartyBranch { get; init; } 
    #else
    public TradePartyIdentificationQuery9? OtherCounterpartyBranch { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party subject to the rights and obligations arising from the contract.
    /// </summary>
    [IsoId("_alkDLa1TEemkQYpo6COeTA")]
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
    /// Identifies the submitting agent of the reported of the contract.
    /// </summary>
    [IsoId("_alkDL61TEemkQYpo6COeTA")]
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
    [IsoId("_alkDMa1TEemkQYpo6COeTA")]
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
    [IsoId("_alkDM61TEemkQYpo6COeTA")]
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
    /// Identification of the agent lender involved in the securities lending transaction.
    /// </summary>
    [IsoId("_NRqOsq60EemZxoEFHjN-AQ")]
    [DisplayName("Agent Lender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtLndr")]
    #endif
    [IsoXmlTag("AgtLndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentificationQuery8? AgentLender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentificationQuery8? AgentLender { get; init; } 
    #else
    public TradePartyIdentificationQuery8? AgentLender { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the third party that administers the transaction.
    /// </summary>
    [IsoId("_NRqOs660EemZxoEFHjN-AQ")]
    [DisplayName("Triparty Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgt")]
    #endif
    [IsoXmlTag("TrptyAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentificationQuery8? TripartyAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentificationQuery8? TripartyAgent { get; init; } 
    #else
    public TradePartyIdentificationQuery8? TripartyAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
