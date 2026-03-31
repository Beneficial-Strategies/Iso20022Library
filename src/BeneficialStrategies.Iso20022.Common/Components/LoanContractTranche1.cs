// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the tranches defined for the loan contract.
/// </summary>
[IsoId("_3sV2tNNDEeSDLevdaFPXHw")]
[DisplayName("Loan Contract Tranche")]
public record LoanContractTranche1
{
    /// <summary>
    /// Unique sequence number of the tranche.
    /// </summary>
    [IsoId("_3sV2tdNDEeSDLevdaFPXHw")]
    [DisplayName("Tranche Number")]
    [IsoXmlTag("TrchNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber TrancheNumber { get; init; }

    /// <summary>
    /// Expected tranche payment date.
    /// </summary>
    [IsoId("_FdOzsNNEEeSDLevdaFPXHw")]
    [DisplayName("Expected Date")]
    [IsoXmlTag("XpctdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ExpectedDate { get; init; }

    /// <summary>
    /// Amount of the tranche as defined in the loan contract.
    /// </summary>
    [IsoId("_JBwDUNNEEeSDLevdaFPXHw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Loan tranche due date.
    /// </summary>
    [IsoId("_mz8FotOEEeSQ_-lmj1tzfw")]
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DueDate { get; init; }

    /// <summary>
    /// Loan tranche duration in a coded form.
    /// </summary>
    [IsoId("_8Ty5cdOEEeSQ_-lmj1tzfw")]
    [DisplayName("Duration Code")]
    [IsoXmlTag("DrtnCd")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    public IsoExact1NumericText? DurationCode { get; init; }

    /// <summary>
    /// Indicates whether this tranche is the last tranche of the full report.
    /// </summary>
    [IsoId("_3sV2ttNDEeSDLevdaFPXHw")]
    [DisplayName("Last Tranche Indicator")]
    [IsoXmlTag("LastTrchInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LastTrancheIndicator { get; init; }
}
