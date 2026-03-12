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
[IsoId("_RJpGotp-Ed-ak6NoX_4Aeg_-1074370626")]
[DisplayName("Instruction Type")]
public partial record InstructionType3
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the data set has to be matched or pre-matched.
    /// </summary>
    [IsoId("_RJpGo9p-Ed-ak6NoX_4Aeg_-419201294")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required InstructionType3Code Type { get; init; } 
    
    
    #nullable disable
    
}
