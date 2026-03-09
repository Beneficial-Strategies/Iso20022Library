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
    [KnownType(typeof(SecurityClassificationType2Choice.CFI))]
    [KnownType(typeof(SecurityClassificationType2Choice.AlternateClassification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityClassificationType2Choice.CFI),nameof(SecurityClassificationType2Choice.CFI))]
    [JsonDerivedType(typeof(SecurityClassificationType2Choice.AlternateClassification),nameof(SecurityClassificationType2Choice.AlternateClassification))]
    #endif
    [IsoId("_TrbgMW1MEeiqaPNRWUnGNA")]
    [DisplayName("Security Classification Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityClassificationType2Choice_
    #else
    public abstract partial class SecurityClassificationType2Choice_
    #endif
    {
    }
}
