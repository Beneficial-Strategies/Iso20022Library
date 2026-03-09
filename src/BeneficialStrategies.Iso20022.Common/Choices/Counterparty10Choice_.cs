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
    [KnownType(typeof(Counterparty10Choice.Seller))]
    [KnownType(typeof(Counterparty10Choice.Buyer))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Counterparty10Choice.Seller),nameof(Counterparty10Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty10Choice.Buyer),nameof(Counterparty10Choice.Buyer))]
    #endif
    [IsoId("_5myFAJNLEeWGlc8L7oPDIg")]
    [DisplayName("Counterparty 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Counterparty10Choice_
    #else
    public abstract partial class Counterparty10Choice_
    #endif
    {
    }
}
