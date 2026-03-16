// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Obligation10.
/// </summary>
[IsoId("_PpnCn4cSEe-U27oWwgmhCQ")]
[DisplayName("Settlement Obligation10")]
public record SettlementObligation10
{
    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax35Text? Description { get; init; }

    /// <summary>
    /// Net Position Price.
    /// </summary>
    [DisplayName("Net Position Price")]
    [IsoXmlTag("NetPosPric")]
    public Price14? NetPositionPrice { get; init; }

    /// <summary>
    /// Obligation Type.
    /// </summary>
    [DisplayName("Obligation Type")]
    [IsoXmlTag("OblgtnTp")]
    public ObligationType1Choice_? ObligationType { get; init; }

    /// <summary>
    /// Payment.
    /// </summary>
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Quantity.
    /// </summary>
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; }

    /// <summary>
    /// References.
    /// </summary>
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public Reference24? References { get; init; }

    /// <summary>
    /// Related Settlement Obligation Identification.
    /// </summary>
    [DisplayName("Related Settlement Obligation Identification")]
    [IsoXmlTag("RltdSttlmOblgtnId")]
    public IsoMax35Text? RelatedSettlementObligationIdentification { get; init; }

    /// <summary>
    /// Securities Movement Type.
    /// </summary>
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Settlement Amount.
    /// </summary>
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection27 SettlementAmount { get; init; }

    /// <summary>
    /// Settlement Date.
    /// </summary>
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required IsoISODate SettlementDate { get; init; }

    /// <summary>
    /// Trade Date.
    /// </summary>
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public IsoISODate? TradeDate { get; init; }

    /// <summary>
    /// Trading Currency.
    /// </summary>
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public CurrencyCode? TradingCurrency { get; init; }
}
