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
    /// Specifies the details of the underlying transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction2Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction2Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction2Choice.StatementEntry))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnderlyingTransaction2Choice.Initiation),nameof(UnderlyingTransaction2Choice.Initiation))]
    [JsonDerivedType(typeof(UnderlyingTransaction2Choice.Interbank),nameof(UnderlyingTransaction2Choice.Interbank))]
    [JsonDerivedType(typeof(UnderlyingTransaction2Choice.StatementEntry),nameof(UnderlyingTransaction2Choice.StatementEntry))]
    #endif
    [IsoId("_P3N9Vp9XEeGBX4a4yy-WHg_2030305441")]
    [DisplayName("Underlying Transaction 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnderlyingTransaction2Choice_
    #else
    public abstract partial class UnderlyingTransaction2Choice_
    #endif
    {
    }
}
