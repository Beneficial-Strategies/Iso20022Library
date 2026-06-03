// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PenaltyStatusReason2Choice;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies the penalties status reason.</summary>
    [IsoId("_vEVX1R-DEeuwwezkzufkMw")]
    [DisplayName("Penalty Status Reason 2 Choice")]
    [KnownType(typeof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Code))]
    [JsonDerivedType(typeof(Proprietary))]
    public abstract record PenaltyStatusReason2Choice_;
}
