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
    [KnownType(typeof(ClassificationType32Choice.ClassificationFinancialInstrument))]
    [KnownType(typeof(ClassificationType32Choice.AlternateClassification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClassificationType32Choice.ClassificationFinancialInstrument),nameof(ClassificationType32Choice.ClassificationFinancialInstrument))]
    [JsonDerivedType(typeof(ClassificationType32Choice.AlternateClassification),nameof(ClassificationType32Choice.AlternateClassification))]
    #endif
    [IsoId("_IbgeMYlYEeWPSZi0kAOXhg")]
    [DisplayName("Classification Type 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClassificationType32Choice_
    #else
    public abstract partial class ClassificationType32Choice_
    #endif
    {
    }
}
