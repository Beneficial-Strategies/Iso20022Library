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
    /// Reference to a message.
    /// </summary>
    [KnownType(typeof(LinkedMessage1Choice.PreviousReference))]
    [KnownType(typeof(LinkedMessage1Choice.OtherReference))]
    [KnownType(typeof(LinkedMessage1Choice.RelatedReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LinkedMessage1Choice.PreviousReference),nameof(LinkedMessage1Choice.PreviousReference))]
    [JsonDerivedType(typeof(LinkedMessage1Choice.OtherReference),nameof(LinkedMessage1Choice.OtherReference))]
    [JsonDerivedType(typeof(LinkedMessage1Choice.RelatedReference),nameof(LinkedMessage1Choice.RelatedReference))]
    #endif
    [IsoId("_7Q8FcQgJEeSFYfyUKDXKaw")]
    [DisplayName("Linked Message 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LinkedMessage1Choice_
    #else
    public abstract partial class LinkedMessage1Choice_
    #endif
    {
    }
}
