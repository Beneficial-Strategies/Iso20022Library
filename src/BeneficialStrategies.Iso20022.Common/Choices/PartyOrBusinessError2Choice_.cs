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
    /// Report between the party reference data or a business error.
    /// </summary>
    [KnownType(typeof(PartyOrBusinessError2Choice.BusinessError))]
    [KnownType(typeof(PartyOrBusinessError2Choice.SystemParty))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyOrBusinessError2Choice.BusinessError),nameof(PartyOrBusinessError2Choice.BusinessError))]
    [JsonDerivedType(typeof(PartyOrBusinessError2Choice.SystemParty),nameof(PartyOrBusinessError2Choice.SystemParty))]
    #endif
    [IsoId("_ewUgRfAzEeWPfa2xBhBfLQ")]
    [DisplayName("Party Or Business Error 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyOrBusinessError2Choice_
    #else
    public abstract partial class PartyOrBusinessError2Choice_
    #endif
    {
    }
}
