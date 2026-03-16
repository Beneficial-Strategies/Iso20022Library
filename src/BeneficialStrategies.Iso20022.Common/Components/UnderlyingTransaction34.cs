// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Underlying Transaction34.
/// </summary>
[IsoId("_9jlatzEsEe6GxLzpkVnWYg")]
[DisplayName("Underlying Transaction34")]
public record UnderlyingTransaction34
{
    /// <summary>
    /// Original Group Information And Cancellation.
    /// </summary>
    [DisplayName("Original Group Information And Cancellation")]
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    public OriginalGroupHeader21? OriginalGroupInformationAndCancellation { get; init; }

    /// <summary>
    /// Transaction Information.
    /// </summary>
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransaction155> TransactionInformation { get; init; } = [];
}
