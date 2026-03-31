// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying (group of) transaction(s) to which the investigation applies.
/// </summary>
[IsoId("_T4nHLW49EeiU9cctagi5ow")]
[DisplayName("Underlying Transaction")]
public record UnderlyingTransaction23
{
    /// <summary>
    /// Provides information on the original message, to which the cancellation refers.
    /// </summary>
    [IsoId("_UG6o3W49EeiU9cctagi5ow")]
    [DisplayName("Original Group Information And Cancellation")]
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    public OriginalGroupHeader15? OriginalGroupInformationAndCancellation { get; init; }

    /// <summary>
    /// Provides information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_UG6o3249EeiU9cctagi5ow")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransaction106> TransactionInformation { get; init; } = [];
}
