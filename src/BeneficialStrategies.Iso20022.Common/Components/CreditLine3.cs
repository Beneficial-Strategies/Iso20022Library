// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide details of the credit line.
/// </summary>
[IsoId("_oZe7n4Z5Eee8r9VKRbnJSg")]
[DisplayName("Credit Line")]
public record CreditLine3
{
    /// <summary>
    /// Indicates whether or not the credit line is included in the balance.
    /// </summary>
    [IsoId("_ohzxI4Z5Eee8r9VKRbnJSg")]
    [DisplayName("Included")]
    [IsoXmlTag("Incl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Included { get; init; }

    /// <summary>
    /// Type of the credit line provided when multiple credit lines may be provided.
    /// </summary>
    [IsoId("_tjAaIYZ5Eee8r9VKRbnJSg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CreditLineType1Choice_? Type { get; init; }

    /// <summary>
    /// Amount of money of the credit line.
    /// </summary>
    [IsoId("_ohzxJYZ5Eee8r9VKRbnJSg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Date of the credit line provided when multiple credit lines may be provided.
    /// </summary>
    [IsoId("_-qXbALPcEeeppqgHuc69jg")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public DateAndDateTime2Choice_? Date { get; init; }
}
