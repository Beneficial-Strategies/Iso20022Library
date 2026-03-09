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
    /// Reason for the status of the transaction.
    /// </summary>
    [KnownType(typeof(StatusReason5Choice.Code))]
    [KnownType(typeof(StatusReason5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StatusReason5Choice.Code),nameof(StatusReason5Choice.Code))]
    [JsonDerivedType(typeof(StatusReason5Choice.Proprietary),nameof(StatusReason5Choice.Proprietary))]
    #endif
    [IsoId("_V5oD19p-Ed-ak6NoX_4Aeg_1860744769")]
    [DisplayName("Status Reason 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatusReason5Choice_
    #else
    public abstract partial class StatusReason5Choice_
    #endif
    {
    }
}
