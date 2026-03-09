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
    [KnownType(typeof(AutomaticBorrowing6Choice.Code))]
    [KnownType(typeof(AutomaticBorrowing6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AutomaticBorrowing6Choice.Code),nameof(AutomaticBorrowing6Choice.Code))]
    [JsonDerivedType(typeof(AutomaticBorrowing6Choice.Proprietary),nameof(AutomaticBorrowing6Choice.Proprietary))]
    #endif
    [IsoId("_lL50gTtFEeWRTLSN0i0tng")]
    [DisplayName("Automatic Borrowing 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AutomaticBorrowing6Choice_
    #else
    public abstract partial class AutomaticBorrowing6Choice_
    #endif
    {
    }
}
