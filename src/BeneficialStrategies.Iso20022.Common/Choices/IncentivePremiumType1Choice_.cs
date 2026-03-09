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
    /// Choice of cash premium paid to the security holder when voting.
    /// </summary>
    [KnownType(typeof(IncentivePremiumType1Choice.PerSecurity))]
    [KnownType(typeof(IncentivePremiumType1Choice.PerVote))]
    [KnownType(typeof(IncentivePremiumType1Choice.PerAttendee))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IncentivePremiumType1Choice.PerSecurity),nameof(IncentivePremiumType1Choice.PerSecurity))]
    [JsonDerivedType(typeof(IncentivePremiumType1Choice.PerVote),nameof(IncentivePremiumType1Choice.PerVote))]
    [JsonDerivedType(typeof(IncentivePremiumType1Choice.PerAttendee),nameof(IncentivePremiumType1Choice.PerAttendee))]
    #endif
    [IsoId("_RDieodp-Ed-ak6NoX_4Aeg_1038160776")]
    [DisplayName("Incentive Premium Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IncentivePremiumType1Choice_
    #else
    public abstract partial class IncentivePremiumType1Choice_
    #endif
    {
    }
}
