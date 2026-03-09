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
    [KnownType(typeof(AutomaticBorrowing5Choice.Code))]
    [KnownType(typeof(AutomaticBorrowing5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AutomaticBorrowing5Choice.Code),nameof(AutomaticBorrowing5Choice.Code))]
    [JsonDerivedType(typeof(AutomaticBorrowing5Choice.Proprietary),nameof(AutomaticBorrowing5Choice.Proprietary))]
    #endif
    [IsoId("_AY9vFNokEeC60axPepSq7g_1505904556")]
    [DisplayName("Automatic Borrowing 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AutomaticBorrowing5Choice_
    #else
    public abstract partial class AutomaticBorrowing5Choice_
    #endif
    {
    }
}
