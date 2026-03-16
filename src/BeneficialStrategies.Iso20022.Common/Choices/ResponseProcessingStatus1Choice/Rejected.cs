// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ResponseProcessingStatus1Choice
{
    /// <summary>
    /// The received message or the multipart received report (sent with pagination in multiple messages) is rejected.
    /// </summary>
    [IsoId("_mjD0wIeUEemJ1cSJJmVYRQ")]
    [DisplayName("Rejected")]
    public record Rejected : ResponseProcessingStatus1Choice_ { }
}
