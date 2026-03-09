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
    /// Choice of formats for the restriction or limitation status.
    /// </summary>
    [KnownType(typeof(RestrictionStatus1Choice.Code))]
    [KnownType(typeof(RestrictionStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RestrictionStatus1Choice.Code),nameof(RestrictionStatus1Choice.Code))]
    [JsonDerivedType(typeof(RestrictionStatus1Choice.Proprietary),nameof(RestrictionStatus1Choice.Proprietary))]
    #endif
    [IsoId("_UWN50CFnEeW9XJWqfgXIIA")]
    [DisplayName("Restriction Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RestrictionStatus1Choice_
    #else
    public abstract partial class RestrictionStatus1Choice_
    #endif
    {
    }
}
