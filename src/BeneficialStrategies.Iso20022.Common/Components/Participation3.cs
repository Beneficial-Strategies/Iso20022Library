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
[IsoId("_TlEANNp-Ed-ak6NoX_4Aeg_578416366")]
[DisplayName("Participation")]
public record Participation3
{
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_TlEANdp-Ed-ak6NoX_4Aeg_578416397")]
    [DisplayName("Total Number Of Voting Rights")]
    [IsoXmlTag("TtlNbOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfVotingRights { get; init; }

    /// <summary>
    /// Percentage of rights participating to the vote versus total voting rights.
    /// </summary>
    [IsoId("_TlEANtp-Ed-ak6NoX_4Aeg_578416736")]
    [DisplayName("Percentage Of Voting Rights")]
    [IsoXmlTag("PctgOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfVotingRights { get; init; }

    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    [IsoId("_TlEAN9p-Ed-ak6NoX_4Aeg_578416427")]
    [DisplayName("Total Number Of Securities Outstanding")]
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    public ActiveCurrencyAndAmount? TotalNumberOfSecuritiesOutstanding { get; init; }

    /// <summary>
    /// Date of calculation of the total number of oustanding securities.
    /// </summary>
    [IsoId("_TlEAONp-Ed-ak6NoX_4Aeg_578416767")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CalculationDate { get; init; }
}
