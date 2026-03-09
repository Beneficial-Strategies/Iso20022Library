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
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification12Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification12Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification12Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification12Choice.BICOrBEI),nameof(PartyIdentification12Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification12Choice.NameAndAddress),nameof(PartyIdentification12Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification12Choice.Country),nameof(PartyIdentification12Choice.Country))]
    #endif
    [IsoId("_QQ3rltp-Ed-ak6NoX_4Aeg_1313053779")]
    [DisplayName("Party Identification 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification12Choice_
    #else
    public abstract partial class PartyIdentification12Choice_
    #endif
    {
    }
}
