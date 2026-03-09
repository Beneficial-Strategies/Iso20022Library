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
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_0ubGbTbsEead9bDRE_1DAQ")]
[DisplayName("Delivering Parties And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeliveringPartiesAndAccount16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeliveringPartiesAndAccount16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeliveringPartiesAndAccount16( PartyIdentificationAndAccount147 reqDeliveringAgentDetails )
    {
        DeliveringAgentDetails = reqDeliveringAgentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_1Hj_IzbsEead9bDRE_1DAQ")]
    [DisplayName("Deliverers Custodian Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrrsCtdnDtls")]
    #endif
    [IsoXmlTag("DlvrrsCtdnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount147? DeliverersCustodianDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount147? DeliverersCustodianDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount147? DeliverersCustodianDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that the deliverer&apos;s custodian uses to effect the delivery of a security, when the deliverer&apos;s custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_1Hj_JTbsEead9bDRE_1DAQ")]
    [DisplayName("Deliverers Intermediary 1 Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrrsIntrmy1Dtls")]
    #endif
    [IsoXmlTag("DlvrrsIntrmy1Dtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount147? DeliverersIntermediary1Details { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount147? DeliverersIntermediary1Details { get; init; } 
    #else
    public PartyIdentificationAndAccount147? DeliverersIntermediary1Details { get; set; } 
    #endif
    
    /// <summary>
    /// Party that interacts with the deliverer&apos;s intermediary 1.
    /// </summary>
    [IsoId("_mGRlYThZEeaRwdGFv45qTQ")]
    [DisplayName("Deliverers Intermediary 2 Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrrsIntrmy2Dtls")]
    #endif
    [IsoXmlTag("DlvrrsIntrmy2Dtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount147? DeliverersIntermediary2Details { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount147? DeliverersIntermediary2Details { get; init; } 
    #else
    public PartyIdentificationAndAccount147? DeliverersIntermediary2Details { get; set; } 
    #endif
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, central securities depository.
    /// </summary>
    [IsoId("_1Hj_JzbsEead9bDRE_1DAQ")]
    [DisplayName("Delivering Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgAgtDtls")]
    #endif
    [IsoXmlTag("DlvrgAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount147 DeliveringAgentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount147 DeliveringAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount147 DeliveringAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount147 DeliveringAgentDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
