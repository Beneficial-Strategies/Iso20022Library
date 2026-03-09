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
    /// Choice of format for the investor type.
    /// </summary>
    [KnownType(typeof(InvestorType1Choice.Code))]
    [KnownType(typeof(InvestorType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestorType1Choice.Code),nameof(InvestorType1Choice.Code))]
    [JsonDerivedType(typeof(InvestorType1Choice.Proprietary),nameof(InvestorType1Choice.Proprietary))]
    #endif
    [IsoId("_7Z_KcIzxEemXJvzC2Wyt1g")]
    [DisplayName("Investor Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestorType1Choice_
    #else
    public abstract partial class InvestorType1Choice_
    #endif
    {
    }
}
