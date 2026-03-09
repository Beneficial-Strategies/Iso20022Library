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
    /// Specifies the matching processing change requested expressed as code
    /// </summary>
    [KnownType(typeof(Removal1Choice.Code))]
    [KnownType(typeof(Removal1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Removal1Choice.Code),nameof(Removal1Choice.Code))]
    [JsonDerivedType(typeof(Removal1Choice.Proprietary),nameof(Removal1Choice.Proprietary))]
    #endif
    [IsoId("_f6-tYPkREeicy5Zn42b9bg")]
    [DisplayName("Removal 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Removal1Choice_
    #else
    public abstract partial class Removal1Choice_
    #endif
    {
    }
}
