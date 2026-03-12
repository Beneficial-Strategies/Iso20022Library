// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of an individual terminal management action performed by the point of interaction.
/// </summary>
[IsoId("_9XFdkbC3EeamYaqfhG1ZuA")]
[DisplayName("TMS Event")]
public partial record TMSEvent5
{
    #nullable enable
    
    /// <summary>
    /// Date time of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_9ibx8bC3EeamYaqfhG1ZuA")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TimeStamp { get; init; } 
    
    /// <summary>
    /// Final result of the processed terminal management action.
    /// </summary>
    [IsoId("_9ibx87C3EeamYaqfhG1ZuA")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required TerminalManagementActionResult3Code Result { get; init; } 
    
    /// <summary>
    /// Identification of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_9ibx9bC3EeamYaqfhG1ZuA")]
    [DisplayName("Action Identification")]
    [IsoXmlTag("ActnId")]
    public required TMSActionIdentification4 ActionIdentification { get; init; } 
    
    /// <summary>
    /// Additional information related to a failure.
    /// </summary>
    [IsoId("_9ibx97C3EeamYaqfhG1ZuA")]
    [DisplayName("Additional Error Information")]
    [IsoXmlTag("AddtlErrInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalErrorInformation { get; init; } 
    
    
    #nullable disable
    
}
