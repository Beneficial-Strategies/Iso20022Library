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
    /// Choice of format for the type of narrative.
    /// </summary>
    [KnownType(typeof(NarrativeType1Choice.Code))]
    [KnownType(typeof(NarrativeType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NarrativeType1Choice.Code),nameof(NarrativeType1Choice.Code))]
    [JsonDerivedType(typeof(NarrativeType1Choice.Proprietary),nameof(NarrativeType1Choice.Proprietary))]
    #endif
    [IsoId("_93HE0nltEeG7BsjMvd1mEw_-1199542784")]
    [DisplayName("Narrative Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NarrativeType1Choice_
    #else
    public abstract partial class NarrativeType1Choice_
    #endif
    {
    }
}
