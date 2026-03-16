// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for a transaction and to report on the transaction. A name may be given to the new query.
/// </summary>
[IsoId("_-S2D1QKxEe2rHs6fbn9-0A")]
[DisplayName("Transaction Criteria")]
public record TransactionCriteria10
{
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_-9kb0wKxEe2rHs6fbn9-0A")]
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NewQueryName { get; init; }

    /// <summary>
    /// Defines the criteria on which the information is extracted.
    /// </summary>
    [IsoId("_-9kb1QKxEe2rHs6fbn9-0A")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public ValueList<TransactionSearchCriteria10> SearchCriteria { get; init; } = [];

    /// <summary>
    /// Indicates the format of the requested report.
    /// </summary>
    [IsoId("_-9kb1wKxEe2rHs6fbn9-0A")]
    [DisplayName("Statement Report")]
    [IsoXmlTag("StmtRpt")]
    public ReportIndicator1Code? StatementReport { get; init; }

    /// <summary>
    /// Defines the expected payment transaction report.
    /// </summary>
    [IsoId("_-9kb2QKxEe2rHs6fbn9-0A")]
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public TransactionReturnCriteria5? ReturnCriteria { get; init; }
}
