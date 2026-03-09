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
    /// Choice of format for the opening closing information.
    /// </summary>
    [KnownType(typeof(OpeningClosing1Choice.Code))]
    [KnownType(typeof(OpeningClosing1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OpeningClosing1Choice.Code),nameof(OpeningClosing1Choice.Code))]
    [JsonDerivedType(typeof(OpeningClosing1Choice.Proprietary),nameof(OpeningClosing1Choice.Proprietary))]
    #endif
    [IsoId("_Qs45Ndp-Ed-ak6NoX_4Aeg_-775464350")]
    [DisplayName("Opening Closing 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OpeningClosing1Choice_
    #else
    public abstract partial class OpeningClosing1Choice_
    #endif
    {
    }
}
