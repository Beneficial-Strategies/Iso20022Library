// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus10Choice
{
    /// <summary>
    /// The transaction was created by the account servicer or a third party. It was not instructed directly by the account owner.
    /// </summary>
    [IsoId("_4BPnDf8dEeCrw_OT0uBMXQ")]
    [DisplayName("Generated")]
    public partial record Generated : InstructionProcessingStatus10Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
