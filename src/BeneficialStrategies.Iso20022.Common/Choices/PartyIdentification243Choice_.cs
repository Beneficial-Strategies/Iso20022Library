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
    [KnownType(typeof(PartyIdentification243Choice.BIC))]
    [KnownType(typeof(PartyIdentification243Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification243Choice.BIC),nameof(PartyIdentification243Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification243Choice.ProprietaryIdentification),nameof(PartyIdentification243Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_vOLN0QauEe2phaVG0lYKTw")]
    [DisplayName("Party Identification 243 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification243Choice_
    #else
    public abstract partial class PartyIdentification243Choice_
    #endif
    {
    }
}
