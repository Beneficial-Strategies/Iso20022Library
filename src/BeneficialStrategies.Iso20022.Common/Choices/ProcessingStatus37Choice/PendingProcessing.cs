// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus37Choice
{
    /// <summary>
    /// Processing of the instruction/request is pending.
    /// </summary>
    [IsoId("_GNQhiSwuEeOEV5XHD-BKpw")]
    [DisplayName("Pending Processing")]
    public partial record PendingProcessing : ProcessingStatus37Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
