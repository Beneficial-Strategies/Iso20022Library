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
    /// Choice between formats for a partially settled reason.
    /// </summary>
    [KnownType(typeof(PartiallySettled21Choice.Code))]
    [KnownType(typeof(PartiallySettled21Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartiallySettled21Choice.Code),nameof(PartiallySettled21Choice.Code))]
    [JsonDerivedType(typeof(PartiallySettled21Choice.Proprietary),nameof(PartiallySettled21Choice.Proprietary))]
    #endif
    [IsoId("_R48xQUHtEeaNSo9he0Belg")]
    [DisplayName("Partially Settled 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartiallySettled21Choice_
    #else
    public abstract partial class PartiallySettled21Choice_
    #endif
    {
    }
}
