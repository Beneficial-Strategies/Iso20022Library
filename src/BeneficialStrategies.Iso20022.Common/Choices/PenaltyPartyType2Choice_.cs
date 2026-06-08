// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BeneficialStrategies.Iso20022.Choices.PenaltyPartyType2Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies the penalties party type.</summary>
    [IsoId("_-EPy1QAUEeqOHNEXayM0Mg")]
    [DisplayName("Penalty Party Type 2 Choice")]
    [KnownType(typeof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Code))]
    [JsonDerivedType(typeof(Proprietary))]
    public abstract record PenaltyPartyType2Choice_;
}
