// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit Report8.
/// </summary>
[IsoId("_5W_PoTEyEe6g-ffJsqGiSA")]
[DisplayName("Limit Report8")]
public partial record LimitReport8
{
    #nullable enable

    /// <summary>
    /// Limit Identification.
    /// </summary>
    [DisplayName("Limit Identification")]
    [IsoXmlTag("LmtId")]
    public required LimitIdentification8 LimitIdentification { get; init; } 

    /// <summary>
    /// Limit Or Error.
    /// </summary>
    [DisplayName("Limit Or Error")]
    [IsoXmlTag("LmtOrErr")]
    public required LimitOrError4Choice_ LimitOrError { get; init; } 

    
    #nullable disable
    
}
