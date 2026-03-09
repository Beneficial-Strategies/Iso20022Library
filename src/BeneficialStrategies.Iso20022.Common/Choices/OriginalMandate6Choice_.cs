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
    [KnownType(typeof(OriginalMandate6Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate6Choice.OriginalMandate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OriginalMandate6Choice.OriginalMandateIdentification),nameof(OriginalMandate6Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate6Choice.OriginalMandate),nameof(OriginalMandate6Choice.OriginalMandate))]
    #endif
    [IsoId("_Hfkt2W49EeiU9cctagi5ow")]
    [DisplayName("Original Mandate 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OriginalMandate6Choice_
    #else
    public abstract partial class OriginalMandate6Choice_
    #endif
    {
    }
}
