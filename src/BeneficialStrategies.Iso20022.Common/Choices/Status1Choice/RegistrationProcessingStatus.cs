// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Provides the status of the registration processing.
    /// </summary>
    [IsoId("_UVDStdp-Ed-ak6NoX_4Aeg_-199936640")]
    [DisplayName("Registration Processing Status")]
    public partial record RegistrationProcessingStatus : Status1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
