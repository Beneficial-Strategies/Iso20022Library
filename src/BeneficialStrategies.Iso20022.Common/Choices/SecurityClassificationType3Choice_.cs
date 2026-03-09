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
    /// Choice between a CFI code and an other type of identification for the classification of a financial instrument.
    /// </summary>
    [KnownType(typeof(SecurityClassificationType3Choice.CFI))]
    [KnownType(typeof(SecurityClassificationType3Choice.AlternateClassification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityClassificationType3Choice.CFI),nameof(SecurityClassificationType3Choice.CFI))]
    [JsonDerivedType(typeof(SecurityClassificationType3Choice.AlternateClassification),nameof(SecurityClassificationType3Choice.AlternateClassification))]
    #endif
    [IsoId("_R_yWIf35EeimOuZbLgw0bg")]
    [DisplayName("Security Classification Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityClassificationType3Choice_
    #else
    public abstract partial class SecurityClassificationType3Choice_
    #endif
    {
    }
}
