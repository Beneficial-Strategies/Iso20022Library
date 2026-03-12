// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide information on the level of participation to a shareholder meeting.
/// </summary>
[IsoId("_BMUVgbqREemCAOifqHrKJw")]
[DisplayName("Participation")]
public partial record Participation5
{
    #nullable enable
    
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_Bed1c7qREemCAOifqHrKJw")]
    [DisplayName("Total Number Of Voting Rights")]
    [IsoXmlTag("TtlNbOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfVotingRights { get; init; } 
    
    /// <summary>
    /// Percentage of rights participating to the vote versus total voting rights.
    /// </summary>
    [IsoId("_Bed1dbqREemCAOifqHrKJw")]
    [DisplayName("Percentage Of Voting Rights")]
    [IsoXmlTag("PctgOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfVotingRights { get; init; } 
    
    /// <summary>
    /// Number of securities admitted to the vote, expressed as a number of units or a face amount.
    /// </summary>
    [IsoId("_Bed1d7qREemCAOifqHrKJw")]
    [DisplayName("Total Number Of Securities Outstanding")]
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    public FinancialInstrumentQuantity18Choice_? TotalNumberOfSecuritiesOutstanding { get; init; } 
    
    /// <summary>
    /// Date of calculation of the total number of outstanding securities.
    /// </summary>
    [IsoId("_Bed1ebqREemCAOifqHrKJw")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CalculationDate { get; init; } 
    
    
    #nullable disable
    
}
