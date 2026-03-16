// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the level of participation to a shareholders meeting.
/// </summary>
[IsoId("_MWKHMV7AEeSjaerr_EM7AQ")]
[DisplayName("Participation")]
public record Participation4
{
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_MyuHY17AEeSjaerr_EM7AQ")]
    [DisplayName("Total Number Of Voting Rights")]
    [IsoXmlTag("TtlNbOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfVotingRights { get; init; }

    /// <summary>
    /// Percentage of rights participating to the vote versus total voting rights.
    /// </summary>
    [IsoId("_MyuHZV7AEeSjaerr_EM7AQ")]
    [DisplayName("Percentage Of Voting Rights")]
    [IsoXmlTag("PctgOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfVotingRights { get; init; }

    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    [IsoId("_MyuHZ17AEeSjaerr_EM7AQ")]
    [DisplayName("Total Number Of Securities Outstanding")]
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    public UnitOrFaceAmount1Choice_? TotalNumberOfSecuritiesOutstanding { get; init; }

    /// <summary>
    /// Date of calculation of the total number of outstanding securities.
    /// </summary>
    [IsoId("_MyuHaV7AEeSjaerr_EM7AQ")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CalculationDate { get; init; }
}
