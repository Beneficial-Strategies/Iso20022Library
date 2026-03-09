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
    /// Choice of formats to express the reason of a rejection of an election amendment request.
    /// </summary>
    [KnownType(typeof(RejectionReason8FormatChoice.Code))]
    [KnownType(typeof(RejectionReason8FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionReason8FormatChoice.Code),nameof(RejectionReason8FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason8FormatChoice.Proprietary),nameof(RejectionReason8FormatChoice.Proprietary))]
    #endif
    [IsoId("_Roovwtp-Ed-ak6NoX_4Aeg_520363786")]
    [DisplayName("Rejection Reason 8 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason8FormatChoice_
    #else
    public abstract partial class RejectionReason8FormatChoice_
    #endif
    {
    }
}
