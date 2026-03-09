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
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
[IsoId("_4Nxqe_soEeCFJsO61PplcQ")]
[DisplayName("Delivering Parties And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeliveringPartiesAndAccount8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeliveringPartiesAndAccount8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeliveringPartiesAndAccount8( PartyIdentificationAndAccount4 reqDeliveringAgentDetails )
    {
        DeliveringAgentDetails = reqDeliveringAgentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_4NxqifsoEeCFJsO61PplcQ")]
    [DisplayName("Deliverer Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrrDtls")]
    #endif
    [IsoXmlTag("DlvrrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount24? DelivererDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount24? DelivererDetails { get; init; } 
    #else
    public InvestmentAccount24? DelivererDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_4NxqjfsoEeCFJsO61PplcQ")]
    [DisplayName("Deliverers Custodian Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrrsCtdnDtls")]
    #endif
    [IsoXmlTag("DlvrrsCtdnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount5? DeliverersCustodianDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount5? DeliverersCustodianDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount5? DeliverersCustodianDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that the deliverer&apos;s custodian uses to effect the delivery of a security, when the deliverer&apos;s custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_4NxqkfsoEeCFJsO61PplcQ")]
    [DisplayName("Deliverers Intermediary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrrsIntrmyDtls")]
    #endif
    [IsoXmlTag("DlvrrsIntrmyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount5? DeliverersIntermediaryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount5? DeliverersIntermediaryDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount5? DeliverersIntermediaryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, eg, central securities depository.
    /// </summary>
    [IsoId("_4NxqlfsoEeCFJsO61PplcQ")]
    [DisplayName("Delivering Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgAgtDtls")]
    #endif
    [IsoXmlTag("DlvrgAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount4 DeliveringAgentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount4 DeliveringAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount4 DeliveringAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount4 DeliveringAgentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_4NxqmfsoEeCFJsO61PplcQ")]
    [DisplayName("Securities Settlement System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesSttlmSys")]
    #endif
    [IsoXmlTag("SctiesSttlmSys")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesSettlementSystem { get; init; } 
    #else
    public System.String? SecuritiesSettlementSystem { get; set; } 
    #endif
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_4NxqnfsoEeCFJsO61PplcQ")]
    [DisplayName("Place Of Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfSttlmDtls")]
    #endif
    [IsoXmlTag("PlcOfSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification21? PlaceOfSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification21? PlaceOfSettlementDetails { get; init; } 
    #else
    public PartyIdentification21? PlaceOfSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
