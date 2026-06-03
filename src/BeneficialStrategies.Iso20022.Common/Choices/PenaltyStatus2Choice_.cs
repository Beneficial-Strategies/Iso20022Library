// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PenaltyStatus2Choice;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies the penalties status.</summary>
    [IsoId("_99VSwR-LEeuwwezkzufkMw")]
    [DisplayName("Penalty Status 2 Choice")]
    [KnownType(typeof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Code))]
    [JsonDerivedType(typeof(Proprietary))]
    public abstract record PenaltyStatus2Choice_;
}
