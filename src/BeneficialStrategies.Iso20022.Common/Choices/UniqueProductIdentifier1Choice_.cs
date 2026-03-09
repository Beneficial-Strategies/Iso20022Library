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
    /// Element is a choice between a standard identifier and a proprietary code.
    /// </summary>
    [KnownType(typeof(UniqueProductIdentifier1Choice.Identification))]
    [KnownType(typeof(UniqueProductIdentifier1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UniqueProductIdentifier1Choice.Identification),nameof(UniqueProductIdentifier1Choice.Identification))]
    [JsonDerivedType(typeof(UniqueProductIdentifier1Choice.Proprietary),nameof(UniqueProductIdentifier1Choice.Proprietary))]
    #endif
    [IsoId("_rTVXISyFEe2xAdY9t5fB3g")]
    [DisplayName("Unique Product Identifier 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UniqueProductIdentifier1Choice_
    #else
    public abstract partial class UniqueProductIdentifier1Choice_
    #endif
    {
    }
}
