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
    [KnownType(typeof(PartyIdentification1Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification1Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification1Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification1Choice.BICOrBEI),nameof(PartyIdentification1Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification1Choice.ProprietaryIdentification),nameof(PartyIdentification1Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification1Choice.NameAndAddress),nameof(PartyIdentification1Choice.NameAndAddress))]
    #endif
    [IsoId("_QQR1v9p-Ed-ak6NoX_4Aeg_-1748201287")]
    [DisplayName("Party Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification1Choice_
    #else
    public abstract partial class PartyIdentification1Choice_
    #endif
    {
    }
}
