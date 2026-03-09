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
    /// Choice element capturing strike price related descriptive information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice22Choice.Price))]
    [KnownType(typeof(SecuritiesTransactionPrice22Choice.DigitalTokenPrice))]
    [KnownType(typeof(SecuritiesTransactionPrice22Choice.NoPrice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionPrice22Choice.Price),nameof(SecuritiesTransactionPrice22Choice.Price))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice22Choice.DigitalTokenPrice),nameof(SecuritiesTransactionPrice22Choice.DigitalTokenPrice))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice22Choice.NoPrice),nameof(SecuritiesTransactionPrice22Choice.NoPrice))]
    #endif
    [IsoId("_i5c_MZiuEe2f7NHvXATP5g")]
    [DisplayName("Securities Transaction Price 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionPrice22Choice_
    #else
    public abstract partial class SecuritiesTransactionPrice22Choice_
    #endif
    {
    }
}
