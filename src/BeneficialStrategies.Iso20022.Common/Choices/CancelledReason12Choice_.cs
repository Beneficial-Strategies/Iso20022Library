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
    /// Choice between formats for a cancelled reason.
    /// </summary>
    [KnownType(typeof(CancelledReason12Choice.Code))]
    [KnownType(typeof(CancelledReason12Choice.Proprietary))]
    [KnownType(typeof(CancelledReason12Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancelledReason12Choice.Code),nameof(CancelledReason12Choice.Code))]
    [JsonDerivedType(typeof(CancelledReason12Choice.Proprietary),nameof(CancelledReason12Choice.Proprietary))]
    [JsonDerivedType(typeof(CancelledReason12Choice.NoSpecifiedReason),nameof(CancelledReason12Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_eoqj8UHTEeasdbKMiqizqA")]
    [DisplayName("Cancelled Reason 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancelledReason12Choice_
    #else
    public abstract partial class CancelledReason12Choice_
    #endif
    {
    }
}
