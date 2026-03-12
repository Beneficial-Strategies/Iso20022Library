// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status8Choice
{
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_w2B7ckABEeCaq78Ig8ATcA")]
    [DisplayName("Affirmation Status")]
    public partial record AffirmationStatus : Status8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
