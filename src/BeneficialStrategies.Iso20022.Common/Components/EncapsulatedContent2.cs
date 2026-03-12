// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to authenticate.
/// </summary>
[IsoId("_2rQgUVW7EeOlEMHvp-ipJg")]
[DisplayName("Encapsulated Content")]
public partial record EncapsulatedContent2
{
    #nullable enable
    
    /// <summary>
    /// Type of data which have been authenticated.
    /// </summary>
    [IsoId("_22k_gVW7EeOlEMHvp-ipJg")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType1Code ContentType { get; init; } 
    
    /// <summary>
    /// Actual data to authenticate.
    /// </summary>
    [IsoId("_22k_g1W7EeOlEMHvp-ipJg")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? Content { get; init; } 
    
    
    #nullable disable
    
}
