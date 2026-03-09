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
    /// Choice of formats to express the reason of a rejection of an election cancellation request.
    /// </summary>
    [KnownType(typeof(RejectionReason9FormatChoice.Code))]
    [KnownType(typeof(RejectionReason9FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionReason9FormatChoice.Code),nameof(RejectionReason9FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason9FormatChoice.Proprietary),nameof(RejectionReason9FormatChoice.Proprietary))]
    #endif
    [IsoId("_Roovxdp-Ed-ak6NoX_4Aeg_-1408419853")]
    [DisplayName("Rejection Reason 9 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason9FormatChoice_
    #else
    public abstract partial class RejectionReason9FormatChoice_
    #endif
    {
    }
}
