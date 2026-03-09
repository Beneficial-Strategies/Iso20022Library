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
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate4Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate4Choice.OriginalMandate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OriginalMandate4Choice.OriginalMandateIdentification),nameof(OriginalMandate4Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate4Choice.OriginalMandate),nameof(OriginalMandate4Choice.OriginalMandate))]
    #endif
    [IsoId("_cvK7RUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Mandate 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OriginalMandate4Choice_
    #else
    public abstract partial class OriginalMandate4Choice_
    #endif
    {
    }
}
