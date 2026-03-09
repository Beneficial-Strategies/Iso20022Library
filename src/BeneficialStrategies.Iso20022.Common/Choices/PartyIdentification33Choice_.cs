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
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification33Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification33Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification33Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification33Choice.AnyBIC),nameof(PartyIdentification33Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification33Choice.ProprietaryIdentification),nameof(PartyIdentification33Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification33Choice.NameAndAddress),nameof(PartyIdentification33Choice.NameAndAddress))]
    #endif
    [IsoId("_QPiO19p-Ed-ak6NoX_4Aeg_392714939")]
    [DisplayName("Party Identification 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification33Choice_
    #else
    public abstract partial class PartyIdentification33Choice_
    #endif
    {
    }
}
