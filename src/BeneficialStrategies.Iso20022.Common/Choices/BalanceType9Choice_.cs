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
    /// Specifies the balance details.
    /// </summary>
    [KnownType(typeof(BalanceType9Choice.Code))]
    [KnownType(typeof(BalanceType9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceType9Choice.Code),nameof(BalanceType9Choice.Code))]
    [JsonDerivedType(typeof(BalanceType9Choice.Proprietary),nameof(BalanceType9Choice.Proprietary))]
    #endif
    [IsoId("_77AUUaMgEeCJ6YNENx4h-w_-1046252511")]
    [DisplayName("Balance Type 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceType9Choice_
    #else
    public abstract partial class BalanceType9Choice_
    #endif
    {
    }
}
