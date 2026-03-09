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
    [KnownType(typeof(PartyOrBusinessError1Choice.BusinessError))]
    [KnownType(typeof(PartyOrBusinessError1Choice.SystemParty))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyOrBusinessError1Choice.BusinessError),nameof(PartyOrBusinessError1Choice.BusinessError))]
    [JsonDerivedType(typeof(PartyOrBusinessError1Choice.SystemParty),nameof(PartyOrBusinessError1Choice.SystemParty))]
    #endif
    [IsoId("_knr44-5NEeCisYr99QEiWA_102228919")]
    [DisplayName("Party Or Business Error 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyOrBusinessError1Choice_
    #else
    public abstract partial class PartyOrBusinessError1Choice_
    #endif
    {
    }
}
