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
    /// Choice number format.
    /// </summary>
    [KnownType(typeof(Number21Choice.NumberIdentification))]
    [KnownType(typeof(Number21Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Number21Choice.NumberIdentification),nameof(Number21Choice.NumberIdentification))]
    [JsonDerivedType(typeof(Number21Choice.Proprietary),nameof(Number21Choice.Proprietary))]
    #endif
    [IsoId("_AeehM9okEeC60axPepSq7g_363304581")]
    [DisplayName("Number 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Number21Choice_
    #else
    public abstract partial class Number21Choice_
    #endif
    {
    }
}
