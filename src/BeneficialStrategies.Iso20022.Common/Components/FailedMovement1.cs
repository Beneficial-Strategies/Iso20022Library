// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about a movement that failed the settlement.
/// </summary>
[IsoId("_UIrqo9p-Ed-ak6NoX_4Aeg_2140472900")]
[DisplayName("Failed Movement")]
public record FailedMovement1
{
    /// <summary>
    /// Amount of cash.
    /// </summary>
    [IsoId("_UIrqpNp-Ed-ak6NoX_4Aeg_389375421")]
    [DisplayName("Cash Amount")]
    [IsoXmlTag("CshAmt")]
    public required ActiveCurrencyAndAmount CashAmount { get; init; }

    /// <summary>
    /// Quantity of the financial instrument.
    /// </summary>
    [IsoId("_UIrqpdp-Ed-ak6NoX_4Aeg_-613888276")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public required UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; init; }

    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UIrqptp-Ed-ak6NoX_4Aeg_-647134478")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification7? SecurityIdentification { get; init; }

    /// <summary>
    /// The reason for the settlement failure.
    /// </summary>
    [IsoId("_UIrqp9p-Ed-ak6NoX_4Aeg_-124106569")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required FailedSettlementReason1FormatChoice_ Reason { get; init; }
}
