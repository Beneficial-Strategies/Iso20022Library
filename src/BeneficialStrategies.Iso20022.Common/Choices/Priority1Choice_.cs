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
    /// Priority is expressed as a code or a text.
    /// </summary>
    [KnownType(typeof(Priority1Choice.Code))]
    [KnownType(typeof(Priority1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Priority1Choice.Code),nameof(Priority1Choice.Code))]
    [JsonDerivedType(typeof(Priority1Choice.Proprietary),nameof(Priority1Choice.Proprietary))]
    #endif
    [IsoId("_SEJYAX_REeiik6YN_dzlEA")]
    [DisplayName("Priority 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Priority1Choice_
    #else
    public abstract partial class Priority1Choice_
    #endif
    {
    }
}
