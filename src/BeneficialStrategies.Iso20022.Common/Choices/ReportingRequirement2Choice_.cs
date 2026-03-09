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
    /// Indicator whether there is a reporting requirement for both counterparties.
    /// </summary>
    [KnownType(typeof(ReportingRequirement2Choice.ReportingRequirement))]
    [KnownType(typeof(ReportingRequirement2Choice.NoReportingRequirement))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReportingRequirement2Choice.ReportingRequirement),nameof(ReportingRequirement2Choice.ReportingRequirement))]
    [JsonDerivedType(typeof(ReportingRequirement2Choice.NoReportingRequirement),nameof(ReportingRequirement2Choice.NoReportingRequirement))]
    #endif
    [IsoId("_IUKZoV55Ee2a_-MvhEjKmA")]
    [DisplayName("Reporting Requirement 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReportingRequirement2Choice_
    #else
    public abstract partial class ReportingRequirement2Choice_
    #endif
    {
    }
}
