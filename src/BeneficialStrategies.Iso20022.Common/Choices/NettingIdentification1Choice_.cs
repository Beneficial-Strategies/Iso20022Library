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
    /// Choice between netting group identification of an individual trading party.
    /// </summary>
    [KnownType(typeof(NettingIdentification1Choice.TradeParty))]
    [KnownType(typeof(NettingIdentification1Choice.NettingGroupIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NettingIdentification1Choice.TradeParty),nameof(NettingIdentification1Choice.TradeParty))]
    [JsonDerivedType(typeof(NettingIdentification1Choice.NettingGroupIdentification),nameof(NettingIdentification1Choice.NettingGroupIdentification))]
    #endif
    [IsoId("_mzHC8JUvEeaYkf5FCqYMeA")]
    [DisplayName("Netting Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NettingIdentification1Choice_
    #else
    public abstract partial class NettingIdentification1Choice_
    #endif
    {
    }
}
