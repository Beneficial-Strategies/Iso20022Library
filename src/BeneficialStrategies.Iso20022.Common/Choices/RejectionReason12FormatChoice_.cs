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
    /// Choice of formats to express the reason of a rejection of a deactivation instruction.
    /// </summary>
    [KnownType(typeof(RejectionReason12FormatChoice.Code))]
    [KnownType(typeof(RejectionReason12FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionReason12FormatChoice.Code),nameof(RejectionReason12FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason12FormatChoice.Proprietary),nameof(RejectionReason12FormatChoice.Proprietary))]
    #endif
    [IsoId("_RoC559p-Ed-ak6NoX_4Aeg_-1828809794")]
    [DisplayName("Rejection Reason 12 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason12FormatChoice_
    #else
    public abstract partial class RejectionReason12FormatChoice_
    #endif
    {
    }
}
