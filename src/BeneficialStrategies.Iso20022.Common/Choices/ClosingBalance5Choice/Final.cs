// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClosingBalance5Choice
{
    /// <summary>
    /// Sum of the opening balance and all entries booked to the account at the close of the statement period.
    /// </summary>
    [IsoId("_8bhd_5NLEeWGlc8L7oPDIg")]
    [DisplayName("Final")]
    public partial record Final : ClosingBalance5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
