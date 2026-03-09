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
    /// Choice of format for the classification.
    /// </summary>
    [KnownType(typeof(ClassificationType4Choice.ClassificationFinancialInstrument))]
    [KnownType(typeof(ClassificationType4Choice.AlternateClassification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClassificationType4Choice.ClassificationFinancialInstrument),nameof(ClassificationType4Choice.ClassificationFinancialInstrument))]
    [JsonDerivedType(typeof(ClassificationType4Choice.AlternateClassification),nameof(ClassificationType4Choice.AlternateClassification))]
    #endif
    [IsoId("_XQgXMtp-Ed-ak6NoX_4Aeg_322519448")]
    [DisplayName("Classification Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClassificationType4Choice_
    #else
    public abstract partial class ClassificationType4Choice_
    #endif
    {
    }
}
