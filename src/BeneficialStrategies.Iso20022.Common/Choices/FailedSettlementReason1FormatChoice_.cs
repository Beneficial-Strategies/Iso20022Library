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
    /// Choice between a standard code or a proprietary code for specifying the reason of a settlement failure.
    /// </summary>
    [KnownType(typeof(FailedSettlementReason1FormatChoice.Code))]
    [KnownType(typeof(FailedSettlementReason1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FailedSettlementReason1FormatChoice.Code),nameof(FailedSettlementReason1FormatChoice.Code))]
    [JsonDerivedType(typeof(FailedSettlementReason1FormatChoice.Proprietary),nameof(FailedSettlementReason1FormatChoice.Proprietary))]
    #endif
    [IsoId("_RmjsItp-Ed-ak6NoX_4Aeg_220367712")]
    [DisplayName("Failed Settlement Reason 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FailedSettlementReason1FormatChoice_
    #else
    public abstract partial class FailedSettlementReason1FormatChoice_
    #endif
    {
    }
}
