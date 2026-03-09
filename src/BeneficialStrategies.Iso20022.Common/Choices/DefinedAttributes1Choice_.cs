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
    /// Specifies the choice between different types of derivative.
    /// </summary>
    [KnownType(typeof(DefinedAttributes1Choice.QuantityDefinedAttributes))]
    [KnownType(typeof(DefinedAttributes1Choice.ValueDefinedAttributes))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DefinedAttributes1Choice.QuantityDefinedAttributes),nameof(DefinedAttributes1Choice.QuantityDefinedAttributes))]
    [JsonDerivedType(typeof(DefinedAttributes1Choice.ValueDefinedAttributes),nameof(DefinedAttributes1Choice.ValueDefinedAttributes))]
    #endif
    [IsoId("_wa3m8OPJEea7_eMQH225xA")]
    [DisplayName("Defined Attributes 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DefinedAttributes1Choice_
    #else
    public abstract partial class DefinedAttributes1Choice_
    #endif
    {
    }
}
