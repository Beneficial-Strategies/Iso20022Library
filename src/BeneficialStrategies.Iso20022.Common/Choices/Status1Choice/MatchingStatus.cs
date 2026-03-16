// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_UVDStNp-Ed-ak6NoX_4Aeg_52789005")]
    [DisplayName("Matching Status")]
    public record MatchingStatus : Status1Choice_ { }
}
