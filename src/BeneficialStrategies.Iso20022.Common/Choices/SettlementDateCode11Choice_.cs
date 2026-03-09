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
    /// Choice of format for the settlement date code.
    /// </summary>
    [KnownType(typeof(SettlementDateCode11Choice.Code))]
    [KnownType(typeof(SettlementDateCode11Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDateCode11Choice.Code),nameof(SettlementDateCode11Choice.Code))]
    [JsonDerivedType(typeof(SettlementDateCode11Choice.Proprietary),nameof(SettlementDateCode11Choice.Proprietary))]
    #endif
    [IsoId("_6BMwg5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Date Code 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDateCode11Choice_
    #else
    public abstract partial class SettlementDateCode11Choice_
    #endif
    {
    }
}
