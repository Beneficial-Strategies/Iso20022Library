// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AffirmationStatus6Choice
{
    /// <summary>
    /// Trade has been unaffirmed.
    /// </summary>
    [IsoId("_A55R5tokEeC60axPepSq7g_323180115")]
    [DisplayName("Unaffirmed")]
    public partial record Unaffirmed : AffirmationStatus6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
