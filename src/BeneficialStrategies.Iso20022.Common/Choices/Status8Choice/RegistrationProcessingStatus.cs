// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status8Choice
{
    /// <summary>
    /// Provides the status of the registration processing.
    /// </summary>
    [IsoId("_w2B72kABEeCaq78Ig8ATcA")]
    [DisplayName("Registration Processing Status")]
    public partial record RegistrationProcessingStatus : Status8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
