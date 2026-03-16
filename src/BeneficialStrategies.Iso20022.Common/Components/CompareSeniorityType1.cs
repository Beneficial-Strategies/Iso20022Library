// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a seniority type.
/// </summary>
[IsoId("_46oMQE6nEeyEpI66tm807w")]
[DisplayName("Compare Seniority Type")]
public record CompareSeniorityType1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("___J-8E6nEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public DebtInstrumentSeniorityType2Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_BnzXwE6oEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public DebtInstrumentSeniorityType2Code? Value2 { get; init; }
}
