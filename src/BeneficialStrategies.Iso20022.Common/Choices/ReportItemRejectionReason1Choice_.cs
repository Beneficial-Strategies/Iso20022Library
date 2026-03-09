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
    /// Provides the report item rejection reason in a coded or proprietary form.
    /// </summary>
    [KnownType(typeof(ReportItemRejectionReason1Choice.Code))]
    [KnownType(typeof(ReportItemRejectionReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReportItemRejectionReason1Choice.Code),nameof(ReportItemRejectionReason1Choice.Code))]
    [JsonDerivedType(typeof(ReportItemRejectionReason1Choice.Proprietary),nameof(ReportItemRejectionReason1Choice.Proprietary))]
    #endif
    [IsoId("_havMI73REeO2FLWuu_JIqg")]
    [DisplayName("Report Item Rejection Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReportItemRejectionReason1Choice_
    #else
    public abstract partial class ReportItemRejectionReason1Choice_
    #endif
    {
    }
}
