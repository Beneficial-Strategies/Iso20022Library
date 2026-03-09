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
[IsoId("_G-NuISStEeWEdM0tuoNJdg")]
[DisplayName("Receiving Parties And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReceivingPartiesAndAccount14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReceivingPartiesAndAccount14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReceivingPartiesAndAccount14( PartyIdentificationAndAccount123 reqReceivingAgentDetails )
    {
        ReceivingAgentDetails = reqReceivingAgentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_HbFQVyStEeWEdM0tuoNJdg")]
    [DisplayName("Receivers Custodian Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrsCtdnDtls")]
    #endif
    [IsoXmlTag("RcvrsCtdnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount124? ReceiversCustodianDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount124? ReceiversCustodianDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount124? ReceiversCustodianDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that the receiver&apos;s custodian uses to effect the receipt of a security, when the receiver&apos;s custodian does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_HbFQWSStEeWEdM0tuoNJdg")]
    [DisplayName("Receivers Intermediary 1 Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrsIntrmy1Dtls")]
    #endif
    [IsoXmlTag("RcvrsIntrmy1Dtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount124? ReceiversIntermediary1Details { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount124? ReceiversIntermediary1Details { get; init; } 
    #else
    public PartyIdentificationAndAccount124? ReceiversIntermediary1Details { get; set; } 
    #endif
    
    /// <summary>
    /// Party that interacts with the receiver’s intermediary.
    /// </summary>
    [IsoId("_HbFQWyStEeWEdM0tuoNJdg")]
    [DisplayName("Receivers Intermediary 2 Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrsIntrmy2Dtls")]
    #endif
    [IsoXmlTag("RcvrsIntrmy2Dtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount124? ReceiversIntermediary2Details { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount124? ReceiversIntermediary2Details { get; init; } 
    #else
    public PartyIdentificationAndAccount124? ReceiversIntermediary2Details { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    [IsoId("_HbFQXSStEeWEdM0tuoNJdg")]
    [DisplayName("Receiving Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgAgtDtls")]
    #endif
    [IsoXmlTag("RcvgAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount123 ReceivingAgentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount123 ReceivingAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount123 ReceivingAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount123 ReceivingAgentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_HbFQXyStEeWEdM0tuoNJdg")]
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
    [IsoId("_HbFQYSStEeWEdM0tuoNJdg")]
    [DisplayName("Place Of Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfSttlmDtls")]
    #endif
    [IsoXmlTag("PlcOfSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification97? PlaceOfSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification97? PlaceOfSettlementDetails { get; init; } 
    #else
    public PartyIdentification97? PlaceOfSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
