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
[IsoId("_KsXs0n1DEeCF8NjrBemJWQ_359264692")]
[DisplayName("TMS Event")]
public partial record TMSEvent1
{
    #nullable enable
    
    /// <summary>
    /// Date time of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_KsXs031DEeCF8NjrBemJWQ_-355627508")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TimeStamp { get; init; } 
    
    /// <summary>
    /// Final result of the processed terminal management action.
    /// </summary>
    [IsoId("_KsXs1H1DEeCF8NjrBemJWQ_-40771667")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required TerminalManagementActionResult1Code Result { get; init; } 
    
    /// <summary>
    /// Identification of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_KsXs1X1DEeCF8NjrBemJWQ_-1842873575")]
    [DisplayName("Action Identification")]
    [IsoXmlTag("ActnId")]
    public required TMSActionIdentification1 ActionIdentification { get; init; } 
    
    /// <summary>
    /// Additional information related to a failure.
    /// </summary>
    [IsoId("_KsXs1n1DEeCF8NjrBemJWQ_-1952002664")]
    [DisplayName("Additional Error Information")]
    [IsoXmlTag("AddtlErrInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalErrorInformation { get; init; } 
    
    
    #nullable disable
    
}
