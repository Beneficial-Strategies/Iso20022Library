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
    /// Choice of start date and end date for the fiscal year.
    /// </summary>
    [KnownType(typeof(FiscalYear1Choice.StartDate))]
    [KnownType(typeof(FiscalYear1Choice.EndDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FiscalYear1Choice.StartDate),nameof(FiscalYear1Choice.StartDate))]
    [JsonDerivedType(typeof(FiscalYear1Choice.EndDate),nameof(FiscalYear1Choice.EndDate))]
    #endif
    [IsoId("_534EEFxREeW8MLuBzR10cg")]
    [DisplayName("Fiscal Year 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FiscalYear1Choice_
    #else
    public abstract partial class FiscalYear1Choice_
    #endif
    {
    }
}
