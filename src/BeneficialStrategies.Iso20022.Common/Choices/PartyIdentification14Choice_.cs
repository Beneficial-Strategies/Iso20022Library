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
    [KnownType(typeof(PartyIdentification14Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification14Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification14Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification14Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification14Choice.BICOrBEI),nameof(PartyIdentification14Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification14Choice.ProprietaryIdentification),nameof(PartyIdentification14Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification14Choice.NameAndAddress),nameof(PartyIdentification14Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification14Choice.Country),nameof(PartyIdentification14Choice.Country))]
    #endif
    [IsoId("_QP1Jxtp-Ed-ak6NoX_4Aeg_990739070")]
    [DisplayName("Party Identification 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification14Choice_
    #else
    public abstract partial class PartyIdentification14Choice_
    #endif
    {
    }
}
