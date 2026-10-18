// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDocumentAdjustment1"/>
[IsoId("_UP-lctp-Ed-ak6NoX_4Aeg_1188294125")]
[DisplayName("Document Adjustment")]
public partial record DocumentAdjustment1
{
    /// <inheritdoc cref="IDocumentAdjustment1.Amount"/>
    [IsoId("_UP-lc9p-Ed-ak6NoX_4Aeg_1531842196")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <inheritdoc cref="IDocumentAdjustment1.CreditDebitIndicator"/>
    [IsoId("_UP-ldNp-Ed-ak6NoX_4Aeg_1554008423")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <inheritdoc cref="IDocumentAdjustment1.Reason"/>
    [IsoId("_UP-lddp-Ed-ak6NoX_4Aeg_1641741581")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? Reason { get; init; }

    /// <inheritdoc cref="IDocumentAdjustment1.AdditionalInformation"/>
    [IsoId("_UP-ldtp-Ed-ak6NoX_4Aeg_1656516606")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }
}
