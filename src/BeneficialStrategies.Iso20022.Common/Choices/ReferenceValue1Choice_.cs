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
    /// Choice of options for references.
    /// </summary>
    [KnownType(typeof(ReferenceValue1Choice.UUID))]
    [KnownType(typeof(ReferenceValue1Choice.IRI))]
    [KnownType(typeof(ReferenceValue1Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReferenceValue1Choice.UUID),nameof(ReferenceValue1Choice.UUID))]
    [JsonDerivedType(typeof(ReferenceValue1Choice.IRI),nameof(ReferenceValue1Choice.IRI))]
    [JsonDerivedType(typeof(ReferenceValue1Choice.Other),nameof(ReferenceValue1Choice.Other))]
    #endif
    [IsoId("_Q6wqUMePEeysUoBKYz1Ytw")]
    [DisplayName("Reference Value 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReferenceValue1Choice_
    #else
    public abstract partial class ReferenceValue1Choice_
    #endif
    {
    }
}
