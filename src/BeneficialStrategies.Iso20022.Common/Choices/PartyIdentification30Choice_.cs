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
    [KnownType(typeof(PartyIdentification30Choice.BIC))]
    [KnownType(typeof(PartyIdentification30Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification30Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification30Choice.BIC),nameof(PartyIdentification30Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification30Choice.NameAndAddress),nameof(PartyIdentification30Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification30Choice.ProprietaryIdentification),nameof(PartyIdentification30Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_QQIEttp-Ed-ak6NoX_4Aeg_-73053058")]
    [DisplayName("Party Identification 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification30Choice_
    #else
    public abstract partial class PartyIdentification30Choice_
    #endif
    {
    }
}
