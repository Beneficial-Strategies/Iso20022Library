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
[IsoId("_0QyaoU4EEeiQHa-q1Uephw")]
[DisplayName("Fund Settlement Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundSettlementParameters13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository or an International Central Securities Depository.
    /// </summary>
    [IsoId("_0jUVEU4EEeiQHa-q1Uephw")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Condition under which the order/trade is to be/was executed. This may be required for settlement through T2S.
    /// </summary>
    [IsoId("_0jUVE04EEeiQHa-q1Uephw")]
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
    [IsoId("_0jUVF04EEeiQHa-q1Uephw")]
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
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    [IsoId("_0jUVGU4EEeiQHa-q1Uephw")]
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
    /// Chain of receiving settlement parties.
    /// </summary>
    [IsoId("_0jUVG04EEeiQHa-q1Uephw")]
    [DisplayName("Receiving Side Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSdDtls")]
    #endif
    [IsoXmlTag("RcvgSdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties74? ReceivingSideDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties74? ReceivingSideDetails { get; init; } 
    #else
    public SettlementParties74? ReceivingSideDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
