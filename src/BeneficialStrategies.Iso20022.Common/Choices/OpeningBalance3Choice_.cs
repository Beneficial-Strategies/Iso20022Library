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
    /// Choice of opening and intermediary balances.
    /// </summary>
    [KnownType(typeof(OpeningBalance3Choice.FirstOpeningBalance))]
    [KnownType(typeof(OpeningBalance3Choice.IntermediaryOpeningBalance))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OpeningBalance3Choice.FirstOpeningBalance),nameof(OpeningBalance3Choice.FirstOpeningBalance))]
    [JsonDerivedType(typeof(OpeningBalance3Choice.IntermediaryOpeningBalance),nameof(OpeningBalance3Choice.IntermediaryOpeningBalance))]
    #endif
    [IsoId("_Lu4l8QgHEeSxsfb1OEDVsw")]
    [DisplayName("Opening Balance 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OpeningBalance3Choice_
    #else
    public abstract partial class OpeningBalance3Choice_
    #endif
    {
    }
}
