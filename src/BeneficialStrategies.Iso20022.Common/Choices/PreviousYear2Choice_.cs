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
    /// Choice between selected investment plans issued during previous years or all investment plans.
    /// </summary>
    [KnownType(typeof(PreviousYear2Choice.AllPreviousYears))]
    [KnownType(typeof(PreviousYear2Choice.SpecificPreviousYears))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PreviousYear2Choice.AllPreviousYears),nameof(PreviousYear2Choice.AllPreviousYears))]
    [JsonDerivedType(typeof(PreviousYear2Choice.SpecificPreviousYears),nameof(PreviousYear2Choice.SpecificPreviousYears))]
    #endif
    [IsoId("_dNZ_cbNBEeex65jrLOfSTw")]
    [DisplayName("Previous Year 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PreviousYear2Choice_
    #else
    public abstract partial class PreviousYear2Choice_
    #endif
    {
    }
}
