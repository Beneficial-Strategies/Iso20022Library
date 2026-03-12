// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the owner type and mandate type.
/// </summary>
[IsoId("_rv8cQC_-EeOKib24wnHaFg")]
[DisplayName("Owner Type")]
public partial record OwnerType1
{
    #nullable enable
    
    /// <summary>
    /// Type of ownership.
    /// </summary>
    [IsoId("_xXmBQC_-EeOKib24wnHaFg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AccountOwnerType1Code Type { get; init; } 
    
    /// <summary>
    /// Type of mandate.
    /// </summary>
    [IsoId("_Fkj7YJiuEeO4o528ngEXuw")]
    [DisplayName("Mandate Type")]
    [IsoXmlTag("MndtTp")]
    public AccountPermissionType1Code? MandateType { get; init; } 
    
    /// <summary>
    /// Additional information about owner type or mandate type in proprietary format.
    /// </summary>
    [IsoId("_1p5j8C_-EeOKib24wnHaFg")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public GenericIdentification1? Proprietary { get; init; } 
    
    
    #nullable disable
    
}
