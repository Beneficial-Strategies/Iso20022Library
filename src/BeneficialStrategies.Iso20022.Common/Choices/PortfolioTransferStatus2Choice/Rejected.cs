// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PortfolioTransferStatus2Choice
{
    /// <summary>
    /// Instruction/request has been rejected for further processing.
    /// </summary>
    [IsoId("_WLfY8ukGEemm4qhb2yFPOw")]
    [DisplayName("Rejected")]
    public partial record Rejected : PortfolioTransferStatus2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
