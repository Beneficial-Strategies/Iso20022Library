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
    /// Choice between an number and an option number in a code format.
    /// </summary>
    [KnownType(typeof(OptionNumber1Choice.Number))]
    [KnownType(typeof(OptionNumber1Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionNumber1Choice.Number),nameof(OptionNumber1Choice.Number))]
    [JsonDerivedType(typeof(OptionNumber1Choice.Code),nameof(OptionNumber1Choice.Code))]
    #endif
    [IsoId("_Q1O84dp-Ed-ak6NoX_4Aeg_-1276805181")]
    [DisplayName("Option Number 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionNumber1Choice_
    #else
    public abstract partial class OptionNumber1Choice_
    #endif
    {
    }
}
