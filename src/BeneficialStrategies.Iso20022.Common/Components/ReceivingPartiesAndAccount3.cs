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
[IsoId("_QVfs5tp-Ed-ak6NoX_4Aeg_-686973332")]
[DisplayName("Receiving Parties And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReceivingPartiesAndAccount3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReceivingPartiesAndAccount3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReceivingPartiesAndAccount3( PartyIdentificationAndAccount3 reqReceivingAgentDetails )
    {
        ReceivingAgentDetails = reqReceivingAgentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_QVfs59p-Ed-ak6NoX_4Aeg_-686973288")]
    [DisplayName("Receivers Custodian Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrsCtdnDtls")]
    #endif
    [IsoXmlTag("RcvrsCtdnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount3? ReceiversCustodianDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount3? ReceiversCustodianDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount3? ReceiversCustodianDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that the Receiver&apos;s custodian uses to effect the receipt of a security, when the Receiver&apos;s custodian does not have a direct relationship with the Receiver agent.
    /// </summary>
    [IsoId("_QVfs6Np-Ed-ak6NoX_4Aeg_-686973254")]
    [DisplayName("Receivers Intermediary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrsIntrmyDtls")]
    #endif
    [IsoXmlTag("RcvrsIntrmyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount3? ReceiversIntermediaryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount3? ReceiversIntermediaryDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount3? ReceiversIntermediaryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, eg, central securities depository.
    /// </summary>
    [IsoId("_QVfs6dp-Ed-ak6NoX_4Aeg_-686973236")]
    [DisplayName("Receiving Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgAgtDtls")]
    #endif
    [IsoXmlTag("RcvgAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount3 ReceivingAgentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount3 ReceivingAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount3 ReceivingAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount3 ReceivingAgentDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
