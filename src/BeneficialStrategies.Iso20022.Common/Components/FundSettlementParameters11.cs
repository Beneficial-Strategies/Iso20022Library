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
/// Parameters applied to the settlement of a security.
/// </summary>
[IsoId("_0UrwwzbsEead9bDRE_1DAQ")]
[DisplayName("Fund Settlement Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundSettlementParameters11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundSettlementParameters11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundSettlementParameters11( PartyIdentification113 reqSettlementPlace,ReceivingPartiesAndAccount16 reqReceivingSideDetails )
    {
        SettlementPlace = reqSettlementPlace;
        ReceivingSideDetails = reqReceivingSideDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_0ubGYTbsEead9bDRE_1DAQ")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SettlementDate { get; init; } 
    #else
    public System.DateOnly? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the settlement of the transaction will take place. In the context of investment funds, the place of settlement is the transfer agent, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_0ubGYzbsEead9bDRE_1DAQ")]
    [DisplayName("Settlement Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPlc")]
    #endif
    [IsoXmlTag("SttlmPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification113 SettlementPlace { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification113 SettlementPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification113 SettlementPlace { get; init; } 
    #else
    public PartyIdentification113 SettlementPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository or an International Central Securities Depository.
    /// </summary>
    [IsoId("_0ubGZTbsEead9bDRE_1DAQ")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    [IsoId("_0ubGZzbsEead9bDRE_1DAQ")]
    [DisplayName("Securities Settlement System Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesSttlmSysId")]
    #endif
    [IsoXmlTag("SctiesSttlmSysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesSettlementSystemIdentification { get; init; } 
    #else
    public System.String? SecuritiesSettlementSystemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Condition under which the order/trade is to be/was executed. This may be required for settlement through T2S.
    /// </summary>
    [IsoId("_DOcXIl-mEeavlvCtut5bgg")]
    [DisplayName("Trade Transaction Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradTxCond")]
    #endif
    [IsoXmlTag("TradTxCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeTransactionCondition8Choice_? TradeTransactionCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransactionCondition8Choice_? TradeTransactionCondition { get; init; } 
    #else
    public TradeTransactionCondition8Choice_? TradeTransactionCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Condition under which the order/trade is to be settled. This may be required for settlement through T2S.
    /// </summary>
    [IsoId("_fcOBMUdMEeaBWtcfqEyXyw")]
    [DisplayName("Settlement Transaction Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTxCond")]
    #endif
    [IsoXmlTag("SttlmTxCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTransactionCondition30Choice_? SettlementTransactionCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTransactionCondition30Choice_? SettlementTransactionCondition { get; init; } 
    #else
    public SettlementTransactionCondition30Choice_? SettlementTransactionCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("_0ubGaTbsEead9bDRE_1DAQ")]
    [DisplayName("Receiving Side Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSdDtls")]
    #endif
    [IsoXmlTag("RcvgSdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReceivingPartiesAndAccount16 ReceivingSideDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReceivingPartiesAndAccount16 ReceivingSideDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceivingPartiesAndAccount16 ReceivingSideDetails { get; init; } 
    #else
    public ReceivingPartiesAndAccount16 ReceivingSideDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("_0ubGazbsEead9bDRE_1DAQ")]
    [DisplayName("Delivering Side Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSdDtls")]
    #endif
    [IsoXmlTag("DlvrgSdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveringPartiesAndAccount16? DeliveringSideDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveringPartiesAndAccount16? DeliveringSideDetails { get; init; } 
    #else
    public DeliveringPartiesAndAccount16? DeliveringSideDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
