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
    [KnownType(typeof(PartyIdentification35Choice.BIC))]
    [KnownType(typeof(PartyIdentification35Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification35Choice.BIC),nameof(PartyIdentification35Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification35Choice.ProprietaryIdentification),nameof(PartyIdentification35Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_QPYd4dp-Ed-ak6NoX_4Aeg_-1523931735")]
    [DisplayName("Party Identification 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification35Choice_
    #else
    public abstract partial class PartyIdentification35Choice_
    #endif
    {
    }
}
