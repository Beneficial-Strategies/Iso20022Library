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
    /// Identification of a party by BIC or by name and address.
    /// </summary>
    [KnownType(typeof(PartyIdentification29Choice.BIC))]
    [KnownType(typeof(PartyIdentification29Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification29Choice.BIC),nameof(PartyIdentification29Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification29Choice.NameAndAddress),nameof(PartyIdentification29Choice.NameAndAddress))]
    #endif
    [IsoId("_QFGgcNp-Ed-ak6NoX_4Aeg_-162334661")]
    [DisplayName("Party Identification 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification29Choice_
    #else
    public abstract partial class PartyIdentification29Choice_
    #endif
    {
    }
}
