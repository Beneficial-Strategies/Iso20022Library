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
    [KnownType(typeof(Counterparty12Choice.Seller))]
    [KnownType(typeof(Counterparty12Choice.Buyer))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Counterparty12Choice.Seller),nameof(Counterparty12Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty12Choice.Buyer),nameof(Counterparty12Choice.Buyer))]
    #endif
    [IsoId("_5ToeNc3yEee5nJBZsW8MFQ")]
    [DisplayName("Counterparty 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Counterparty12Choice_
    #else
    public abstract partial class Counterparty12Choice_
    #endif
    {
    }
}
