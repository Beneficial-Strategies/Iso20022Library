// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PenaltyListType1Choice
{
    /// <summary>Specifies the penalty list reported, in a coded format.</summary>
    [IsoId("_-p6qk9fNEeiJ1vId85LeLw")]
    [DisplayName("Code")]
    public record Code : PenaltyListType1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PenaltyListType1Code Value { get; init; }
    }
}
