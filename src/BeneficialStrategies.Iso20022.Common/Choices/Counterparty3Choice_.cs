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
    [KnownType(typeof(Counterparty3Choice.Seller))]
    [KnownType(typeof(Counterparty3Choice.Buyer))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Counterparty3Choice.Seller),nameof(Counterparty3Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty3Choice.Buyer),nameof(Counterparty3Choice.Buyer))]
    #endif
    [IsoId("_K14CX-aOEd-q8fx_Zl_34A")]
    [DisplayName("Counterparty 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Counterparty3Choice_
    #else
    public abstract partial class Counterparty3Choice_
    #endif
    {
    }
}
