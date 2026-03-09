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
    [KnownType(typeof(PartyIdentification10Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification10Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification10Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification10Choice.BICOrBEI),nameof(PartyIdentification10Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification10Choice.ProprietaryIdentification),nameof(PartyIdentification10Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification10Choice.NameAndAddress),nameof(PartyIdentification10Choice.NameAndAddress))]
    #endif
    [IsoId("_QQR1tdp-Ed-ak6NoX_4Aeg_-1244141483")]
    [DisplayName("Party Identification 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification10Choice_
    #else
    public abstract partial class PartyIdentification10Choice_
    #endif
    {
    }
}
