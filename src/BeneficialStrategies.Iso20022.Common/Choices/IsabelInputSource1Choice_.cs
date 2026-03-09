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
    /// Choice of input source for the generation of the file.
    /// </summary>
    [KnownType(typeof(IsabelInputSource1Choice.Code))]
    [KnownType(typeof(IsabelInputSource1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IsabelInputSource1Choice.Code),nameof(IsabelInputSource1Choice.Code))]
    [JsonDerivedType(typeof(IsabelInputSource1Choice.Proprietary),nameof(IsabelInputSource1Choice.Proprietary))]
    #endif
    [IsoId("_OGcMMMmMEeWAGphE2LvqeA")]
    [DisplayName("Isabel Input Source 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IsabelInputSource1Choice_
    #else
    public abstract partial class IsabelInputSource1Choice_
    #endif
    {
    }
}
