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
    /// Report between the party reference data or a business error.
    /// </summary>
    [KnownType(typeof(PartyOrBusinessError3Choice.SystemParty))]
    [KnownType(typeof(PartyOrBusinessError3Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyOrBusinessError3Choice.SystemParty),nameof(PartyOrBusinessError3Choice.SystemParty))]
    [JsonDerivedType(typeof(PartyOrBusinessError3Choice.BusinessError),nameof(PartyOrBusinessError3Choice.BusinessError))]
    #endif
    [IsoId("_0CyYAYwXEei289CGNqs21g")]
    [DisplayName("Party Or Business Error 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyOrBusinessError3Choice_
    #else
    public abstract partial class PartyOrBusinessError3Choice_
    #endif
    {
    }
}
