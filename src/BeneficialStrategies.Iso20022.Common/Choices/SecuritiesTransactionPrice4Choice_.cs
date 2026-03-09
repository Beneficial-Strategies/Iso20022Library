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
    [KnownType(typeof(SecuritiesTransactionPrice4Choice.Price))]
    [KnownType(typeof(SecuritiesTransactionPrice4Choice.NoPrice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionPrice4Choice.Price),nameof(SecuritiesTransactionPrice4Choice.Price))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice4Choice.NoPrice),nameof(SecuritiesTransactionPrice4Choice.NoPrice))]
    #endif
    [IsoId("_8Rc9cOI-EeWWKb0jFHxViQ")]
    [DisplayName("Securities Transaction Price 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionPrice4Choice_
    #else
    public abstract partial class SecuritiesTransactionPrice4Choice_
    #endif
    {
    }
}
