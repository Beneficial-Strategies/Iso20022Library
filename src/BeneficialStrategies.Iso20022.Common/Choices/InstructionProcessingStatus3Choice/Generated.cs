// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus3Choice
{
    /// <summary>
    /// The transaction was created by the account servicer or a third party. It was not instructed directly by the account owner.
    /// </summary>
    [IsoId("_UZg79Np-Ed-ak6NoX_4Aeg_792042593")]
    [DisplayName("Generated")]
    public partial record Generated : InstructionProcessingStatus3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
