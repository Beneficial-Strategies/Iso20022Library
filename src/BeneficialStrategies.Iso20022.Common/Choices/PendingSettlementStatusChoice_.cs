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
    /// Reason for the pending settlement status.
    /// </summary>
    [KnownType(typeof(PendingSettlementStatusChoice.Reason))]
    [KnownType(typeof(PendingSettlementStatusChoice.DataSourceScheme))]
    [KnownType(typeof(PendingSettlementStatusChoice.NoReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingSettlementStatusChoice.Reason),nameof(PendingSettlementStatusChoice.Reason))]
    [JsonDerivedType(typeof(PendingSettlementStatusChoice.DataSourceScheme),nameof(PendingSettlementStatusChoice.DataSourceScheme))]
    [JsonDerivedType(typeof(PendingSettlementStatusChoice.NoReason),nameof(PendingSettlementStatusChoice.NoReason))]
    #endif
    [IsoId("_U1POpdp-Ed-ak6NoX_4Aeg_-1501368338")]
    [DisplayName("Pending Settlement Status Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingSettlementStatusChoice_
    #else
    public abstract partial class PendingSettlementStatusChoice_
    #endif
    {
    }
}
