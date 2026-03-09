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
    [KnownType(typeof(SubBalanceType6Choice.Code))]
    [KnownType(typeof(SubBalanceType6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SubBalanceType6Choice.Code),nameof(SubBalanceType6Choice.Code))]
    [JsonDerivedType(typeof(SubBalanceType6Choice.Proprietary),nameof(SubBalanceType6Choice.Proprietary))]
    #endif
    [IsoId("_QYBcfNp-Ed-ak6NoX_4Aeg_1907481606")]
    [DisplayName("Sub Balance Type 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceType6Choice_
    #else
    public abstract partial class SubBalanceType6Choice_
    #endif
    {
    }
}
