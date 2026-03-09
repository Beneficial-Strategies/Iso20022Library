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
/// Identification of a settlement party by a choice between a BIC or a name and address.
/// </summary>
[IsoId("_S4bqgAEcEeCQm6a_G2yO_w_-1857619750")]
[DisplayName("Settlement Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementParties9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementParties9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementParties9( PartyIdentification19Choice_ reqReceivingAgent )
    {
        ReceivingAgent = reqReceivingAgent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial institution from which cash will be transferred.
    /// </summary>
    [IsoId("_S4bqgQEcEeCQm6a_G2yO_w_-1971458816")]
    [DisplayName("Delivery Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryAgt")]
    #endif
    [IsoXmlTag("DlvryAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification19Choice_? DeliveryAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification19Choice_? DeliveryAgent { get; init; } 
    #else
    public PartyIdentification19Choice_? DeliveryAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party, within the settlement chain, between the delivery and receiving agents.
    /// </summary>
    [IsoId("_S4bqggEcEeCQm6a_G2yO_w_1326436127")]
    [DisplayName("Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrmy")]
    #endif
    [IsoXmlTag("Intrmy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification19Choice_? Intermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification19Choice_? Intermediary { get; init; } 
    #else
    public PartyIdentification19Choice_? Intermediary { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution where the payee will receive the funds.
    /// </summary>
    [IsoId("_S4bqgwEcEeCQm6a_G2yO_w_329363774")]
    [DisplayName("Receiving Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgAgt")]
    #endif
    [IsoXmlTag("RcvgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification19Choice_ ReceivingAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification19Choice_ ReceivingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification19Choice_ ReceivingAgent { get; init; } 
    #else
    public PartyIdentification19Choice_ ReceivingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate institution that will receive the funds when different than the trading or counterparty side.
    /// </summary>
    [IsoId("_S4bqhAEcEeCQm6a_G2yO_w_-667708579")]
    [DisplayName("Beneficiary Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryInstn")]
    #endif
    [IsoXmlTag("BnfcryInstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification19Choice_? BeneficiaryInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification19Choice_? BeneficiaryInstitution { get; init; } 
    #else
    public PartyIdentification19Choice_? BeneficiaryInstitution { get; set; } 
    #endif
    
    
    #nullable disable
    
}
