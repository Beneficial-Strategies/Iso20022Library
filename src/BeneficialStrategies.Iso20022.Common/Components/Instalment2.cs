// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a single instalment related to an invoice settlement and optional reconciliation information.
/// Reconciliation information is used to indicate the amount to be allocated to a particular instalment of a financial document.
/// </summary>
[IsoId("_OTgzMzM5-AOSNFX-8224500")]
[DisplayName("Instalment")]
public record Instalment2
{
    /// <summary>
    /// Specifies the progressive number of the single instalment related to an invoice.
    /// </summary>
    [IsoId("_OTgzMzYy-AOSNFX-8224501")]
    [DisplayName("Sequence Identification")]
    [IsoXmlTag("SeqId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text SequenceIdentification { get; init; }

    /// <summary>
    /// Due date for the payment of the financing item instalment.
    /// </summary>
    [IsoId("_OTgzMzYz-AOSNFX-8224501")]
    [DisplayName("Payment Due Date")]
    [IsoXmlTag("PmtDueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate PaymentDueDate { get; init; }

    /// <summary>
    /// Amount of a single instalment related to an invoice.
    /// </summary>
    [IsoId("_OTgzMzY0-AOSNFX-8224501")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Desired payment instrument to be used for the instalment.
    /// </summary>
    [IsoId("_OTgzMzY1-AOSNFX-8224501")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public PaymentMeans1? PaymentInstrument { get; init; }
}
