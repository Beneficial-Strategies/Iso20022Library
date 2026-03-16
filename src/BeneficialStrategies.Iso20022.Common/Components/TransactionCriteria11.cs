// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Criteria11.
/// </summary>
[IsoId("_3K7nxTEyEe6g-ffJsqGiSA")]
[DisplayName("Transaction Criteria11")]
public record TransactionCriteria11
{
    /// <summary>
    /// New Query Name.
    /// </summary>
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    public IsoMax35Text? NewQueryName { get; init; }

    /// <summary>
    /// Return Criteria.
    /// </summary>
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public TransactionReturnCriteria5? ReturnCriteria { get; init; }

    /// <summary>
    /// Search Criteria.
    /// </summary>
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public ValueList<TransactionSearchCriteria11> SearchCriteria { get; init; } = [];

    /// <summary>
    /// Statement Report.
    /// </summary>
    [DisplayName("Statement Report")]
    [IsoXmlTag("StmtRpt")]
    public ReportIndicator1Code? StatementReport { get; init; }
}
