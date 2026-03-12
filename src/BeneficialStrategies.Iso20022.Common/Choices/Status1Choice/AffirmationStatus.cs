// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_UU5htNp-Ed-ak6NoX_4Aeg_1993451566")]
    [DisplayName("Affirmation Status")]
    public partial record AffirmationStatus : Status1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
