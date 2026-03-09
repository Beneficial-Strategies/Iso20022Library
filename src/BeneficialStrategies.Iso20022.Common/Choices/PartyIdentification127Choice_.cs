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
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification127Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification127Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification127Choice.AnyBIC),nameof(PartyIdentification127Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification127Choice.ProprietaryIdentification),nameof(PartyIdentification127Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_Y-_MD7XDEeiTob_PrFFUxA")]
    [DisplayName("Party Identification 127 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification127Choice_
    #else
    public abstract partial class PartyIdentification127Choice_
    #endif
    {
    }
}
