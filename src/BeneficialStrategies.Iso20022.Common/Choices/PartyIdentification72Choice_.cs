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
    /// Choice of identification of a party. The party can be identified by giving a BIC or a proprietary code.
    /// </summary>
    [KnownType(typeof(PartyIdentification72Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification72Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification72Choice.AnyBIC),nameof(PartyIdentification72Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification72Choice.ProprietaryIdentification),nameof(PartyIdentification72Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_3JsB7nHeEeG8t-w1mFnmhg_-1626691800")]
    [DisplayName("Party Identification 72 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification72Choice_
    #else
    public abstract partial class PartyIdentification72Choice_
    #endif
    {
    }
}
