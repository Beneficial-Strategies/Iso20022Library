// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>QUICK identifier assigned by the Tokyo Stock Exchange.</summary>
    [IsoId("de032459-0f5c-466c-9c83-322f87ed7fce")]
    [DisplayName("QUICK")]
    public record QUICK : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("QUICK")]
        public required IsoQUICKIdentifier Value { get; init; }
    }
}
