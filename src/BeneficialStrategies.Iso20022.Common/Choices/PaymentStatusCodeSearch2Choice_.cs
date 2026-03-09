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
    /// Choice between a list of pending statuses, final statuses or all statuses.
    /// </summary>
    [KnownType(typeof(PaymentStatusCodeSearch2Choice.PendingStatus))]
    [KnownType(typeof(PaymentStatusCodeSearch2Choice.FinalStatus))]
    [KnownType(typeof(PaymentStatusCodeSearch2Choice.PendingAndFinalStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentStatusCodeSearch2Choice.PendingStatus),nameof(PaymentStatusCodeSearch2Choice.PendingStatus))]
    [JsonDerivedType(typeof(PaymentStatusCodeSearch2Choice.FinalStatus),nameof(PaymentStatusCodeSearch2Choice.FinalStatus))]
    [JsonDerivedType(typeof(PaymentStatusCodeSearch2Choice.PendingAndFinalStatus),nameof(PaymentStatusCodeSearch2Choice.PendingAndFinalStatus))]
    #endif
    [IsoId("_RGEOMNp-Ed-ak6NoX_4Aeg_396814061")]
    [DisplayName("Payment Status Code Search 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentStatusCodeSearch2Choice_
    #else
    public abstract partial class PaymentStatusCodeSearch2Choice_
    #endif
    {
    }
}
