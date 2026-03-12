// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between head member or subordinate member identifiers of liquidity pool.
    /// </summary>
    [KnownType(typeof(LiquidityPoolMembers1Choice.HeadMemberDetails))]
    [KnownType(typeof(LiquidityPoolMembers1Choice.SubordinateMemberDetails))]
    [JsonDerivedType(typeof(LiquidityPoolMembers1Choice.HeadMemberDetails),nameof(LiquidityPoolMembers1Choice.HeadMemberDetails))]
    [JsonDerivedType(typeof(LiquidityPoolMembers1Choice.SubordinateMemberDetails),nameof(LiquidityPoolMembers1Choice.SubordinateMemberDetails))]
    [IsoId("_lgRlYCDsEeav65mEytrgaA")]
    [DisplayName("Liquidity Pool Members 1 Choice")]
    public abstract partial record LiquidityPoolMembers1Choice_
    {
    }
}
