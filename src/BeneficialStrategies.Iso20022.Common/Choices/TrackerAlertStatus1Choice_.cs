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
    /// Specifies the status of the tracker alert.
    /// </summary>
    [KnownType(typeof(TrackerAlertStatus1Choice.Code))]
    [KnownType(typeof(TrackerAlertStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TrackerAlertStatus1Choice.Code),nameof(TrackerAlertStatus1Choice.Code))]
    [JsonDerivedType(typeof(TrackerAlertStatus1Choice.Proprietary),nameof(TrackerAlertStatus1Choice.Proprietary))]
    #endif
    [IsoId("_M7UA5PWlEemtd4wHZYvFUQ")]
    [DisplayName("Tracker Alert Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TrackerAlertStatus1Choice_
    #else
    public abstract partial class TrackerAlertStatus1Choice_
    #endif
    {
    }
}
