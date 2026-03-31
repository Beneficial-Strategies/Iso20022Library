// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Includes a set of dates (e.g. credit date) related to settlement of the financing amount.
/// </summary>
[IsoId("_T8KRktp-Ed-ak6NoX_4Aeg_1418174558")]
[DisplayName("Financing Date Details")]
public record FinancingDateDetails1
{
    /// <summary>
    /// Date on which the financing transaction has been booked in an account.
    /// </summary>
    [IsoId("_T8KRk9p-Ed-ak6NoX_4Aeg_-558847054")]
    [DisplayName("Book Date")]
    [IsoXmlTag("BookDt")]
    public SimpleValueList<IsoISODate> BookDate { get; init; } = [];

    /// <summary>
    /// Date on which a financed amount has been credited.
    /// </summary>
    [IsoId("_T8KRlNp-Ed-ak6NoX_4Aeg_-183898526")]
    [DisplayName("Credit Date")]
    [IsoXmlTag("CdtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate CreditDate { get; init; }

    /// <summary>
    /// Date on which a financed amount has been debited.
    /// </summary>
    [IsoId("_T8KRldp-Ed-ak6NoX_4Aeg_-69382352")]
    [DisplayName("Debit Date")]
    [IsoXmlTag("DbtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DebitDate { get; init; }
}
