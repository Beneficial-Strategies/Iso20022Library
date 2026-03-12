// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClosingBalance7Choice
{
    /// <summary>
    /// Closing balance of this page only. This balance must be the intermediary opening balance of the next page of the same statement.
    /// </summary>
    [IsoId("_gJxalTi8Eeydid5dcNPKvg")]
    [DisplayName("Intermediary")]
    public partial record Intermediary : ClosingBalance7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
