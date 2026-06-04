// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>Proprietary identification of the security assigned by an institution or organisation.</summary>
    [IsoId("4aeb15f2-9a90-4ce5-8ea9-a593e3e6532f")]
    [DisplayName("Other Proprietary Identification")]
    public record OtherProprietaryIdentification : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("OthrPrtryId")]
        public required AlternateSecurityIdentification7 Value { get; init; }
    }
}
