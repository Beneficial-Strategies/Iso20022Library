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
    /// Choice of status for the replacement processing.
    /// </summary>
    [KnownType(typeof(ReplacementProcessingStatus10Choice.Accepted))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.Completed))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.Denied))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.InRepair))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.PartialReplacementAccepted))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.Pending))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.ReceivedAtIntermediary))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.ReceivedAtStockExchange))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.Rejected))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.ModificationRequested))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReplacementProcessingStatus10Choice.Accepted),nameof(ReplacementProcessingStatus10Choice.Accepted))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus10Choice.Completed),nameof(ReplacementProcessingStatus10Choice.Completed))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus10Choice.Denied),nameof(ReplacementProcessingStatus10Choice.Denied))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus10Choice.InRepair),nameof(ReplacementProcessingStatus10Choice.InRepair))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus10Choice.PartialReplacementAccepted),nameof(ReplacementProcessingStatus10Choice.PartialReplacementAccepted))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus10Choice.Pending),nameof(ReplacementProcessingStatus10Choice.Pending))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus10Choice.ReceivedAtIntermediary),nameof(ReplacementProcessingStatus10Choice.ReceivedAtIntermediary))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus10Choice.ReceivedAtStockExchange),nameof(ReplacementProcessingStatus10Choice.ReceivedAtStockExchange))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus10Choice.Rejected),nameof(ReplacementProcessingStatus10Choice.Rejected))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus10Choice.ModificationRequested),nameof(ReplacementProcessingStatus10Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus10Choice.ProprietaryStatus),nameof(ReplacementProcessingStatus10Choice.ProprietaryStatus))]
    #endif
    [IsoId("_RPMBxQeDEe2fOITqoTnSLQ")]
    [DisplayName("Replacement Processing Status 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReplacementProcessingStatus10Choice_
    #else
    public abstract partial class ReplacementProcessingStatus10Choice_
    #endif
    {
    }
}
