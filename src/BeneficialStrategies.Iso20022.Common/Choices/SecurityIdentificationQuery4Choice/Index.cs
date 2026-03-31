// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentificationQuery4Choice
{
    /// <summary>
    /// Identification of the index on which the financial instrument is based.
    /// </summary>
    [IsoId("_PJPwqZNeEeytjZlcgApf6A")]
    [DisplayName("Index")]
    public record Index : SecurityIdentificationQuery4Choice_ { }
}
