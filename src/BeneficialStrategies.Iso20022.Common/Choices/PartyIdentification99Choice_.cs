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
    /// Identification of a party by a choice between a BIC or a name and address.
    /// </summary>
    [KnownType(typeof(PartyIdentification99Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification99Choice.AnyBIC))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification99Choice.NameAndAddress),nameof(PartyIdentification99Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification99Choice.AnyBIC),nameof(PartyIdentification99Choice.AnyBIC))]
    #endif
    [IsoId("_-uWGYWz9EeWv_oZ1Y01DUQ")]
    [DisplayName("Party Identification 99 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification99Choice_
    #else
    public abstract partial class PartyIdentification99Choice_
    #endif
    {
    }
}
