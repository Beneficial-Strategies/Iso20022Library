// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RepoCallRequestStatus9Choice
{
    /// <summary>
    /// Instruction/Request will not be executed.
    /// </summary>
    [IsoId("_6BKUi5NLEeWGlc8L7oPDIg")]
    [DisplayName("Denied")]
    public partial record Denied : RepoCallRequestStatus9Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
