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
    /// Choice of format for the automatic borrowing information.
    /// </summary>
    [KnownType(typeof(AutomaticBorrowing8Choice.Code))]
    [KnownType(typeof(AutomaticBorrowing8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AutomaticBorrowing8Choice.Code),nameof(AutomaticBorrowing8Choice.Code))]
    [JsonDerivedType(typeof(AutomaticBorrowing8Choice.Proprietary),nameof(AutomaticBorrowing8Choice.Proprietary))]
    #endif
    [IsoId("_5m6oVZNLEeWGlc8L7oPDIg")]
    [DisplayName("Automatic Borrowing 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AutomaticBorrowing8Choice_
    #else
    public abstract partial class AutomaticBorrowing8Choice_
    #endif
    {
    }
}
