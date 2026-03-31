// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information of a single instalment related to an invoice settlement.
/// </summary>
[IsoId("_Py7LUtp-Ed-ak6NoX_4Aeg_-550302761")]
[DisplayName("Instalment")]
public record Instalment1
{
    /// <summary>
    /// Specifies the progressive number of the single instalment related to an invoice.
    /// </summary>
    [IsoId("_Py7LU9p-Ed-ak6NoX_4Aeg_-760207226")]
    [DisplayName("Sequence Identification")]
    [IsoXmlTag("SeqId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text SequenceIdentification { get; init; }

    /// <summary>
    /// Due date for the payment of the invoice instalment.
    /// </summary>
    [IsoId("_Py7LVNp-Ed-ak6NoX_4Aeg_-446211991")]
    [DisplayName("Payment Due Date")]
    [IsoXmlTag("PmtDueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate PaymentDueDate { get; init; }

    /// <summary>
    /// Amount of a single instalment related to an invoice.
    /// </summary>
    [IsoId("_Py7LVdp-Ed-ak6NoX_4Aeg_-333541102")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
