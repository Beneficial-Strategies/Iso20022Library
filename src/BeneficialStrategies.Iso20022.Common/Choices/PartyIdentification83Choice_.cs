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
    [KnownType(typeof(PartyIdentification83Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification83Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification83Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification83Choice.AnyBIC),nameof(PartyIdentification83Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification83Choice.ProprietaryIdentification),nameof(PartyIdentification83Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification83Choice.NameAndAddress),nameof(PartyIdentification83Choice.NameAndAddress))]
    #endif
    [IsoId("_H6bfUC6HEeSQQqw1BT_aMg")]
    [DisplayName("Party Identification 83 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification83Choice_
    #else
    public abstract partial class PartyIdentification83Choice_
    #endif
    {
    }
}
