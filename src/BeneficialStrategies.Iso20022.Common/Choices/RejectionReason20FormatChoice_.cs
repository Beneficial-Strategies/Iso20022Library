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
    /// Choice of formats to express the reason of a rejection of the standing instruction request.
    /// </summary>
    [KnownType(typeof(RejectionReason20FormatChoice.Code))]
    [KnownType(typeof(RejectionReason20FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionReason20FormatChoice.Code),nameof(RejectionReason20FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason20FormatChoice.Proprietary),nameof(RejectionReason20FormatChoice.Proprietary))]
    #endif
    [IsoId("_Rofl0tp-Ed-ak6NoX_4Aeg_362684216")]
    [DisplayName("Rejection Reason 20 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason20FormatChoice_
    #else
    public abstract partial class RejectionReason20FormatChoice_
    #endif
    {
    }
}
