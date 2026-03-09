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
/// Specifies additional information as expected by the party that the investigation performs the expected actions for its resolution.
/// </summary>
[IsoId("_L1v_MRlbEe2Do_UtrNmb2g")]
[DisplayName("Resolution Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResolutionData4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_L_GvgRlbEe2Do_UtrNmb2g")]
    [DisplayName("End To End Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndToEndId")]
    #endif
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? EndToEndIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EndToEndIdentification { get; init; } 
    #else
    public System.String? EndToEndIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("_L_GvgxlbEe2Do_UtrNmb2g")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionIdentification { get; init; } 
    #else
    public System.String? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_L_GvhRlbEe2Do_UtrNmb2g")]
    [DisplayName("UETR")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UETR")]
    #endif
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoUUIDv4Identifier? UETR { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UETR { get; init; } 
    #else
    public System.String? UETR { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_L_GvhxlbEe2Do_UtrNmb2g")]
    [DisplayName("Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("IntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_L_GviRlbEe2Do_UtrNmb2g")]
    [DisplayName("Interbank Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmDt")]
    #endif
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? InterbankSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? InterbankSettlementDate { get; init; } 
    #else
    public System.DateOnly? InterbankSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    [IsoId("_L_GvixlbEe2Do_UtrNmb2g")]
    [DisplayName("Clearing Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrChanl")]
    #endif
    [IsoXmlTag("ClrChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingChannel2Code? ClearingChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingChannel2Code? ClearingChannel { get; init; } 
    #else
    public ClearingChannel2Code? ClearingChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the compensation made due to the modification or cancellation of a previous payment.
    /// </summary>
    [IsoId("_L_GvjRlbEe2Do_UtrNmb2g")]
    [DisplayName("Compensation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Compstn")]
    #endif
    [IsoXmlTag("Compstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Compensation4? Compensation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Compensation4? Compensation { get; init; } 
    #else
    public Compensation4? Compensation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("_fMDFgRlbEe2Do_UtrNmb2g")]
    [DisplayName("Charges Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsInf")]
    #endif
    [IsoXmlTag("ChrgsInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charges13? ChargesInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charges13? ChargesInformation { get; init; } 
    #else
    public Charges13? ChargesInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
