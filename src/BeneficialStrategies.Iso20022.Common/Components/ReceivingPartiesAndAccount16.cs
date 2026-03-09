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
[IsoId("_1gjt9TbsEead9bDRE_1DAQ")]
[DisplayName("Receiving Parties And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReceivingPartiesAndAccount16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReceivingPartiesAndAccount16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReceivingPartiesAndAccount16( PartyIdentificationAndAccount147 reqReceivingAgentDetails )
    {
        ReceivingAgentDetails = reqReceivingAgentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_14z14zbsEead9bDRE_1DAQ")]
    [DisplayName("Receivers Custodian Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrsCtdnDtls")]
    #endif
    [IsoXmlTag("RcvrsCtdnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount147? ReceiversCustodianDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount147? ReceiversCustodianDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount147? ReceiversCustodianDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that the receiver&apos;s custodian uses to effect the receipt of a security, when the receiver&apos;s custodian does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_14z15TbsEead9bDRE_1DAQ")]
    [DisplayName("Receivers Intermediary 1 Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrsIntrmy1Dtls")]
    #endif
    [IsoXmlTag("RcvrsIntrmy1Dtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount147? ReceiversIntermediary1Details { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount147? ReceiversIntermediary1Details { get; init; } 
    #else
    public PartyIdentificationAndAccount147? ReceiversIntermediary1Details { get; set; } 
    #endif
    
    /// <summary>
    /// Party that interacts with the receiver’s intermediary 1.
    /// </summary>
    [IsoId("_SXUugThZEeaRwdGFv45qTQ")]
    [DisplayName("Receivers Intermediary 2 Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrsIntrmy2Dtls")]
    #endif
    [IsoXmlTag("RcvrsIntrmy2Dtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount147? ReceiversIntermediary2Details { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount147? ReceiversIntermediary2Details { get; init; } 
    #else
    public PartyIdentificationAndAccount147? ReceiversIntermediary2Details { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, for example, central securities depository.
    /// </summary>
    [IsoId("_14z15zbsEead9bDRE_1DAQ")]
    [DisplayName("Receiving Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgAgtDtls")]
    #endif
    [IsoXmlTag("RcvgAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount147 ReceivingAgentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount147 ReceivingAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount147 ReceivingAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount147 ReceivingAgentDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
