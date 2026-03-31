// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Provides the processing status of the replacement request.
    /// </summary>
    [IsoId("_UVDSt9p-Ed-ak6NoX_4Aeg_127115433")]
    [DisplayName("Replacement Processing Status")]
    public record ReplacementProcessingStatus : Status1Choice_ { }
}
