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
    /// Choice of format for the frequency.
    /// </summary>
    [KnownType(typeof(Frequency8Choice.Code))]
    [KnownType(typeof(Frequency8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Frequency8Choice.Code),nameof(Frequency8Choice.Code))]
    [JsonDerivedType(typeof(Frequency8Choice.Proprietary),nameof(Frequency8Choice.Proprietary))]
    #endif
    [IsoId("_m_xsdfNBEeCuA5Tr22BnwA_2080535464")]
    [DisplayName("Frequency 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Frequency8Choice_
    #else
    public abstract partial class Frequency8Choice_
    #endif
    {
    }
}
