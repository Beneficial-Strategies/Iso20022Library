// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClosingDate1Choice
{
    /// <summary>
    /// Closing date is defined as a choice between a date or a date and time format.
    /// </summary>
    [IsoId("_j2-tkdopEeCWg-hsBVGrDA_997160684")]
    [DisplayName("Date")]
    public partial record Date : ClosingDate1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
