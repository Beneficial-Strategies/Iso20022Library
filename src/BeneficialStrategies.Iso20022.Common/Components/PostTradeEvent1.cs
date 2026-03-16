// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Post Trade Event1.
/// </summary>
[IsoId("_YgrCIEj-Ee-KhcStGV4xTg")]
[DisplayName("Post Trade Event1")]
public record PostTradeEvent1
{
    /// <summary>
    /// Original Reference.
    /// </summary>
    [DisplayName("Original Reference")]
    [IsoXmlTag("OrgnlRef")]
    public required IsoMax35Text OriginalReference { get; init; }

    /// <summary>
    /// Outstanding Settlement Amount.
    /// </summary>
    [DisplayName("Outstanding Settlement Amount")]
    [IsoXmlTag("OutsdngSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OutstandingSettlementAmount { get; init; }

    /// <summary>
    /// Profit Or Loss.
    /// </summary>
    [DisplayName("Profit Or Loss")]
    [IsoXmlTag("PrftOrLoss")]
    public ProfitAndLossAmount2? ProfitOrLoss { get; init; }

    /// <summary>
    /// Profit Or Loss Settlement Date.
    /// </summary>
    [DisplayName("Profit Or Loss Settlement Date")]
    [IsoXmlTag("PrftOrLossSttlmDt")]
    public IsoISODate? ProfitOrLossSettlementDate { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PostTradeEventType2Choice_ Type { get; init; }

    /// <summary>
    /// Underlying Liability Reference.
    /// </summary>
    [DisplayName("Underlying Liability Reference")]
    [IsoXmlTag("UndrlygLbltyRef")]
    public IsoMax35Text? UnderlyingLiabilityReference { get; init; }
}
