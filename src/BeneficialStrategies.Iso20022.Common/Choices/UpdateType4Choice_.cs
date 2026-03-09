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
    /// Choice of format for the update information.
    /// </summary>
    [KnownType(typeof(UpdateType4Choice.Code))]
    [KnownType(typeof(UpdateType4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UpdateType4Choice.Code),nameof(UpdateType4Choice.Code))]
    [JsonDerivedType(typeof(UpdateType4Choice.Proprietary),nameof(UpdateType4Choice.Proprietary))]
    #endif
    [IsoId("_m_7dcvNBEeCuA5Tr22BnwA_1235220635")]
    [DisplayName("Update Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType4Choice_
    #else
    public abstract partial class UpdateType4Choice_
    #endif
    {
    }
}
