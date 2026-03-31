// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Provides the status of the registration processing.
    /// </summary>
    [IsoId("_UVDStdp-Ed-ak6NoX_4Aeg_-199936640")]
    [DisplayName("Registration Processing Status")]
    public record RegistrationProcessingStatus : Status1Choice_ { }
}
