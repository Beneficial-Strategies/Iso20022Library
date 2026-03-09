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
    [KnownType(typeof(UnsecuredMarketReport3Choice.DataSetAction))]
    [KnownType(typeof(UnsecuredMarketReport3Choice.Transaction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnsecuredMarketReport3Choice.DataSetAction),nameof(UnsecuredMarketReport3Choice.DataSetAction))]
    [JsonDerivedType(typeof(UnsecuredMarketReport3Choice.Transaction),nameof(UnsecuredMarketReport3Choice.Transaction))]
    #endif
    [IsoId("_Gm8z9aifEeWHO_l3hf2rlA")]
    [DisplayName("Unsecured Market Report 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnsecuredMarketReport3Choice_
    #else
    public abstract partial class UnsecuredMarketReport3Choice_
    #endif
    {
    }
}
