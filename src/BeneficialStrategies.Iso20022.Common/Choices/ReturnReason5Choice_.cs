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
    /// Specifies the reason for the return of the transaction.
    /// </summary>
    [KnownType(typeof(ReturnReason5Choice.Code))]
    [KnownType(typeof(ReturnReason5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReturnReason5Choice.Code),nameof(ReturnReason5Choice.Code))]
    [JsonDerivedType(typeof(ReturnReason5Choice.Proprietary),nameof(ReturnReason5Choice.Proprietary))]
    #endif
    [IsoId("_TP6Pkdp-Ed-ak6NoX_4Aeg_-1676326037")]
    [DisplayName("Return Reason 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReturnReason5Choice_
    #else
    public abstract partial class ReturnReason5Choice_
    #endif
    {
    }
}
