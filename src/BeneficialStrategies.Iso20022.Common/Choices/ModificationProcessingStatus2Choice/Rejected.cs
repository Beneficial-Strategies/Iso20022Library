// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus2Choice
{
    /// <summary>
    /// Modification request has been rejected for further processing.
    /// </summary>
    [IsoId("_0ktvwwlIEeGATtfOBToyew_-1627156678")]
    [DisplayName("Rejected")]
    public record Rejected : ModificationProcessingStatus2Choice_ { }
}
