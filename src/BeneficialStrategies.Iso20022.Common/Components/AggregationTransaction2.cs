// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment transaction with an aggregated amount.
/// </summary>
[IsoId("_f-ARIY0nEeWzoK7sd7oTyw")]
[DisplayName("Aggregation Transaction")]
public record AggregationTransaction2
{
    /// <summary>
    /// Date and time of the first payment.
    /// </summary>
    [IsoId("_gJ7NQY0nEeWzoK7sd7oTyw")]
    [DisplayName("First Payment Date Time")]
    [IsoXmlTag("FrstPmtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? FirstPaymentDateTime { get; init; }

    /// <summary>
    /// Date and time of the last payment.
    /// </summary>
    [IsoId("_gJ7NQ40nEeWzoK7sd7oTyw")]
    [DisplayName("Last Payment Date Time")]
    [IsoXmlTag("LastPmtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? LastPaymentDateTime { get; init; }

    /// <summary>
    /// Total number of payments that has been aggregated.
    /// </summary>
    [IsoId("_gJ7NRY0nEeWzoK7sd7oTyw")]
    [DisplayName("Number Of Payments")]
    [IsoXmlTag("NbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfPayments { get; init; }

    /// <summary>
    /// Individual payment that has been aggregated.
    /// </summary>
    [IsoId("_gJ7NR40nEeWzoK7sd7oTyw")]
    [DisplayName("Individual Payment")]
    [IsoXmlTag("IndvPmt")]
    public ValueList<DetailedAmount14> IndividualPayment { get; init; } = [];
}
