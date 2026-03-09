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
    /// Choice of format for the sub-balance.
    /// </summary>
    [KnownType(typeof(SubBalanceType9Choice.Code))]
    [KnownType(typeof(SubBalanceType9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SubBalanceType9Choice.Code),nameof(SubBalanceType9Choice.Code))]
    [JsonDerivedType(typeof(SubBalanceType9Choice.Proprietary),nameof(SubBalanceType9Choice.Proprietary))]
    #endif
    [IsoId("_YekH94jvEeONZKAAW4pOaQ")]
    [DisplayName("Sub Balance Type 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceType9Choice_
    #else
    public abstract partial class SubBalanceType9Choice_
    #endif
    {
    }
}
