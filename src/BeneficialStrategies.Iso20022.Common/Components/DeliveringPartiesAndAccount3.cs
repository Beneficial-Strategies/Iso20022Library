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
[IsoId("_QVMK5tp-Ed-ak6NoX_4Aeg_349216301")]
[DisplayName("Delivering Parties And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeliveringPartiesAndAccount3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeliveringPartiesAndAccount3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeliveringPartiesAndAccount3( PartyIdentificationAndAccount3 reqDeliveringAgentDetails )
    {
        DeliveringAgentDetails = reqDeliveringAgentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_QVMK59p-Ed-ak6NoX_4Aeg_349216345")]
    [DisplayName("Deliverers Custodian Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrrsCtdnDtls")]
    #endif
    [IsoXmlTag("DlvrrsCtdnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount3? DeliverersCustodianDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount3? DeliverersCustodianDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount3? DeliverersCustodianDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that the deliverer&apos;s custodian uses to effect the delivery of a security, when the deliverer&apos;s custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_QVMK6Np-Ed-ak6NoX_4Aeg_349216362")]
    [DisplayName("Deliverers Intermediary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrrsIntrmyDtls")]
    #endif
    [IsoXmlTag("DlvrrsIntrmyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount3? DeliverersIntermediaryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount3? DeliverersIntermediaryDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount3? DeliverersIntermediaryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, eg, central securities depository.
    /// </summary>
    [IsoId("_QVMK6dp-Ed-ak6NoX_4Aeg_349216397")]
    [DisplayName("Delivering Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgAgtDtls")]
    #endif
    [IsoXmlTag("DlvrgAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount3 DeliveringAgentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount3 DeliveringAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount3 DeliveringAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount3 DeliveringAgentDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
