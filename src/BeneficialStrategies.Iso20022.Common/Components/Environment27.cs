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
/// Environment of the transaction.
/// </summary>
[IsoId("_hctRgYzREeutDIMngNCnkg")]
[DisplayName("Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Environment27
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// financial institution (or its agent) at which the accounts are held by the parties settling. This institution, acting on information provided by the parties, transfers the appropriate funds between the accounts.
    /// </summary>
    [IsoId("_hiABMYzREeutDIMngNCnkg")]
    [DisplayName("Settlement Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmInstn")]
    #endif
    [IsoXmlTag("SttlmInstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? SettlementInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? SettlementInstitution { get; init; } 
    #else
    public PartyIdentification263? SettlementInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_p63JkYzREeutDIMngNCnkg")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Originator { get; init; } 
    #else
    public PartyIdentification263? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the destination.
    /// </summary>
    [IsoId("_hiABM4zREeutDIMngNCnkg")]
    [DisplayName("Sender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sndr")]
    #endif
    [IsoXmlTag("Sndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Sender { get; init; } 
    #else
    public PartyIdentification263? Sender { get; set; } 
    #endif
    
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_hiABNYzREeutDIMngNCnkg")]
    [DisplayName("Receiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcvr")]
    #endif
    [IsoXmlTag("Rcvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Receiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Receiver { get; init; } 
    #else
    public PartyIdentification263? Receiver { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_rtTXkYzREeutDIMngNCnkg")]
    [DisplayName("Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dstn")]
    #endif
    [IsoXmlTag("Dstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Destination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Destination { get; init; } 
    #else
    public PartyIdentification263? Destination { get; set; } 
    #endif
    
    /// <summary>
    /// Financial Institution to which the settlement totals apply.
    /// </summary>
    [IsoId("_hiABN4zREeutDIMngNCnkg")]
    [DisplayName("Financial Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FI")]
    #endif
    [IsoXmlTag("FI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitution6? FinancialInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitution6? FinancialInstitution { get; init; } 
    #else
    public FinancialInstitution6? FinancialInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Additional institution involved in settlement. For example, the other party involved in bilateral settlement agreement.
    /// </summary>
    [IsoId("_hiABOYzREeutDIMngNCnkg")]
    [DisplayName("Other Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrInstn")]
    #endif
    [IsoXmlTag("OthrInstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification258? OtherInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification258? OtherInstitution { get; init; } 
    #else
    public PartyIdentification258? OtherInstitution { get; set; } 
    #endif
    
    
    #nullable disable
    
}
