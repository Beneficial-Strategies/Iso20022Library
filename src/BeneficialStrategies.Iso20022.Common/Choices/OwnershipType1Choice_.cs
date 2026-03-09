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
    /// Choice of formats for the specification of the ownership type.
    /// </summary>
    [KnownType(typeof(OwnershipType1Choice.Code))]
    [KnownType(typeof(OwnershipType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OwnershipType1Choice.Code),nameof(OwnershipType1Choice.Code))]
    [JsonDerivedType(typeof(OwnershipType1Choice.Proprietary),nameof(OwnershipType1Choice.Proprietary))]
    #endif
    [IsoId("_ZlS-0xc9EeK5g-3oYI0_9Q")]
    [DisplayName("Ownership Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OwnershipType1Choice_
    #else
    public abstract partial class OwnershipType1Choice_
    #endif
    {
    }
}
