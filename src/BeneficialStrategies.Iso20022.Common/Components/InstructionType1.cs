// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of instruction requested by the submitter by means of a code.
/// </summary>
[IsoId("_RJpGoNp-Ed-ak6NoX_4Aeg_-1851556220")]
[DisplayName("Instruction Type")]
public partial record InstructionType1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the baseline has to be pushed to the other party or simply lodged.
    /// </summary>
    [IsoId("_RJpGodp-Ed-ak6NoX_4Aeg_-1752742802")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required InstructionType1Code Type { get; init; } 
    
    
    #nullable disable
    
}
