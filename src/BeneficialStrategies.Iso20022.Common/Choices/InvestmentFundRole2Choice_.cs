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
    /// Choice of formats for a Role.
    /// </summary>
    [KnownType(typeof(InvestmentFundRole2Choice.Code))]
    [KnownType(typeof(InvestmentFundRole2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestmentFundRole2Choice.Code),nameof(InvestmentFundRole2Choice.Code))]
    [JsonDerivedType(typeof(InvestmentFundRole2Choice.Proprietary),nameof(InvestmentFundRole2Choice.Proprietary))]
    #endif
    [IsoId("_cdaGUDhcEeaRwdGFv45qTQ")]
    [DisplayName("Investment Fund Role 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestmentFundRole2Choice_
    #else
    public abstract partial class InvestmentFundRole2Choice_
    #endif
    {
    }
}
