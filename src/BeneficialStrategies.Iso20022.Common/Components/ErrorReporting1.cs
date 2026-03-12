// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed description of an error.
/// </summary>
[IsoId("_KNibIIPeEeS-ibzJaEIoIQ")]
[DisplayName("Error Reporting")]
public partial record ErrorReporting1
{
    #nullable enable
    
    /// <summary>
    /// Type of error.
    /// </summary>
    [IsoId("_aqeusIPeEeS-ibzJaEIoIQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Detailed description of the error.
    /// </summary>
    [IsoId("_kWXlMIPeEeS-ibzJaEIoIQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public required IsoMax500Text Description { get; init; } 
    
    
    #nullable disable
    
}
