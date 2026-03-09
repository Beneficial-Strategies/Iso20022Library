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
    /// Specifies the activation details which is referenced.
    /// </summary>
    [KnownType(typeof(OriginalActivation2Choice.OriginalDebtorIdentification))]
    [KnownType(typeof(OriginalActivation2Choice.OriginalActivationData))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OriginalActivation2Choice.OriginalDebtorIdentification),nameof(OriginalActivation2Choice.OriginalDebtorIdentification))]
    [JsonDerivedType(typeof(OriginalActivation2Choice.OriginalActivationData),nameof(OriginalActivation2Choice.OriginalActivationData))]
    #endif
    [IsoId("_UNr4PeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Activation 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OriginalActivation2Choice_
    #else
    public abstract partial class OriginalActivation2Choice_
    #endif
    {
    }
}
