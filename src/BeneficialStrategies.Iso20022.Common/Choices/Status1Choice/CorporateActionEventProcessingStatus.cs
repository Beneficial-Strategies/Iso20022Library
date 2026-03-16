// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Provides the status of a corporate action or the status of a payment.
    /// </summary>
    [IsoId("_UVDSsNp-Ed-ak6NoX_4Aeg_-311205826")]
    [DisplayName("Corporate Action Event Processing Status")]
    public record CorporateActionEventProcessingStatus : Status1Choice_ { }
}
