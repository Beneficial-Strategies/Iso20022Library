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
    [KnownType(typeof(SubBalanceType5Choice.Code))]
    [KnownType(typeof(SubBalanceType5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SubBalanceType5Choice.Code),nameof(SubBalanceType5Choice.Code))]
    [JsonDerivedType(typeof(SubBalanceType5Choice.Proprietary),nameof(SubBalanceType5Choice.Proprietary))]
    #endif
    [IsoId("_QYU-dNp-Ed-ak6NoX_4Aeg_-408061130")]
    [DisplayName("Sub Balance Type 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceType5Choice_
    #else
    public abstract partial class SubBalanceType5Choice_
    #endif
    {
    }
}
