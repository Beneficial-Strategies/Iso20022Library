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
    /// Choice between a acquirer globalised card transaction or an individual card transaction.
    /// </summary>
    [KnownType(typeof(CardTransaction2Choice.Aggregated))]
    [KnownType(typeof(CardTransaction2Choice.Individual))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CardTransaction2Choice.Aggregated),nameof(CardTransaction2Choice.Aggregated))]
    [JsonDerivedType(typeof(CardTransaction2Choice.Individual),nameof(CardTransaction2Choice.Individual))]
    #endif
    [IsoId("_0UR2gTj3EeSz-s1QOUJaOg")]
    [DisplayName("Card Transaction 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardTransaction2Choice_
    #else
    public abstract partial class CardTransaction2Choice_
    #endif
    {
    }
}
