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
    /// Choice between specification of the data in structured or free text format.
    /// </summary>
    [KnownType(typeof(DataFormat1Choice.Structured))]
    [KnownType(typeof(DataFormat1Choice.Unstructured))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DataFormat1Choice.Structured),nameof(DataFormat1Choice.Structured))]
    [JsonDerivedType(typeof(DataFormat1Choice.Unstructured),nameof(DataFormat1Choice.Unstructured))]
    #endif
    [IsoId("_Uys4Bdp-Ed-ak6NoX_4Aeg_1324048594")]
    [DisplayName("Data Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DataFormat1Choice_
    #else
    public abstract partial class DataFormat1Choice_
    #endif
    {
    }
}
