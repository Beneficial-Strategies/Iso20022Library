// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide further details on transaction specific interest information that applies to the underlying transaction.
/// </summary>
[IsoId("_txJrIFkyEeGeoaLUQk__nA_-921369458")]
[DisplayName("Transaction Interest")]
public record TransactionInterest3
{
    /// <summary>
    /// Total amount of interests and taxes included in the entry amount.
    /// </summary>
    [IsoId("_txJrIVkyEeGeoaLUQk__nA_-504205189")]
    [DisplayName("Total Interest And Tax Amount")]
    [IsoXmlTag("TtlIntrstAndTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalInterestAndTaxAmount { get; init; }

    /// <summary>
    /// Individual interest record.
    /// </summary>
    [IsoId("_txS1EFkyEeGeoaLUQk__nA_45439285")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<InterestRecord1> Record { get; init; } = [];
}
