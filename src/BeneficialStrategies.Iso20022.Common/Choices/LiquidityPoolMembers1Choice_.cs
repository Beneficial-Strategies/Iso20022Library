// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between head member or subordinate member identifiers of liquidity pool.
    /// </summary>
    [KnownType(typeof(LiquidityPoolMembers1Choice.HeadMemberDetails))]
    [KnownType(typeof(LiquidityPoolMembers1Choice.SubordinateMemberDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LiquidityPoolMembers1Choice.HeadMemberDetails),nameof(LiquidityPoolMembers1Choice.HeadMemberDetails))]
    [JsonDerivedType(typeof(LiquidityPoolMembers1Choice.SubordinateMemberDetails),nameof(LiquidityPoolMembers1Choice.SubordinateMemberDetails))]
    #endif
    [IsoId("_lgRlYCDsEeav65mEytrgaA")]
    [DisplayName("Liquidity Pool Members 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LiquidityPoolMembers1Choice_
    #else
    public abstract partial class LiquidityPoolMembers1Choice_
    #endif
    {
    }
}
