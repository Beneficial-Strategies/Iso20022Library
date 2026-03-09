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
    /// Choice of closing balance.
    /// </summary>
    [KnownType(typeof(ClosingBalance1Choice.Final))]
    [KnownType(typeof(ClosingBalance1Choice.Intermediary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClosingBalance1Choice.Final),nameof(ClosingBalance1Choice.Final))]
    [JsonDerivedType(typeof(ClosingBalance1Choice.Intermediary),nameof(ClosingBalance1Choice.Intermediary))]
    #endif
    [IsoId("_R9NRn9p-Ed-ak6NoX_4Aeg_-1862201522")]
    [DisplayName("Closing Balance 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClosingBalance1Choice_
    #else
    public abstract partial class ClosingBalance1Choice_
    #endif
    {
    }
}
