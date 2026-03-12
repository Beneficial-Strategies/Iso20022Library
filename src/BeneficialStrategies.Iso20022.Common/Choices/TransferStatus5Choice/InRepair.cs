// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus5Choice
{
    /// <summary>
    /// Status of the transfer is in repair.
    /// </summary>
    [IsoId("_WY1VR-ijEeuLe8v4JEtDDg")]
    [DisplayName("In Repair")]
    public partial record InRepair : TransferStatus5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
