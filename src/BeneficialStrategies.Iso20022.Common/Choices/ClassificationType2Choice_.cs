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
    [KnownType(typeof(ClassificationType2Choice.ClassificationFinancialInstrument))]
    [KnownType(typeof(ClassificationType2Choice.AlternateClassification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClassificationType2Choice.ClassificationFinancialInstrument),nameof(ClassificationType2Choice.ClassificationFinancialInstrument))]
    [JsonDerivedType(typeof(ClassificationType2Choice.AlternateClassification),nameof(ClassificationType2Choice.AlternateClassification))]
    #endif
    [IsoId("_Q4NYZdp-Ed-ak6NoX_4Aeg_1716841988")]
    [DisplayName("Classification Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClassificationType2Choice_
    #else
    public abstract partial class ClassificationType2Choice_
    #endif
    {
    }
}
