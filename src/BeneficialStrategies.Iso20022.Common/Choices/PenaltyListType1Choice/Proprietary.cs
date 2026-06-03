// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PenaltyListType1Choice
{
    /// <summary>Specifies the penalty list reported, in a proprietary format.</summary>
    [IsoId("_-p6qldfNEeiJ1vId85LeLw")]
    [DisplayName("Proprietary")]
    public record Proprietary : PenaltyListType1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
