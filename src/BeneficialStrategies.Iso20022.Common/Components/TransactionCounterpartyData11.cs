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
/// Specifies the details related to the parties involved in the securities lending transaction.
/// </summary>
[IsoId("_Z3Woocg4Eeu4ecZgAYuz5w")]
[DisplayName("Transaction Counterparty Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionCounterpartyData11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the beneficiary who is subject to the rights and obligations arising from the contract.
    /// </summary>
    [IsoId("_Z5G8I8g4Eeu4ecZgAYuz5w")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification236Choice_? Beneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification236Choice_? Beneficiary { get; init; } 
    #else
    public PartyIdentification236Choice_? Beneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the third party that administers the transaction.
    /// </summary>
    [IsoId("_Z5G8Jcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Triparty Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgt")]
    #endif
    [IsoXmlTag("TrptyAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? TripartyAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? TripartyAgent { get; init; } 
    #else
    public OrganisationIdentification15Choice_? TripartyAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the broker involved in the securities lending transaction.
    /// </summary>
    [IsoId("_Z5G8J8g4Eeu4ecZgAYuz5w")]
    [DisplayName("Broker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brkr")]
    #endif
    [IsoXmlTag("Brkr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? Broker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? Broker { get; init; } 
    #else
    public OrganisationIdentification15Choice_? Broker { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the clearing member in the case where the trade is cleared.
    /// </summary>
    [IsoId("_Z5G8Kcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMmb")]
    #endif
    [IsoXmlTag("ClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? ClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? ClearingMember { get; init; } 
    #else
    public OrganisationIdentification15Choice_? ClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the parties settling the contract on behalf of the deliverer or receiver.
    /// </summary>
    [IsoId("_Z5G8K8g4Eeu4ecZgAYuz5w")]
    [DisplayName("Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPties")]
    #endif
    [IsoXmlTag("SttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties34Choice_? SettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties34Choice_? SettlementParties { get; init; } 
    #else
    public SettlementParties34Choice_? SettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the agent lender involved in the securities lending transaction.
    /// </summary>
    [IsoId("_Z5G8Lcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Agent Lender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtLndr")]
    #endif
    [IsoXmlTag("AgtLndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? AgentLender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? AgentLender { get; init; } 
    #else
    public OrganisationIdentification15Choice_? AgentLender { get; set; } 
    #endif
    
    
    #nullable disable
    
}
