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
    /// Provides details on the margin result.
    /// </summary>
    [KnownType(typeof(MarginResult1Choice.ExcessAmount))]
    [KnownType(typeof(MarginResult1Choice.DeficitAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarginResult1Choice.ExcessAmount),nameof(MarginResult1Choice.ExcessAmount))]
    [JsonDerivedType(typeof(MarginResult1Choice.DeficitAmount),nameof(MarginResult1Choice.DeficitAmount))]
    #endif
    [IsoId("_Qk1wddp-Ed-ak6NoX_4Aeg_-1613861504")]
    [DisplayName("Margin Result 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarginResult1Choice_
    #else
    public abstract partial class MarginResult1Choice_
    #endif
    {
    }
}
