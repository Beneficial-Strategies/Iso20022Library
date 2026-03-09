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
    /// Specifies a choice between one party or a group of parties.
    /// </summary>
    [KnownType(typeof(PartyOrGroup2Choice.GroupIdentification))]
    [KnownType(typeof(PartyOrGroup2Choice.Party))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyOrGroup2Choice.GroupIdentification),nameof(PartyOrGroup2Choice.GroupIdentification))]
    [JsonDerivedType(typeof(PartyOrGroup2Choice.Party),nameof(PartyOrGroup2Choice.Party))]
    #endif
    [IsoId("_C3Ccd249EeiU9cctagi5ow")]
    [DisplayName("Party Or Group 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyOrGroup2Choice_
    #else
    public abstract partial class PartyOrGroup2Choice_
    #endif
    {
    }
}
