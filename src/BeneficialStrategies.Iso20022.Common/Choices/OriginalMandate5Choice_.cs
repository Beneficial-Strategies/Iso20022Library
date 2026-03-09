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
    [KnownType(typeof(OriginalMandate5Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate5Choice.OriginalMandate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OriginalMandate5Choice.OriginalMandateIdentification),nameof(OriginalMandate5Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate5Choice.OriginalMandate),nameof(OriginalMandate5Choice.OriginalMandate))]
    #endif
    [IsoId("_yur0cZR8EeazAtAtDSg0Nw")]
    [DisplayName("Original Mandate 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OriginalMandate5Choice_
    #else
    public abstract partial class OriginalMandate5Choice_
    #endif
    {
    }
}
