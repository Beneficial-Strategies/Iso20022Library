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
    /// Choice between selected investment plans issued during previous years or the entirety of the investment plans.
    /// </summary>
    [KnownType(typeof(PreviousYear1Choice.AllPreviousYears))]
    [KnownType(typeof(PreviousYear1Choice.SpecificPreviousYears))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PreviousYear1Choice.AllPreviousYears),nameof(PreviousYear1Choice.AllPreviousYears))]
    [JsonDerivedType(typeof(PreviousYear1Choice.SpecificPreviousYears),nameof(PreviousYear1Choice.SpecificPreviousYears))]
    #endif
    [IsoId("_3fxScUXfEeGY6MkiuzuPOA_-1781639499")]
    [DisplayName("Previous Year 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PreviousYear1Choice_
    #else
    public abstract partial class PreviousYear1Choice_
    #endif
    {
    }
}
