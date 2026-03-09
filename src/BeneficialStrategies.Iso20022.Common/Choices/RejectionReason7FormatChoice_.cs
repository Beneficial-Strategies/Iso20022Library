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
    /// Choice of formats to express the reason of a rejection cancellation request.
    /// </summary>
    [KnownType(typeof(RejectionReason7FormatChoice.Code))]
    [KnownType(typeof(RejectionReason7FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionReason7FormatChoice.Code),nameof(RejectionReason7FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason7FormatChoice.Proprietary),nameof(RejectionReason7FormatChoice.Proprietary))]
    #endif
    [IsoId("_Rofl2Np-Ed-ak6NoX_4Aeg_-1503733328")]
    [DisplayName("Rejection Reason 7 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason7FormatChoice_
    #else
    public abstract partial class RejectionReason7FormatChoice_
    #endif
    {
    }
}
