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
    /// Choice between the selections of individual saving accounts issued during the current fiscal year.
    /// </summary>
    [KnownType(typeof(CurrentYearType2Choice.CurrentYearType))]
    [KnownType(typeof(CurrentYearType2Choice.ExtendedCurrentYearType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CurrentYearType2Choice.CurrentYearType),nameof(CurrentYearType2Choice.CurrentYearType))]
    [JsonDerivedType(typeof(CurrentYearType2Choice.ExtendedCurrentYearType),nameof(CurrentYearType2Choice.ExtendedCurrentYearType))]
    #endif
    [IsoId("_3f6cY0XfEeGY6MkiuzuPOA_-540956173")]
    [DisplayName("Current Year Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CurrentYearType2Choice_
    #else
    public abstract partial class CurrentYearType2Choice_
    #endif
    {
    }
}
