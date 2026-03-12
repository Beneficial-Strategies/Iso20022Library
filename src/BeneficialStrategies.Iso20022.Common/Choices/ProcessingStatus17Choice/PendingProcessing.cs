// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus17Choice
{
    /// <summary>
    /// Processing of the trade is pending.
    /// </summary>
    [IsoId("_A4_6BtokEeC60axPepSq7g_1773645473")]
    [DisplayName("Pending Processing")]
    public partial record PendingProcessing : ProcessingStatus17Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
