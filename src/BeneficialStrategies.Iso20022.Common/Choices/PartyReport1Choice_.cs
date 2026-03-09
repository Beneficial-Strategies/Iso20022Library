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
    /// Report of the relevant institution. The report can be either an update or a cancellation.
    /// </summary>
    [KnownType(typeof(PartyReport1Choice.Update))]
    [KnownType(typeof(PartyReport1Choice.Cancellation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyReport1Choice.Update),nameof(PartyReport1Choice.Update))]
    [JsonDerivedType(typeof(PartyReport1Choice.Cancellation),nameof(PartyReport1Choice.Cancellation))]
    #endif
    [IsoId("_77i8YDbtEeeYhaZ6bvG1Xg")]
    [DisplayName("Party Report 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyReport1Choice_
    #else
    public abstract partial class PartyReport1Choice_
    #endif
    {
    }
}
