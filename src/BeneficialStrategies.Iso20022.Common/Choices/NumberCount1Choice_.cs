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
    /// Choice of number count type.
    /// </summary>
    [KnownType(typeof(NumberCount1Choice.CurrentInstructionNumber))]
    [KnownType(typeof(NumberCount1Choice.TotalNumber))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NumberCount1Choice.CurrentInstructionNumber),nameof(NumberCount1Choice.CurrentInstructionNumber))]
    [JsonDerivedType(typeof(NumberCount1Choice.TotalNumber),nameof(NumberCount1Choice.TotalNumber))]
    #endif
    [IsoId("_QrsmZ9p-Ed-ak6NoX_4Aeg_994582654")]
    [DisplayName("Number Count 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NumberCount1Choice_
    #else
    public abstract partial class NumberCount1Choice_
    #endif
    {
    }
}
