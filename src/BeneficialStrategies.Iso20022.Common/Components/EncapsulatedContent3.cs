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
[IsoId("_tmwjwWkJEeS7zPBpvm732w")]
[DisplayName("Encapsulated Content")]
public partial record EncapsulatedContent3
{
    #nullable enable
    
    /// <summary>
    /// Type of data which have been authenticated.
    /// </summary>
    [IsoId("_tz6O8WkJEeS7zPBpvm732w")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; } 
    
    /// <summary>
    /// Actual data to authenticate.
    /// </summary>
    [IsoId("_tz6O82kJEeS7zPBpvm732w")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? Content { get; init; } 
    
    
    #nullable disable
    
}
