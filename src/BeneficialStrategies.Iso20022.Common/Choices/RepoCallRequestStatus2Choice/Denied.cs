// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RepoCallRequestStatus2Choice
{
    /// <summary>
    /// Instruction/Request will not be executed.
    /// </summary>
    [IsoId("_UWYvddp-Ed-ak6NoX_4Aeg_-1727603711")]
    [DisplayName("Denied")]
    public partial record Denied : RepoCallRequestStatus2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
