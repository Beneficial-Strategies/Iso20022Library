// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountIdentification1Choice
{
    /// <summary>Account identified by a safekeeping account number.</summary>
    [IsoId("_s5w_SN-5Ee-Ned3-G07x_A")]
    [DisplayName("Safekeeping Account")]
    public record SafekeepingAccount : SecuritiesAccountIdentification1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("SfkpgAcct")]
        public required IsoMax35Text Value { get; init; }
    }
}
