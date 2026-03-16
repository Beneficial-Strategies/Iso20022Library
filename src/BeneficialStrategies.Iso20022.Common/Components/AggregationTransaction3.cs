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
[IsoId("_0byE8QxjEeqEbo60f0v6aw")]
[DisplayName("Aggregation Transaction")]
public record AggregationTransaction3
{
    /// <summary>
    /// Date and time of the first payment.
    /// </summary>
    [IsoId("_0mGekQxjEeqEbo60f0v6aw")]
    [DisplayName("First Payment Date Time")]
    [IsoXmlTag("FrstPmtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? FirstPaymentDateTime { get; init; }

    /// <summary>
    /// Date and time of the last payment.
    /// </summary>
    [IsoId("_0mGekwxjEeqEbo60f0v6aw")]
    [DisplayName("Last Payment Date Time")]
    [IsoXmlTag("LastPmtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? LastPaymentDateTime { get; init; }

    /// <summary>
    /// Total number of payments that has been aggregated.
    /// </summary>
    [IsoId("_0mGelQxjEeqEbo60f0v6aw")]
    [DisplayName("Number Of Payments")]
    [IsoXmlTag("NbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfPayments { get; init; }

    /// <summary>
    /// Individual payment that has been aggregated.
    /// </summary>
    [IsoId("_0mGelwxjEeqEbo60f0v6aw")]
    [DisplayName("Individual Payment")]
    [IsoXmlTag("IndvPmt")]
    public ValueList<DetailedAmount21> IndividualPayment { get; init; } = [];
}
