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
    /// Choice of formats to express the reason of a rejection of the notification cancellation request.
    /// </summary>
    [KnownType(typeof(RejectionReason11FormatChoice.Code))]
    [KnownType(typeof(RejectionReason11FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionReason11FormatChoice.Code),nameof(RejectionReason11FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason11FormatChoice.Proprietary),nameof(RejectionReason11FormatChoice.Proprietary))]
    #endif
    [IsoId("_RoC55Np-Ed-ak6NoX_4Aeg_-672049189")]
    [DisplayName("Rejection Reason 11 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason11FormatChoice_
    #else
    public abstract partial class RejectionReason11FormatChoice_
    #endif
    {
    }
}
