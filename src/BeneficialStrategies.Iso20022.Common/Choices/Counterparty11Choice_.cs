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
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty11Choice.Seller))]
    [KnownType(typeof(Counterparty11Choice.Buyer))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Counterparty11Choice.Seller),nameof(Counterparty11Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty11Choice.Buyer),nameof(Counterparty11Choice.Buyer))]
    #endif
    [IsoId("_N0Z5Ua5YEeey8N0JWnVPUw")]
    [DisplayName("Counterparty 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Counterparty11Choice_
    #else
    public abstract partial class Counterparty11Choice_
    #endif
    {
    }
}
