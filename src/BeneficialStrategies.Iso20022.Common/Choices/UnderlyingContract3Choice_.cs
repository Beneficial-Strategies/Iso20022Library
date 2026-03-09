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
    /// Choice of the type of underlying contract.
    /// </summary>
    [KnownType(typeof(UnderlyingContract3Choice.Loan))]
    [KnownType(typeof(UnderlyingContract3Choice.Trade))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnderlyingContract3Choice.Loan),nameof(UnderlyingContract3Choice.Loan))]
    [JsonDerivedType(typeof(UnderlyingContract3Choice.Trade),nameof(UnderlyingContract3Choice.Trade))]
    #endif
    [IsoId("_0NEsUbGIEeuSTr8k0UEM8A")]
    [DisplayName("Underlying Contract 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnderlyingContract3Choice_
    #else
    public abstract partial class UnderlyingContract3Choice_
    #endif
    {
    }
}
