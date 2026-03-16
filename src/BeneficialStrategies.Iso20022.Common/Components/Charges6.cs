// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the charges related to the payment transaction.
/// </summary>
[IsoId("_9GXpB249EeiU9cctagi5ow")]
[DisplayName("Charges")]
public record Charges6
{
    /// <summary>
    /// Total of all charges and taxes applied to the entry.
    /// </summary>
    [IsoId("_9RGSM249EeiU9cctagi5ow")]
    [DisplayName("Total Charges And Tax Amount")]
    [IsoXmlTag("TtlChrgsAndTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalChargesAndTaxAmount { get; init; }

    /// <summary>
    /// Provides details of the individual charges record.
    /// </summary>
    [IsoId("_9RGSNW49EeiU9cctagi5ow")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ChargesRecord3? Record { get; init; }
}
