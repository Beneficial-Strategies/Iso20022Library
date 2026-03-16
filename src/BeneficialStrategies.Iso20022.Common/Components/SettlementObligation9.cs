// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Obligation9.
/// </summary>
[IsoId("_PidRpYcSEe-U27oWwgmhCQ")]
[DisplayName("Settlement Obligation9")]
public record SettlementObligation9
{
    /// <summary>
    /// Additional Settlement Obligation Details.
    /// </summary>
    [DisplayName("Additional Settlement Obligation Details")]
    [IsoXmlTag("AddtlSttlmOblgtnDtls")]
    public ValueList<SettlementObligation10> AdditionalSettlementObligationDetails { get; init; } =
        [];

    /// <summary>
    /// Clearing Account Type.
    /// </summary>
    [DisplayName("Clearing Account Type")]
    [IsoXmlTag("ClrAcctTp")]
    public ClearingAccountType1Code? ClearingAccountType { get; init; }

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification48 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Intended Settlement Date.
    /// </summary>
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    public required DateFormat65Choice_ IntendedSettlementDate { get; init; }

    /// <summary>
    /// Payment.
    /// </summary>
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Place Of Trade.
    /// </summary>
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public required MarketIdentification84 PlaceOfTrade { get; init; }

    /// <summary>
    /// Quantity.
    /// </summary>
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; }

    /// <summary>
    /// Safekeeping Account.
    /// </summary>
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Safekeeping Place.
    /// </summary>
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat43Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Securities Movement Type.
    /// </summary>
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public ReceiveDelivery1Code? SecuritiesMovementType { get; init; }

    /// <summary>
    /// Settlement Amount.
    /// </summary>
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection27 SettlementAmount { get; init; }

    /// <summary>
    /// Settlement Obligation Identification.
    /// </summary>
    [DisplayName("Settlement Obligation Identification")]
    [IsoXmlTag("SttlmOblgtnId")]
    public required IsoMax35Text SettlementObligationIdentification { get; init; }

    /// <summary>
    /// Settlement Parties.
    /// </summary>
    [DisplayName("Settlement Parties")]
    [IsoXmlTag("SttlmPties")]
    public SettlementParties38Choice_? SettlementParties { get; init; }

    /// <summary>
    /// Trade Date.
    /// </summary>
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate3Choice_? TradeDate { get; init; }

    /// <summary>
    /// Trading Capacity.
    /// </summary>
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public TradingCapacity5Code? TradingCapacity { get; init; }
}
