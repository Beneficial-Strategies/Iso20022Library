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
    /// Choice of format for the undertaking type.
    /// </summary>
    [KnownType(typeof(UndertakingType1Choice.Code))]
    [KnownType(typeof(UndertakingType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UndertakingType1Choice.Code),nameof(UndertakingType1Choice.Code))]
    [JsonDerivedType(typeof(UndertakingType1Choice.Proprietary),nameof(UndertakingType1Choice.Proprietary))]
    #endif
    [IsoId("_92qY6HltEeG7BsjMvd1mEw_72990354")]
    [DisplayName("Undertaking Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UndertakingType1Choice_
    #else
    public abstract partial class UndertakingType1Choice_
    #endif
    {
    }
}
