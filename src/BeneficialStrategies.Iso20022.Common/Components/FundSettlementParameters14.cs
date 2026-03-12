// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security.
/// </summary>
[IsoId("_zK2U0U3ZEeidB49bWZiS0g")]
[DisplayName("Fund Settlement Parameters")]
public partial record FundSettlementParameters14
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository or an International Central Securities Depository.
    /// </summary>
    [IsoId("_zaxAJU3ZEeidB49bWZiS0g")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Condition under which the order/trade is to be/was executed. This may be required for settlement through T2S.
    /// </summary>
    [IsoId("_zaxAKU3ZEeidB49bWZiS0g")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public TradeTransactionCondition8Choice_? TradeTransactionCondition { get; init; } 
    
    /// <summary>
    /// Condition under which the order/trade is to be settled. This may be required for settlement through T2S.
    /// </summary>
    [IsoId("_zaxALU3ZEeidB49bWZiS0g")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public SettlementTransactionCondition30Choice_? SettlementTransactionCondition { get; init; } 
    
    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    [IsoId("_zaxAJ03ZEeidB49bWZiS0g")]
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; } 
    
    /// <summary>
    /// Chain of receiving settlement parties.
    /// </summary>
    [IsoId("_zaxAL03ZEeidB49bWZiS0g")]
    [DisplayName("Receiving Side Details")]
    [IsoXmlTag("RcvgSdDtls")]
    public SettlementParties74? ReceivingSideDetails { get; init; } 
    
    /// <summary>
    /// Chain of delivering settlement parties.
    /// </summary>
    [IsoId("_zaxAMU3ZEeidB49bWZiS0g")]
    [DisplayName("Delivering Side Details")]
    [IsoXmlTag("DlvrgSdDtls")]
    public SettlementParties74? DeliveringSideDetails { get; init; } 
    
    
    #nullable disable
    
}
