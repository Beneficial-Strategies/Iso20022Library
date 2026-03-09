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
    /// Specifies the enrolment details which is referenced.
    /// </summary>
    [KnownType(typeof(OriginalEnrolment2Choice.OriginalCreditorIdentification))]
    [KnownType(typeof(OriginalEnrolment2Choice.OriginalEnrolmentData))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OriginalEnrolment2Choice.OriginalCreditorIdentification),nameof(OriginalEnrolment2Choice.OriginalCreditorIdentification))]
    [JsonDerivedType(typeof(OriginalEnrolment2Choice.OriginalEnrolmentData),nameof(OriginalEnrolment2Choice.OriginalEnrolmentData))]
    #endif
    [IsoId("_UX7ZV-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Enrolment 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OriginalEnrolment2Choice_
    #else
    public abstract partial class OriginalEnrolment2Choice_
    #endif
    {
    }
}
