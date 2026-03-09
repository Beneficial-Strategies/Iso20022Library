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
    /// Choice between the specification of the data in a structured or unstructured form.
    /// </summary>
    [KnownType(typeof(DataFormat2Choice.Structured))]
    [KnownType(typeof(DataFormat2Choice.Unstructured))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DataFormat2Choice.Structured),nameof(DataFormat2Choice.Structured))]
    [JsonDerivedType(typeof(DataFormat2Choice.Unstructured),nameof(DataFormat2Choice.Unstructured))]
    #endif
    [IsoId("_Q6vvBdp-Ed-ak6NoX_4Aeg_-2133276556")]
    [DisplayName("Data Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DataFormat2Choice_
    #else
    public abstract partial class DataFormat2Choice_
    #endif
    {
    }
}
