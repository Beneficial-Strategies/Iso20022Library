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
[IsoId("_VP5xZ9p-Ed-ak6NoX_4Aeg_2096007708")]
[DisplayName("Receiving Parties And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReceivingPartiesAndAccount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReceivingPartiesAndAccount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReceivingPartiesAndAccount1( InvestmentAccount11 reqReceiverDetails,PartyIdentificationAndAccount2 reqReceivingAgentDetails,PartyIdentificationAndAccount2 reqPlaceOfSettlementDetails )
    {
        ReceiverDetails = reqReceiverDetails;
        ReceivingAgentDetails = reqReceivingAgentDetails;
        PlaceOfSettlementDetails = reqPlaceOfSettlementDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_VP5xaNp-Ed-ak6NoX_4Aeg_1920137751")]
    [DisplayName("Receiver Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrDtls")]
    #endif
    [IsoXmlTag("RcvrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount11 ReceiverDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount11 ReceiverDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount11 ReceiverDetails { get; init; } 
    #else
    public InvestmentAccount11 ReceiverDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_VP5xadp-Ed-ak6NoX_4Aeg_-953327782")]
    [DisplayName("Receivers Custodian Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrsCtdnDtls")]
    #endif
    [IsoXmlTag("RcvrsCtdnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount2? ReceiversCustodianDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount2? ReceiversCustodianDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount2? ReceiversCustodianDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that the Receiver&apos;s custodian uses to effect the receipt of a security, when the Receiver&apos;s custodian does not have a direct relationship with the Receiver agent.
    /// </summary>
    [IsoId("_VP5xatp-Ed-ak6NoX_4Aeg_-962563141")]
    [DisplayName("Receivers Intermediary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrsIntrmyDtls")]
    #endif
    [IsoXmlTag("RcvrsIntrmyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount2? ReceiversIntermediaryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount2? ReceiversIntermediaryDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount2? ReceiversIntermediaryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, eg, securities central depository.
    /// </summary>
    [IsoId("_VP5xa9p-Ed-ak6NoX_4Aeg_-992117644")]
    [DisplayName("Receiving Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgAgtDtls")]
    #endif
    [IsoXmlTag("RcvgAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount2 ReceivingAgentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount2 ReceivingAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount2 ReceivingAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount2 ReceivingAgentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_VP5xbNp-Ed-ak6NoX_4Aeg_-796229294")]
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
    [IsoId("_VP5xbdp-Ed-ak6NoX_4Aeg_443129355")]
    [DisplayName("Place Of Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfSttlmDtls")]
    #endif
    [IsoXmlTag("PlcOfSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount2 PlaceOfSettlementDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount2 PlaceOfSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount2 PlaceOfSettlementDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount2 PlaceOfSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
