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
    /// Choice of format for the settlement capacity information.
    /// </summary>
    [KnownType(typeof(SettlingCapacity3Choice.Code))]
    [KnownType(typeof(SettlingCapacity3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlingCapacity3Choice.Code),nameof(SettlingCapacity3Choice.Code))]
    [JsonDerivedType(typeof(SettlingCapacity3Choice.Proprietary),nameof(SettlingCapacity3Choice.Proprietary))]
    #endif
    [IsoId("_AZQqBNokEeC60axPepSq7g_550780639")]
    [DisplayName("Settling Capacity 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlingCapacity3Choice_
    #else
    public abstract partial class SettlingCapacity3Choice_
    #endif
    {
    }
}
