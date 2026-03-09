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
    /// Provides a reason for rejection identified using a code or a data source scheme.
    /// </summary>
    [KnownType(typeof(RejectionReason3Choice.Code))]
    [KnownType(typeof(RejectionReason3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionReason3Choice.Code),nameof(RejectionReason3Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason3Choice.Proprietary),nameof(RejectionReason3Choice.Proprietary))]
    #endif
    [IsoId("_Q9lAk9p-Ed-ak6NoX_4Aeg_433100645")]
    [DisplayName("Rejection Reason 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason3Choice_
    #else
    public abstract partial class RejectionReason3Choice_
    #endif
    {
    }
}
