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
    [KnownType(typeof(UnderlyingContract2Choice.Loan))]
    [KnownType(typeof(UnderlyingContract2Choice.Trade))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnderlyingContract2Choice.Loan),nameof(UnderlyingContract2Choice.Loan))]
    [JsonDerivedType(typeof(UnderlyingContract2Choice.Trade),nameof(UnderlyingContract2Choice.Trade))]
    #endif
    [IsoId("_JXX9CW49EeiU9cctagi5ow")]
    [DisplayName("Underlying Contract 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnderlyingContract2Choice_
    #else
    public abstract partial class UnderlyingContract2Choice_
    #endif
    {
    }
}
