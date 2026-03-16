// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of each individual invoice tax report transaction.
/// </summary>
[IsoId("_8pkzYU53Eeaine-lsNAGsA")]
[DisplayName("Invoice Tax Report Transaction Status")]
public record InvoiceTaxReportTransactionStatus1
{
    /// <summary>
    /// Report identification, for example invoice number or report number from point of sales system.
    /// </summary>
    [IsoId("_8xqYYU53Eeaine-lsNAGsA")]
    [DisplayName("Tax Report Identification")]
    [IsoXmlTag("TaxRptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TaxReportIdentification { get; init; }

    /// <summary>
    /// Defines status of the reported transaction.
    /// </summary>
    [IsoId("_8xqYZ053Eeaine-lsNAGsA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TaxReportingStatus2Code Status { get; init; }

    /// <summary>
    /// Provides the details of the rule which could not be validated.
    /// </summary>
    [IsoId("_8xqYaU53Eeaine-lsNAGsA")]
    [DisplayName("Validation Rule")]
    [IsoXmlTag("VldtnRule")]
    public GenericValidationRuleIdentification1? ValidationRule { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_8xqYa053Eeaine-lsNAGsA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
