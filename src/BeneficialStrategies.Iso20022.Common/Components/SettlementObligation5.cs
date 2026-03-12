// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the settlement obligation.
/// </summary>
[IsoId("_-ezL8aMOEeCojJW5vEuTEQ_1121588279")]
[DisplayName("Settlement Obligation")]
public partial record SettlementObligation5
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of an existing obligation that is linked to the new obligation.
    /// </summary>
    [IsoId("_-ezL8qMOEeCojJW5vEuTEQ_1007749213")]
    [DisplayName("Related Settlement Obligation Identification")]
    [IsoXmlTag("RltdSttlmOblgtnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RelatedSettlementObligationIdentification { get; init; } 
    
    /// <summary>
    /// Indicates the type of the obligation.
    /// </summary>
    [IsoId("_-ezL86MOEeCojJW5vEuTEQ_10676860")]
    [DisplayName("Obligation Type")]
    [IsoXmlTag("OblgtnTp")]
    public ObligationType1Choice_? ObligationType { get; init; } 
    
    /// <summary>
    /// Provides additional information related to the linked obligation.
    /// </summary>
    [IsoId("_-ezL9KMOEeCojJW5vEuTEQ_-986395493")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Description { get; init; } 
    
    /// <summary>
    /// Provides the original trade date.
    /// </summary>
    [IsoId("_-ezL9aMOEeCojJW5vEuTEQ_-1983467846")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeDate { get; init; } 
    
    /// <summary>
    /// Specifies the quantity related to the settlement obligation.
    /// </summary>
    [IsoId("_-ezL9qMOEeCojJW5vEuTEQ_1428266163")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Provides the price applied to that net position.
    /// </summary>
    [IsoId("_-ezL96MOEeCojJW5vEuTEQ_431193810")]
    [DisplayName("Net Position Price")]
    [IsoXmlTag("NetPosPric")]
    public Price4? NetPositionPrice { get; init; } 
    
    /// <summary>
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    [IsoId("_-e888KMOEeCojJW5vEuTEQ_-565878543")]
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public CurrencyCode? TradingCurrency { get; init; } 
    
    /// <summary>
    /// Provides the total amount to be settled.
    /// </summary>
    [IsoId("_-e888aMOEeCojJW5vEuTEQ_-679717609")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection27 SettlementAmount { get; init; } 
    
    /// <summary>
    /// Provides the contractual settlement date.
    /// </summary>
    [IsoId("_-e888qMOEeCojJW5vEuTEQ_-1676789962")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SettlementDate { get; init; } 
    
    /// <summary>
    /// Indicates if the obligation will result in a receive or a delivery of securities.
    /// </summary>
    [IsoId("_-e8886MOEeCojJW5vEuTEQ_1734944047")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    
    /// <summary>
    /// Specifies how the transaction is to be settled.
    /// </summary>
    [IsoId("_-e889KMOEeCojJW5vEuTEQ_1621104981")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; } 
    
    /// <summary>
    /// Provides the references of the underlying trade leg(s) and/or the reference to the related net position message.
    /// </summary>
    [IsoId("_-e889aMOEeCojJW5vEuTEQ_624032628")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public Reference19? References { get; init; } 
    
    
    #nullable disable
    
}
