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
    /// Specifies the source used to generate the reporting.
    /// </summary>
    [KnownType(typeof(ReportingSource1Choice.Code))]
    [KnownType(typeof(ReportingSource1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReportingSource1Choice.Code),nameof(ReportingSource1Choice.Code))]
    [JsonDerivedType(typeof(ReportingSource1Choice.Proprietary),nameof(ReportingSource1Choice.Proprietary))]
    #endif
    [IsoId("_RqIkkdp-Ed-ak6NoX_4Aeg_-1706426921")]
    [DisplayName("Reporting Source 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReportingSource1Choice_
    #else
    public abstract partial class ReportingSource1Choice_
    #endif
    {
    }
}
