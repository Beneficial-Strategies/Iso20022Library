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
    /// Choice between a reason for no activity and the unsecured market segment transaction details.
    /// </summary>
    [KnownType(typeof(UnsecuredMarketReport4Choice.DataSetAction))]
    [KnownType(typeof(UnsecuredMarketReport4Choice.Transaction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnsecuredMarketReport4Choice.DataSetAction),nameof(UnsecuredMarketReport4Choice.DataSetAction))]
    [JsonDerivedType(typeof(UnsecuredMarketReport4Choice.Transaction),nameof(UnsecuredMarketReport4Choice.Transaction))]
    #endif
    [IsoId("_G-P9i8EREea7jLfvGi1PDw")]
    [DisplayName("Unsecured Market Report 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnsecuredMarketReport4Choice_
    #else
    public abstract partial class UnsecuredMarketReport4Choice_
    #endif
    {
    }
}
