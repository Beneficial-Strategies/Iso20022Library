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
    /// Choice of the report content format.
    /// </summary>
    [KnownType(typeof(ReportContent1Choice.Text))]
    [KnownType(typeof(ReportContent1Choice.Binary))]
    [KnownType(typeof(ReportContent1Choice.ProtectedData))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReportContent1Choice.Text),nameof(ReportContent1Choice.Text))]
    [JsonDerivedType(typeof(ReportContent1Choice.Binary),nameof(ReportContent1Choice.Binary))]
    [JsonDerivedType(typeof(ReportContent1Choice.ProtectedData),nameof(ReportContent1Choice.ProtectedData))]
    #endif
    [IsoId("_HsTagMlWEeuJ35KoBRZFOg")]
    [DisplayName("Report Content 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReportContent1Choice_
    #else
    public abstract partial class ReportContent1Choice_
    #endif
    {
    }
}
