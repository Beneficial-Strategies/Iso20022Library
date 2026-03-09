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
    /// Provides acceptance status of the holding item.
    /// </summary>
    [KnownType(typeof(ReportItemStatus1Choice.Accepted))]
    [KnownType(typeof(ReportItemStatus1Choice.AcceptedWithException))]
    [KnownType(typeof(ReportItemStatus1Choice.Rejected))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReportItemStatus1Choice.Accepted),nameof(ReportItemStatus1Choice.Accepted))]
    [JsonDerivedType(typeof(ReportItemStatus1Choice.AcceptedWithException),nameof(ReportItemStatus1Choice.AcceptedWithException))]
    [JsonDerivedType(typeof(ReportItemStatus1Choice.Rejected),nameof(ReportItemStatus1Choice.Rejected))]
    #endif
    [IsoId("_0w3vwb3QEeO2FLWuu_JIqg")]
    [DisplayName("Report Item Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReportItemStatus1Choice_
    #else
    public abstract partial class ReportItemStatus1Choice_
    #endif
    {
    }
}
