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
    /// Provides the investigation results.
    /// </summary>
    [KnownType(typeof(InvestigationResult1Choice.Result))]
    [KnownType(typeof(InvestigationResult1Choice.InvestigationStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestigationResult1Choice.Result),nameof(InvestigationResult1Choice.Result))]
    [JsonDerivedType(typeof(InvestigationResult1Choice.InvestigationStatus),nameof(InvestigationResult1Choice.InvestigationStatus))]
    #endif
    [IsoId("_TRkjcGgkEeGHuf0_3c6vdw")]
    [DisplayName("Investigation Result 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestigationResult1Choice_
    #else
    public abstract partial class InvestigationResult1Choice_
    #endif
    {
    }
}
