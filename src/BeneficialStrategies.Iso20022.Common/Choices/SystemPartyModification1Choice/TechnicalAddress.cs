// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification1Choice
{
    /// <summary>
    /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
    /// </summary>
    [IsoId("_ko4Lsu5NEeCisYr99QEiWA_1442830119")]
    [DisplayName("Technical Address")]
    public partial record TechnicalAddress : SystemPartyModification1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
