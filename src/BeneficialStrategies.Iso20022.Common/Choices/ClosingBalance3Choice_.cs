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
    /// Choice of final and intermediary balances.
    /// </summary>
    [KnownType(typeof(ClosingBalance3Choice.FinalClosingBalance))]
    [KnownType(typeof(ClosingBalance3Choice.IntermediaryClosingBalance))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClosingBalance3Choice.FinalClosingBalance),nameof(ClosingBalance3Choice.FinalClosingBalance))]
    [JsonDerivedType(typeof(ClosingBalance3Choice.IntermediaryClosingBalance),nameof(ClosingBalance3Choice.IntermediaryClosingBalance))]
    #endif
    [IsoId("_t8VGsAgHEeSxsfb1OEDVsw")]
    [DisplayName("Closing Balance 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClosingBalance3Choice_
    #else
    public abstract partial class ClosingBalance3Choice_
    #endif
    {
    }
}
