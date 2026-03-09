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
    /// Identification of the investment party.
    /// </summary>
    [KnownType(typeof(InvestmentParty1Choice.Person))]
    [KnownType(typeof(InvestmentParty1Choice.Algorithm))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestmentParty1Choice.Person),nameof(InvestmentParty1Choice.Person))]
    [JsonDerivedType(typeof(InvestmentParty1Choice.Algorithm),nameof(InvestmentParty1Choice.Algorithm))]
    #endif
    [IsoId("_yM5zQenQEeSsIMG7XCyDQw")]
    [DisplayName("Investment Party 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestmentParty1Choice_
    #else
    public abstract partial class InvestmentParty1Choice_
    #endif
    {
    }
}
