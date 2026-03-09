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
    [KnownType(typeof(Counterparty5Choice.Seller))]
    [KnownType(typeof(Counterparty5Choice.Buyer))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Counterparty5Choice.Seller),nameof(Counterparty5Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty5Choice.Buyer),nameof(Counterparty5Choice.Buyer))]
    #endif
    [IsoId("_idvrweaOEd-q8fx_Zl_34A")]
    [DisplayName("Counterparty 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Counterparty5Choice_
    #else
    public abstract partial class Counterparty5Choice_
    #endif
    {
    }
}
