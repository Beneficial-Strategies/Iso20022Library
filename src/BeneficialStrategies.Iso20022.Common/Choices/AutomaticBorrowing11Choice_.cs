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
    [KnownType(typeof(AutomaticBorrowing11Choice.Code))]
    [KnownType(typeof(AutomaticBorrowing11Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AutomaticBorrowing11Choice.Code),nameof(AutomaticBorrowing11Choice.Code))]
    [JsonDerivedType(typeof(AutomaticBorrowing11Choice.Proprietary),nameof(AutomaticBorrowing11Choice.Proprietary))]
    #endif
    [IsoId("_6GVvS5NLEeWGlc8L7oPDIg")]
    [DisplayName("Automatic Borrowing 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AutomaticBorrowing11Choice_
    #else
    public abstract partial class AutomaticBorrowing11Choice_
    #endif
    {
    }
}
