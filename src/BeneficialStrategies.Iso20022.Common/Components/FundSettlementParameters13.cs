// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security.
/// </summary>
[IsoId("_0QyaoU4EEeiQHa-q1Uephw")]
[DisplayName("Fund Settlement Parameters")]
public record FundSettlementParameters13
{
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository or an International Central Securities Depository.
    /// </summary>
    [IsoId("_0jUVEU4EEeiQHa-q1Uephw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Condition under which the order/trade is to be/was executed. This may be required for settlement through T2S.
    /// </summary>
    [IsoId("_0jUVE04EEeiQHa-q1Uephw")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public TradeTransactionCondition8Choice_? TradeTransactionCondition { get; init; }

    /// <summary>
    /// Condition under which the order/trade is to be settled. This may be required for settlement through T2S.
    /// </summary>
    [IsoId("_0jUVF04EEeiQHa-q1Uephw")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public SettlementTransactionCondition30Choice_? SettlementTransactionCondition { get; init; }

    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    [IsoId("_0jUVGU4EEeiQHa-q1Uephw")]
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; }

    /// <summary>
    /// Chain of receiving settlement parties.
    /// </summary>
    [IsoId("_0jUVG04EEeiQHa-q1Uephw")]
    [DisplayName("Receiving Side Details")]
    [IsoXmlTag("RcvgSdDtls")]
    public SettlementParties74? ReceivingSideDetails { get; init; }
}
