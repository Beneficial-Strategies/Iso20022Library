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
    [KnownType(typeof(PartyIdentification8Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification8Choice.BICOrBEI))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification8Choice.NameAndAddress),nameof(PartyIdentification8Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification8Choice.BICOrBEI),nameof(PartyIdentification8Choice.BICOrBEI))]
    #endif
    [IsoId("_Q7fV6dp-Ed-ak6NoX_4Aeg_1364552938")]
    [DisplayName("Party Identification 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification8Choice_
    #else
    public abstract partial class PartyIdentification8Choice_
    #endif
    {
    }
}
