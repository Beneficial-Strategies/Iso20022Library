// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Participation6.
/// </summary>
[IsoId("_QUfGkZK6Ee-l-O3vIHRmRw")]
[DisplayName("Participation6")]
public record Participation6
{
    /// <summary>
    /// Calculation Date.
    /// </summary>
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    public IsoISODate? CalculationDate { get; init; }

    /// <summary>
    /// Percentage Of Voting Rights.
    /// </summary>
    [DisplayName("Percentage Of Voting Rights")]
    [IsoXmlTag("PctgOfVtngRghts")]
    public IsoPercentage14Rate? PercentageOfVotingRights { get; init; }

    /// <summary>
    /// Total Number Of Securities Outstanding.
    /// </summary>
    [DisplayName("Total Number Of Securities Outstanding")]
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    public FinancialInstrumentQuantity18Choice_? TotalNumberOfSecuritiesOutstanding { get; init; }

    /// <summary>
    /// Total Number Of Voting Rights.
    /// </summary>
    [DisplayName("Total Number Of Voting Rights")]
    [IsoXmlTag("TtlNbOfVtngRghts")]
    public IsoNumber? TotalNumberOfVotingRights { get; init; }
}
