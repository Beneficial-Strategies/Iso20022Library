// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat21Choice
{
    /// <summary>
    /// Date expressed as an ISO Date.
    /// </summary>
    [IsoId("_5PdBs_ZFEd-2Jsl2KtUQCw")]
    [DisplayName("Date")]
    public record Date : DateFormat21Choice_ { }
}
