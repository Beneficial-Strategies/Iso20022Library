// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RequestType2Choice
{
    /// <summary>
    /// Request type is an enquiry on a position or a transaction.
    /// </summary>
    [IsoId("_76G8dKMgEeCJ6YNENx4h-w_-1836773968")]
    [DisplayName("Enquiry")]
    public record Enquiry : RequestType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the request used to further detail the type of information that will be queried.
        /// </summary>
        [IsoXmlTag("Enqry")]
        public required RequestType2Code Value { get; init; }
    }
}
