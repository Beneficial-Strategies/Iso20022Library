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
    /// Choice of formats to express the reason of a rejection of a movement cancellation request.
    /// </summary>
    [KnownType(typeof(RejectionReason14FormatChoice.Code))]
    [KnownType(typeof(RejectionReason14FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionReason14FormatChoice.Code),nameof(RejectionReason14FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason14FormatChoice.Proprietary),nameof(RejectionReason14FormatChoice.Proprietary))]
    #endif
    [IsoId("_RoMq5dp-Ed-ak6NoX_4Aeg_-1393087527")]
    [DisplayName("Rejection Reason 14 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason14FormatChoice_
    #else
    public abstract partial class RejectionReason14FormatChoice_
    #endif
    {
    }
}
