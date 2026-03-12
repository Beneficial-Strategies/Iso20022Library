// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice
{
    /// <summary>
    /// Status of the transfer is rejected.
    /// </summary>
    [IsoId("_o1CqrBwkEeOIveEnnb_1-A")]
    [DisplayName("Rejected")]
    public partial record Rejected : TransferStatus1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
