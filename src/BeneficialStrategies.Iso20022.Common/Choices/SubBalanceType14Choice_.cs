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
    [KnownType(typeof(SubBalanceType14Choice.Code))]
    [KnownType(typeof(SubBalanceType14Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SubBalanceType14Choice.Code),nameof(SubBalanceType14Choice.Code))]
    [JsonDerivedType(typeof(SubBalanceType14Choice.Proprietary),nameof(SubBalanceType14Choice.Proprietary))]
    #endif
    [IsoId("_5W6c6ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Sub Balance Type 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceType14Choice_
    #else
    public abstract partial class SubBalanceType14Choice_
    #endif
    {
    }
}
