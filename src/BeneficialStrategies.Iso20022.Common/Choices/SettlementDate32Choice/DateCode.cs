// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementDate32Choice
{
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_vE8fe832Eee5nJBZsW8MFQ")]
    [DisplayName("Date Code")]
    public partial record DateCode : SettlementDate32Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
