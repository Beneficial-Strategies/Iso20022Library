// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BeneficialStrategies.Iso20022.Choices.PenaltyListType1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the penalty list type.</summary>
    [IsoId("_-dWOMdfNEeiJ1vId85LeLw")]
    [DisplayName("Penalty List Type 1 Choice")]
    [KnownType(typeof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Code))]
    [JsonDerivedType(typeof(Proprietary))]
    public abstract record PenaltyListType1Choice_;
}
