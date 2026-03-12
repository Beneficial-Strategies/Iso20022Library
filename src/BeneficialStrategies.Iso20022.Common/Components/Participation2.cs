// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the level of participation to a shareholders meeting.
/// </summary>
[IsoId("_Tj3tYdp-Ed-ak6NoX_4Aeg_48636635")]
[DisplayName("Participation")]
public partial record Participation2
{
    #nullable enable
    
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_Tj3tYtp-Ed-ak6NoX_4Aeg_48636637")]
    [DisplayName("Total Number Of Voting Rights")]
    [IsoXmlTag("TtlNbOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfVotingRights { get; init; } 
    
    /// <summary>
    /// Percentage of rights participating to the vote versus total voting rights.
    /// </summary>
    [IsoId("_Tj3tY9p-Ed-ak6NoX_4Aeg_48636713")]
    [DisplayName("Percentage Of Voting Rights")]
    [IsoXmlTag("PctgOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfVotingRights { get; init; } 
    
    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    [IsoId("_Tj3tZNp-Ed-ak6NoX_4Aeg_48636678")]
    [DisplayName("Total Number Of Securities Outstanding")]
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    public CurrencyAndAmount? TotalNumberOfSecuritiesOutstanding { get; init; } 
    
    /// <summary>
    /// Date of calculation of the total number of oustanding securities.
    /// </summary>
    [IsoId("_Tj3tZdp-Ed-ak6NoX_4Aeg_48636730")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CalculationDate { get; init; } 
    
    
    #nullable disable
    
}
