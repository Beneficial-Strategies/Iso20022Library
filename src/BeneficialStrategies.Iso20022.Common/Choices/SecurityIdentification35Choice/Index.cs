// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification35Choice
{
    /// <summary>
    /// Index name where the underlying is an index.
    /// </summary>
    [IsoId("_ZmtSVQ1HEeqV4s5SpzR1dQ")]
    [DisplayName("Index")]
    public record Index : SecurityIdentification35Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a benchmark curve name.
        /// </summary>
        [IsoXmlTag("Indx")]
        public required BenchmarkCurveName3Code Value { get; init; }
    }
}
