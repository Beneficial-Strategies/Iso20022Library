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
    [KnownType(typeof(OriginalMandate8Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate8Choice.OriginalMandate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OriginalMandate8Choice.OriginalMandateIdentification),nameof(OriginalMandate8Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate8Choice.OriginalMandate),nameof(OriginalMandate8Choice.OriginalMandate))]
    #endif
    [IsoId("_bPcdsdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OriginalMandate8Choice_
    #else
    public abstract partial class OriginalMandate8Choice_
    #endif
    {
    }
}
