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
    /// Specifies the type of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification118Choice.LEI))]
    [KnownType(typeof(PartyIdentification118Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification118Choice.LEI),nameof(PartyIdentification118Choice.LEI))]
    [JsonDerivedType(typeof(PartyIdentification118Choice.Proprietary),nameof(PartyIdentification118Choice.Proprietary))]
    #endif
    [IsoId("_OtNpsasXEeayv9XxdmMwKQ")]
    [DisplayName("Party Identification 118 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification118Choice_
    #else
    public abstract partial class PartyIdentification118Choice_
    #endif
    {
    }
}
