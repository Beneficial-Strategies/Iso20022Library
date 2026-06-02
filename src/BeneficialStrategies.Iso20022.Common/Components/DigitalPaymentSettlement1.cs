// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the information related to the digital payment settlement.
/// </summary>
[IsoId("_0BvvAJZaEfCShM_qO0U4ig")]
[DisplayName("Digital Payment Settlement1")]
public record DigitalPaymentSettlement1
{
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_WqsOEJZdEfCShM_qO0U4ig")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Choice between different quantities related to the payment in digital asset.
    /// </summary>
    [IsoId("_ghFEYJZdEfCShM_qO0U4ig")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity83Choice Quantity { get; init; }

    /// <summary>
    /// Location where the payment is/will be taking place.
    /// </summary>
    [IsoId("_DndtYZZgEfCShM_qO0U4ig")]
    [DisplayName("Cash Settlement System Place")]
    [IsoXmlTag("CshSttlmSysPlc")]
    public CashSettlementSystemPlace1Choice? CashSettlementSystemPlace { get; init; }
}
