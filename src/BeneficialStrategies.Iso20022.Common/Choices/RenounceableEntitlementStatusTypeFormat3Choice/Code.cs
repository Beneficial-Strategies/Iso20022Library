// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RenounceableEntitlementStatusTypeFormat3Choice
{
    /// <summary>
    /// Standard code to specify the renounceable status.
    /// </summary>
    [IsoId("_7EiSoUEBEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : RenounceableEntitlementStatusTypeFormat3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the renounceable status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RenounceableStatus1Code Value { get; init; }
    }
}
