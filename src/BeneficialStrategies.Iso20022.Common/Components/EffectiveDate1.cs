// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and date parameters.
/// </summary>
[IsoId("_oxDxcDceEeOA3chqL9a4Rw")]
[DisplayName("Effective Date")]
public partial record EffectiveDate1
{
    #nullable enable
    
    /// <summary>
    /// Date on which the SSI is effective. If the SSI is effective on a future date, then the date must be provided.
    /// </summary>
    [IsoId("_BjtLsDcfEeOA3chqL9a4Rw")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EffectiveDate { get; init; } 
    
    /// <summary>
    /// Specifies how the SSI update effective date is to be applied.
    /// </summary>
    [IsoId("_NXDd8DcfEeOA3chqL9a4Rw")]
    [DisplayName("Effective Date Parameter")]
    [IsoXmlTag("FctvDtParam")]
    public ExternalEffectiveDateParameter1Code? EffectiveDateParameter { get; init; } 
    
    
    #nullable disable
    
}
