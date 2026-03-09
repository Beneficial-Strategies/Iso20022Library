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
    [KnownType(typeof(SettlementDateCode2Choice.Code))]
    [KnownType(typeof(SettlementDateCode2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDateCode2Choice.Code),nameof(SettlementDateCode2Choice.Code))]
    [JsonDerivedType(typeof(SettlementDateCode2Choice.Proprietary),nameof(SettlementDateCode2Choice.Proprietary))]
    #endif
    [IsoId("_QurB5Np-Ed-ak6NoX_4Aeg_-1955127258")]
    [DisplayName("Settlement Date Code 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDateCode2Choice_
    #else
    public abstract partial class SettlementDateCode2Choice_
    #endif
    {
    }
}
