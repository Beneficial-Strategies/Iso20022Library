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
    /// Choice between a netting group identification or an individual trading party.
    /// </summary>
    [KnownType(typeof(NettingIdentification2Choice.TradeParty))]
    [KnownType(typeof(NettingIdentification2Choice.NettingGroupIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NettingIdentification2Choice.TradeParty),nameof(NettingIdentification2Choice.TradeParty))]
    [JsonDerivedType(typeof(NettingIdentification2Choice.NettingGroupIdentification),nameof(NettingIdentification2Choice.NettingGroupIdentification))]
    #endif
    [IsoId("_CEeXwQN1Ee2-vqzwMUAewg")]
    [DisplayName("Netting Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NettingIdentification2Choice_
    #else
    public abstract partial class NettingIdentification2Choice_
    #endif
    {
    }
}
