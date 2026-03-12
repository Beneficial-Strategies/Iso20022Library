// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Results of backtesting analysis used to test the performance of a risk model.
/// </summary>
[IsoId("_9ZdcILC3EeaSl6vJk5Bd8w")]
[DisplayName("Monthly Result")]
public partial record MonthlyResult1
{
    #nullable enable
    
    /// <summary>
    /// Total number of accounts subject to backtesting in the month.
    /// </summary>
    [IsoId("_I2UhALC4EeaSl6vJk5Bd8w")]
    [DisplayName("Number Of Observations")]
    [IsoXmlTag("NbOfObsrvtns")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public required IsoPositiveNumber NumberOfObservations { get; init; } 
    
    /// <summary>
    /// Number of times that margin coverage held against any account fell below the marked‐to‐market exposure of that member account, based on the backtesting results.
    /// </summary>
    [IsoId("_4jSh8LC4EeaSl6vJk5Bd8w")]
    [DisplayName("Number Of Exceptions")]
    [IsoXmlTag("NbOfXcptns")]
    [IsoSimpleType(IsoSimpleType.NonNegativeNumber)]
    public required IsoNonNegativeNumber NumberOfExceptions { get; init; } 
    
    /// <summary>
    /// Achieved coverage level.
    /// </summary>
    [IsoId("_Y4uYMLC5EeaSl6vJk5Bd8w")]
    [DisplayName("Coverage")]
    [IsoXmlTag("Cvrg")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate Coverage { get; init; } 
    
    /// <summary>
    /// Largest marked-to-market exposure on any account that exceeds the margin coverage held against that account. The difference between the size of the exposure and the margin held.
    /// </summary>
    [IsoId("_p424YLC5EeaSl6vJk5Bd8w")]
    [DisplayName("Largest Exception")]
    [IsoXmlTag("LrgstXcptn")]
    public required ActiveCurrencyAndAmount LargestException { get; init; } 
    
    /// <summary>
    /// Average marked‐to‐market exposure on accounts that exceeds the margin coverage held against those accounts.
    /// </summary>
    [IsoId("_wM63cLC5EeaSl6vJk5Bd8w")]
    [DisplayName("Average Exception")]
    [IsoXmlTag("AvrgXcptn")]
    public required ActiveCurrencyAndAmount AverageException { get; init; } 
    
    /// <summary>
    /// Unique internal identifier for the backtested account experiencing the largest exception.
    /// </summary>
    [IsoId("_AOalILC6EeaSl6vJk5Bd8w")]
    [DisplayName("Largest Exception Identification")]
    [IsoXmlTag("LrgstXcptnId")]
    public GenericIdentification165? LargestExceptionIdentification { get; init; } 
    
    
    #nullable disable
    
}
