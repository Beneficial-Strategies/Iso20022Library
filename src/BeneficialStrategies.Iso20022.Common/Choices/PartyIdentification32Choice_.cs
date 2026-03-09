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
    [KnownType(typeof(PartyIdentification32Choice.BIC))]
    [KnownType(typeof(PartyIdentification32Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification32Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification32Choice.BIC),nameof(PartyIdentification32Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification32Choice.ProprietaryIdentification),nameof(PartyIdentification32Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification32Choice.NameAndAddress),nameof(PartyIdentification32Choice.NameAndAddress))]
    #endif
    [IsoId("_AUVtwdokEeC60axPepSq7g_2140402987")]
    [DisplayName("Party Identification 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification32Choice_
    #else
    public abstract partial class PartyIdentification32Choice_
    #endif
    {
    }
}
