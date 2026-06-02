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
[IsoId("_7BQRQZZ6EfC2_67yGLymgA")]
[DisplayName("Digital Payment Settlement2")]
public record DigitalPaymentSettlement2
{
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_7DmaoZZ6EfC2_67yGLymgA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Quantity of E-money token for the settlement payment.
    /// </summary>
    [IsoId("_vOYOMZZ8EfC2_67yGLymgA")]
    [DisplayName("Electronic Money Token Settlement Quantity")]
    [IsoXmlTag("ElctrncMnyTknSttlmQty")]
    public required IsoMax30DecimalNumber ElectronicMoneyTokenSettlementQuantity { get; init; }

    /// <summary>
    /// Location where the payment is/will be taking place.
    /// </summary>
    [IsoId("_7DmapZZ6EfC2_67yGLymgA")]
    [DisplayName("Cash Settlement System Place")]
    [IsoXmlTag("CshSttlmSysPlc")]
    public CashSettlementSystemPlace1Choice? CashSettlementSystemPlace { get; init; }
}
